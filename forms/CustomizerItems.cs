using SOR4GameExplorer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SOR4_Swapper
{
    public partial class CustomizerItems : Form
    {
        private readonly MainWindow _mainwindow;
        readonly Library classlib;
        bool justArrived = false;
        bool hasChanges = false;
        bool weaponChangedByUser = false;
        int previousWeaponType = 0;
        readonly string tooltipMoveString = "Damage values are based on a health value of 100.\nValues for Hitstop and Hitstun are in frames (60 per second)";
        readonly string tooltipReset = "Reset";
        readonly string originalValueString = "Original value";
        readonly ToolTip tooltip = new();
        readonly ToolTip resetTooltip = new();
        readonly ToolTip originalTooltip = new();

        List<Control> weaponControls = new();

        ItemClass originalItemDetails;
        ItemClass currentItemDetails;
        int selectedItemKey = -1;
        int swappedItemKey = -1;
        int selectedMoveIndex = -1;


        public CustomizerItems(MainWindow mainwindow)
        {
            InitializeComponent();
            _mainwindow = mainwindow;
            classlib = mainwindow.classlib;

            itemList.DrawMode = DrawMode.OwnerDrawFixed;
            itemList.DrawItem += new DrawItemEventHandler(itemList_DrawItem);
            itemList.SelectedIndexChanged += new EventHandler(itemList_SelectedIndexChanged);

            cmbTransformOnHit.DrawMode = DrawMode.OwnerDrawFixed;
            cmbTransformOnHit.DrawItem += new DrawItemEventHandler(cmbTransformOnHit_DrawItem);

            btnLifeReset.Text = "\u27F3";
            btnScoreReset.Text = "\u27F3";
            btnStarReset.Text = "\u27F3";
            btnThrowDamage.Text = "\u27F3";
            btnHealthReset.Text = "\u27F3";
            btnThrowSpeedReset.Text = "\u27F3";
            btnDamageToSelfOnThrowReset.Text = "\u27F3";

            Control[] weaponControlsForInit = {
                dataGridView1, labelWhenThrown, labelThrowDamage, labelHealth, labelThrowSpeedLabel, labelThrowX, labelThrowY, labelDamageToSelfOnThrow, labelTransformOnHit,
                txtThrowDamage, txtHealth, txtThrowX, txtThrowY, txtDamageToSelfOnThrow,
                chkCatchable, chkRotate, chkGravity, chkPassthrough, chkDroppable, chkThrowOnly,
                btnHealthReset, btnThrowDamage, btnThrowSpeedReset, btnDamageToSelfOnThrowReset,
                cmbTransformOnHit,
                labelMovesSeparator,
            };

            foreach (Control ctl in weaponControlsForInit)
                weaponControls.Add(ctl);
        }

        private void itemList_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font fontToUse = e.Font;
            Brush brush = Brushes.Black;
            if (Library.itemDictionary[e.Index].Path == "n/a")
            {
                fontToUse = new Font("Segoe UI", 10, FontStyle.Bold | FontStyle.Regular);
            }
            else
            {
                e.DrawBackground();
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected) brush = Brushes.White;
                e.DrawFocusRectangle();
            }
            e.Graphics.DrawString(itemList.Items[e.Index].ToString(), fontToUse, brush, e.Bounds);
        }

        private void cmbTransformOnHit_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font fontToUse = e.Font;
            Brush brush = Brushes.Black;
            if (Library.itemDictionary[e.Index].Path == "n/a")
            {
                fontToUse = new Font("Segoe UI", 10, FontStyle.Bold | FontStyle.Regular);
            }
            else
            {
                e.DrawBackground();
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected) brush = Brushes.White;
                e.DrawFocusRectangle();
            }
            e.Graphics.DrawString(itemList.Items[e.Index].ToString(), fontToUse, brush, e.Bounds);
        }


        private void itemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            justArrived = true;
            hasChanges = false;
            ComboBox cmb = (ComboBox)sender;
            cmbFood.Enabled = false;

            if (cmb.SelectedIndex != -1)
            {
                if (Library.itemDictionary[cmb.SelectedIndex].Path == "n/a")
                {
                    cmb.SelectedIndex = -1;
                }
                else
                {
                    // enable controls6
                    selectedItemKey = cmb.SelectedIndex;
                    swappedItemKey = selectedItemKey;
                    if (classlib.itemChangeList.ContainsKey(swappedItemKey)) swappedItemKey = classlib.itemChangeList[swappedItemKey];
                    if (itemList.Text != "") picThumbOrig.Image = _mainwindow.thumbnailslib.getThumbnail("item", swappedItemKey);
                    Control[] controls = { txtLife, txtScore, txtStar, cmbWeaponType, btnSetItem, cmbFood };
                    foreach (Control ctrlname in controls) ctrlname.Enabled = _mainwindow.currentEditable;
                    dataGridView1.Hide();

                    originalItemDetails = classlib.bigfileClass.ItemCollection[swappedItemKey].Copy();
                    currentItemDetails = classlib.bigfileClass.ItemCollection[swappedItemKey].Copy();
                    //if (swappedCharacterClass.WeaponData != null)
                    //    cmbWeaponType.Enabled = false;

                    if (classlib.itemCustomizationInMemory.ContainsKey(selectedItemKey))
                        currentItemDetails = classlib.itemCustomizationInMemory[selectedItemKey].Copy();

                    txtLife.Text = currentItemDetails.Life.ToString();
                    txtScore.Text = currentItemDetails.Score.ToString();
                    txtStar.Text = currentItemDetails.Star.ToString();

                    if (classlib.foodTypeStrings.Contains(currentItemDetails.FoodType))
                        cmbFood.SelectedIndex = classlib.foodTypeStrings.IndexOf(currentItemDetails.FoodType);
                    else
                        cmbFood.SelectedIndex = -1;

                    // reset weapon controls
                    foreach (Control ctl in weaponControls)
                        ctl.ForeColor = Color.Black;

                    PopulateWeaponData(currentItemDetails.WeaponData);
                }
            }
            justArrived = false;
        }



        private Color CompareValues(dynamic memoryValue, dynamic originalValue, Button resetBtn = null)
        {
            Color color = memoryValue != originalValue ? Color.Red : Color.Black;
            if (resetBtn == null)
                resetBtn = btnResetItem;

            if (memoryValue != originalValue)
            {
                resetBtn.Enabled = _mainwindow.currentEditable;
                hasChanges = true;
            }
            else
            {
                resetBtn.Enabled = false;
            }

            if (hasChanges)
                btnResetItem.Enabled = _mainwindow.currentEditable;

            return color;
        }

        private void cmbWeaponType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedItem = itemList.SelectedIndex;
            int swappedItem = selectedItem;
            if (classlib.itemChangeList.ContainsKey(swappedItem)) swappedItem = classlib.itemChangeList[swappedItem];
            ItemClass originalClass = classlib.bigfileClass.ItemCollection[swappedItem].Copy();

            if ((cmbWeaponType.SelectedIndex > 0))
            {
                if (!classlib.itemCustomizationInMemory.ContainsKey(selectedItem))
                    classlib.itemCustomizationInMemory[selectedItem] = originalClass.Copy();

                WeaponClass weapondata = classlib.bigfileClass.originalWeaponTypeData[classlib.weaponTypeStrings[cmbWeaponType.SelectedIndex]];

                // if the selected weapon type is the same as the original, set the original as the original
                // else, get the weapon type's original data and set it as the original
                if ((originalClass.WeaponData != null) && (classlib.weaponTypeStrings[cmbWeaponType.SelectedIndex] == originalClass.WeaponData.WeaponType))
                    originalItemDetails.WeaponData = originalClass.WeaponData;
                else
                    originalItemDetails.WeaponData = classlib.bigfileClass.originalWeaponTypeData[classlib.weaponTypeStrings[cmbWeaponType.SelectedIndex]];

                if (justArrived)
                {
                    if (classlib.itemCustomizationInMemory[selectedItem].WeaponData != null)
                        weapondata = classlib.itemCustomizationInMemory[selectedItem].WeaponData;
                    else
                        weapondata = originalClass.WeaponData;
                }
                else
                {
                    if ((originalClass.WeaponData != null) && (classlib.weaponTypeStrings[cmbWeaponType.SelectedIndex] == originalClass.WeaponData.WeaponType))
                        weapondata = originalClass.WeaponData;
                    else
                        weapondata = classlib.bigfileClass.originalWeaponTypeData[classlib.weaponTypeStrings[cmbWeaponType.SelectedIndex]];
                }

                classlib.itemCustomizationInMemory[selectedItem].WeaponData = weapondata;

                if (justArrived)
                    weaponChangedByUser = false;
                else
                    weaponChangedByUser = true;
                PopulateWeaponData(weapondata, true);
                weaponChangedByUser = true;

                foreach (Control ctl in weaponControls)
                {
                    ctl.Show();
                    ctl.Enabled = _mainwindow.currentEditable;
                }
            }
            else if (cmbWeaponType.SelectedIndex == 0)
            {
                foreach (Control ctl in weaponControls)
                {
                    ctl.Hide();
                    ctl.Enabled = false;
                }
                if (classlib.itemCustomizationInMemory.ContainsKey(selectedItem))
                    classlib.itemCustomizationInMemory[selectedItem].WeaponData = null;
            }
            if (!justArrived)
                ProcessControl(cmbWeaponType);
            previousWeaponType = cmbWeaponType.SelectedIndex;
        }

        private void PopulateWeaponData(WeaponClass sourceData, bool weaponTypeChange = false)
        {
            bool isWeapon = true;
            WeaponClass weapondata;
            if (sourceData == null)
            {
                isWeapon = false;
                weapondata = new();
                weapondata.ThrowDamage = 0;
                weapondata.Health = 0;
                weapondata.DestroyNoLife = false;
                weapondata.CatchableInAir = false;
                weapondata.DestroyNoLife = false;
                weapondata.RotateWhenThrown = false;
                weapondata.ApplyGravity = false;
                weapondata.PassThrough = false;
                weapondata.Droppable = false;
                weapondata.ThrowOnly = false;
                weapondata.TransformTarget = null;
                weapondata.ThrowSpeed = new()
                {
                    X = 0,
                    Y = 0,
                };
                if (weaponTypeChange)
                    weapondata.WeaponType = classlib.weaponTypeStrings[cmbWeaponType.SelectedIndex];
            }
            else
            {
                weapondata = sourceData.Copy();
            }
            txtThrowDamage.Text = weapondata.ThrowDamage.ToString();
            txtHealth.Text = weapondata.Health.ToString();
            chkCatchable.Checked = weapondata.CatchableInAir;
            chkRotate.Checked = weapondata.RotateWhenThrown;
            chkGravity.Checked = weapondata.ApplyGravity;
            chkPassthrough.Checked = weapondata.PassThrough;
            chkDroppable.Checked = weapondata.Droppable;
            chkThrowOnly.Checked = weapondata.ThrowOnly;
            txtThrowX.Text = weapondata.ThrowSpeed.X.ToString();
            txtThrowY.Text = weapondata.ThrowSpeed.Y.ToString();
            txtDamageToSelfOnThrow.Text = weapondata.DamageOnSelfOnThrow.ToString();
            if ((weapondata.TransformTarget != null) && (weapondata.TransformTarget != ""))
                cmbTransformOnHit.SelectedIndex = classlib.itemPathToIndex[weapondata.TransformTarget];
            else
                cmbTransformOnHit.SelectedIndex = -1;

            if (!weaponTypeChange)
            {
                weaponChangedByUser = false;
                if ((weapondata != null) && classlib.weaponTypeStrings.Contains(weapondata.WeaponType))
                    cmbWeaponType.SelectedIndex = classlib.weaponTypeStrings.IndexOf(weapondata.WeaponType);
                else
                    cmbWeaponType.SelectedIndex = 0;
                weaponChangedByUser = true;
            }

            dataGridView1.Rows.Clear();
            int hitctr = 0;
            if ((weapondata.Hits != null) && (weapondata.Hits.Count > 0))
            {
                foreach (var hit in weapondata.Hits)
                {
                    dataGridView1.Rows.Add(hitctr + 1, hit.Damage, hit.Hitstop, hit.Hitstun, hit.MultiHit, hit.RecoverHP, hit.XForce, hit.YForce, hit.DamageToSelf);
                    if (originalItemDetails.WeaponData != null)
                    {
                        if (
                            (hit != null)
                            && (originalItemDetails.WeaponData.Hits.Count > hitctr)
                            )
                        {
                            if (hit.Damage != originalItemDetails.WeaponData.Hits[hitctr].Damage)
                            {
                                dataGridView1.Rows[hitctr].Cells["damage"].Style.ForeColor = Color.Red;
                                dataGridView1.Rows[hitctr].Cells["damage"].ToolTipText = tooltipMoveString;
                                btnResetWeapon.Enabled = _mainwindow.currentEditable;
                            }
                            else
                                dataGridView1.Rows[hitctr].Cells["damage"].Style.ForeColor = Color.Black;

                            if (hit.Hitstop != originalItemDetails.WeaponData.Hits[hitctr].Hitstop)
                            {
                                dataGridView1.Rows[hitctr].Cells["hitstop"].Style.ForeColor = Color.Red;
                                dataGridView1.Rows[hitctr].Cells["hitstop"].ToolTipText = tooltipMoveString;
                                btnResetWeapon.Enabled = _mainwindow.currentEditable;
                            }
                            else
                                dataGridView1.Rows[hitctr].Cells["hitstop"].Style.ForeColor = Color.Black;

                            if (hit.Hitstun != originalItemDetails.WeaponData.Hits[hitctr].Hitstun)
                            {
                                dataGridView1.Rows[hitctr].Cells["hitstun"].Style.ForeColor = Color.Red;
                                dataGridView1.Rows[hitctr].Cells["hitstun"].ToolTipText = tooltipMoveString;
                                btnResetWeapon.Enabled = _mainwindow.currentEditable;
                            }
                            else
                                dataGridView1.Rows[hitctr].Cells["hitstun"].Style.ForeColor = Color.Black;

                            if (hit.MultiHit != originalItemDetails.WeaponData.Hits[hitctr].MultiHit)
                            {
                                dataGridView1.Rows[hitctr].Cells["multi"].Style.ForeColor = Color.Red;
                                dataGridView1.Rows[hitctr].Cells["multi"].ToolTipText = tooltipMoveString;
                                btnResetWeapon.Enabled = _mainwindow.currentEditable;
                            }
                            if (hit.RecoverHP != originalItemDetails.WeaponData.Hits[hitctr].RecoverHP)
                            {
                                dataGridView1.Rows[hitctr].Cells["recoverHP"].Style.ForeColor = Color.Red;
                                dataGridView1.Rows[hitctr].Cells["recoverHP"].ToolTipText = tooltipMoveString;
                                btnResetWeapon.Enabled = _mainwindow.currentEditable;
                            }
                            if (hit.XForce != originalItemDetails.WeaponData.Hits[hitctr].XForce)
                            {
                                dataGridView1.Rows[hitctr].Cells["xForce"].Style.ForeColor = Color.Red;
                                dataGridView1.Rows[hitctr].Cells["xForce"].ToolTipText = tooltipMoveString;
                                btnResetWeapon.Enabled = _mainwindow.currentEditable;
                            }
                            else
                                dataGridView1.Rows[hitctr].Cells["xForce"].Style.ForeColor = Color.Black;

                            if (hit.YForce != originalItemDetails.WeaponData.Hits[hitctr].YForce)
                            {
                                dataGridView1.Rows[hitctr].Cells["yForce"].Style.ForeColor = Color.Red;
                                dataGridView1.Rows[hitctr].Cells["yForce"].ToolTipText = tooltipMoveString;
                                btnResetWeapon.Enabled = _mainwindow.currentEditable;
                            }
                            else
                                dataGridView1.Rows[hitctr].Cells["yForce"].Style.ForeColor = Color.Black;

                            if (hit.DamageToSelf != originalItemDetails.WeaponData.Hits[hitctr].DamageToSelf)
                            {
                                dataGridView1.Rows[hitctr].Cells["damageToSelf"].Style.ForeColor = Color.Red;
                                dataGridView1.Rows[hitctr].Cells["damageToSelf"].ToolTipText = tooltipMoveString;
                                btnResetWeapon.Enabled = _mainwindow.currentEditable;
                            }
                            else
                                dataGridView1.Rows[hitctr].Cells["damageToSelf"].Style.ForeColor = Color.Black;
                        }

                    }

                    hitctr++;
                }
            }

            foreach (Control ctl in weaponControls)
            {
                ctl.Visible = isWeapon;
                ctl.Enabled = (_mainwindow.currentEditable ?isWeapon : _mainwindow.currentEditable);
                if (!justArrived)
                    ProcessControl(ctl);
            }
        }

        private void btnSetItem_Click(object sender, EventArgs e)
        {
            if (itemList.SelectedIndex > -1)
            {
                WeaponClass weapondata = new();
                if (cmbWeaponType.SelectedIndex > 0)
                {
                    List<HitValue> hitlist;
                    if (classlib.itemCustomizationInMemory.ContainsKey(selectedItemKey))
                        if (classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.Hits != null)
                            hitlist = classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.Hits;
                        else
                            hitlist = null;
                    else
                        hitlist = originalItemDetails.WeaponData.Hits;

                    weapondata.ThrowDamage = int.Parse(txtThrowDamage.Text);
                    weapondata.Health = int.Parse(txtHealth.Text);
                    weapondata.CatchableInAir = chkCatchable.Checked;
                    weapondata.RotateWhenThrown = chkRotate.Checked;
                    weapondata.ApplyGravity = chkGravity.Checked;
                    weapondata.PassThrough = chkPassthrough.Checked;
                    weapondata.Droppable = chkDroppable.Checked;
                    weapondata.ThrowOnly = chkThrowOnly.Checked;
                    weapondata.ThrowSpeed.X = int.Parse(txtThrowX.Text);
                    weapondata.ThrowSpeed.Y = int.Parse(txtThrowY.Text);
                    weapondata.DamageOnSelfOnThrow = int.Parse(txtDamageToSelfOnThrow.Text);
                    weapondata.WeaponType = classlib.weaponTypeStrings[cmbWeaponType.SelectedIndex];
                    if (cmbTransformOnHit.SelectedIndex > -1)
                        weapondata.TransformTarget = Library.itemDictionary[cmbTransformOnHit.SelectedIndex].Path;
                    else
                        weapondata.TransformTarget = "";
                    weapondata.Hits = hitlist;
                }
                else
                {
                    weapondata = null;
                }

                ItemClass itemDetails = new()
                {
                    NewItemId = swappedItemKey,
                    Life = int.Parse(txtLife.Text),
                    Score = int.Parse(txtScore.Text),
                    Star = int.Parse(txtStar.Text),
                    WeaponData = weapondata,
                    FoodType = classlib.foodTypeStrings[cmbFood.SelectedIndex],
                };

                if (_mainwindow.Width < _mainwindow.fullWindowWidth) _mainwindow.Width = _mainwindow.fullWindowWidth;
                _mainwindow.ToggleShowHideListLabels(true);
                btnClearSwapList.Enabled = true;
                _mainwindow.itemcustomizerpanel.dataGridView1.Visible = true;
                _mainwindow.container.btnStartReplace.Enabled = true;
                _mainwindow.container.btnClearAllSwaps.Enabled = true;

                classlib.AddCustomItem(_mainwindow, "item", selectedItemKey, itemDetails);

                if ((_mainwindow.info.labelLoadedSwapFile.Visible) && (!_mainwindow.info.labelLoadedSwapFile.Text.Contains(" (modified)"))) _mainwindow.info.labelLoadedSwapFile.Text += " (modified)";

            }
            else
            {
                MessageBox.Show("Please make sure, uh... Yeah.", "Character name is empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                ResetCustomizer("hit", e.RowIndex, true);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (itemList.SelectedIndex > -1)
            {
                int? originalValue = null;

                // not triggered by regular changes in weapon details
                if (!classlib.itemCustomizationInMemory.ContainsKey(selectedItemKey))
                    classlib.itemCustomizationInMemory[selectedItemKey] = originalItemDetails.Copy();
                if (classlib.itemCustomizationInMemory[selectedItemKey].WeaponData == null)
                    classlib.itemCustomizationInMemory[selectedItemKey].WeaponData = new();
                if (classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.Hits == null)
                    classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.Hits = new();

                switch (e.ColumnIndex)
                {
                    case 1:
                        classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.Hits[e.RowIndex].Damage = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                        if (
                            originalItemDetails.WeaponData != null
                            && originalItemDetails.WeaponData.Hits != null
                            && originalItemDetails.WeaponData.Hits[e.RowIndex] != null
                            )
                        {
                            originalValue = originalItemDetails.WeaponData.Hits[e.RowIndex].Damage;
                        }
                        if ((originalValue == null) || ((originalValue != null) && ((int)originalValue != classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.Hits[e.RowIndex].Damage)))
                        {
                            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
                            btnResetItem.Enabled = _mainwindow.currentEditable;
                            btnResetWeapon.Enabled = _mainwindow.currentEditable;
                        }
                        break;
                    case 2:
                        classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.Hits[e.RowIndex].Hitstop = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                        if (
                            originalItemDetails.WeaponData != null
                            && originalItemDetails.WeaponData.Hits != null
                            && originalItemDetails.WeaponData.Hits[e.RowIndex] != null
                            )
                        {
                            originalValue = originalItemDetails.WeaponData.Hits[e.RowIndex].Hitstop;
                        }
                        if ((originalValue == null) || ((originalValue != null) && ((int)originalValue != classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.Hits[e.RowIndex].Hitstop)))
                        {
                            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
                            btnResetItem.Enabled = _mainwindow.currentEditable;
                            btnResetWeapon.Enabled = _mainwindow.currentEditable;
                        }
                        break;
                    case 3:
                        classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.Hits[e.RowIndex].Hitstun = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                        if (
                            originalItemDetails.WeaponData != null
                            && originalItemDetails.WeaponData.Hits != null
                            && originalItemDetails.WeaponData.Hits[e.RowIndex] != null
                            )
                        {
                            originalValue = originalItemDetails.WeaponData.Hits[e.RowIndex].Hitstun;
                        }
                        if ((originalValue == null) || ((originalValue != null) && ((int)originalValue != classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.Hits[e.RowIndex].Hitstun)))
                        {
                            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
                            btnResetItem.Enabled = _mainwindow.currentEditable;
                            btnResetWeapon.Enabled = _mainwindow.currentEditable;
                        }
                        break;
                    case 4:
                        classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.Hits[e.RowIndex].MultiHit = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                        break;
                    case 5:
                        classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.Hits[e.RowIndex].RecoverHP = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                        break;
                    case 6:
                        classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.Hits[e.RowIndex].XForce = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                        if (
                            originalItemDetails.WeaponData != null
                            && originalItemDetails.WeaponData.Hits != null
                            && originalItemDetails.WeaponData.Hits[e.RowIndex] != null
                            )
                        {
                            originalValue = originalItemDetails.WeaponData.Hits[e.RowIndex].XForce;
                        }
                        if ((originalValue == null) || ((originalValue != null) && ((int)originalValue != classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.Hits[e.RowIndex].XForce)))
                        {
                            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
                            btnResetItem.Enabled = _mainwindow.currentEditable;
                            btnResetWeapon.Enabled = _mainwindow.currentEditable;
                        }
                        break;
                    case 7:
                        classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.Hits[e.RowIndex].YForce = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                        if (
                            originalItemDetails.WeaponData != null
                            && originalItemDetails.WeaponData.Hits != null
                            && originalItemDetails.WeaponData.Hits[e.RowIndex] != null
                            )
                        {
                            originalValue = originalItemDetails.WeaponData.Hits[e.RowIndex].YForce;
                        }
                        if ((originalValue == null) || ((originalValue != null) && ((int)originalValue != classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.Hits[e.RowIndex].YForce)))
                        {
                            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
                            btnResetItem.Enabled = _mainwindow.currentEditable;
                            btnResetWeapon.Enabled = _mainwindow.currentEditable;
                        }
                        break;
                    case 8:
                        classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.Hits[e.RowIndex].DamageToSelf = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                        if (
                            originalItemDetails.WeaponData != null
                            && originalItemDetails.WeaponData.Hits != null
                            && originalItemDetails.WeaponData.Hits[e.RowIndex] != null
                            )
                        {
                            originalValue = originalItemDetails.WeaponData.Hits[e.RowIndex].DamageToSelf;
                        }
                        if ((originalValue == null) || ((originalValue != null) && ((int)originalValue != classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.Hits[e.RowIndex].DamageToSelf)))
                        {
                            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
                            btnResetItem.Enabled = _mainwindow.currentEditable;
                            btnResetWeapon.Enabled = _mainwindow.currentEditable;
                        }
                        break;
                }
            }
        }

        private void ResetCustomizer(string resetTargetType, int hitRowCtr = 0, bool fromHitResetButton = false)
        {
            switch (resetTargetType)
            {
                case "item":
                    hasChanges = false;
                    if (classlib.foodTypeStrings.Contains(originalItemDetails.FoodType))
                        cmbFood.SelectedIndex = classlib.foodTypeStrings.IndexOf(originalItemDetails.FoodType);
                    else
                        cmbFood.SelectedIndex = -1;

                    if (originalItemDetails.WeaponData != null)
                    {
                        weaponChangedByUser = false;
                        if (classlib.weaponTypeStrings.Contains(originalItemDetails.WeaponData.WeaponType))
                            cmbWeaponType.SelectedIndex = classlib.weaponTypeStrings.IndexOf(originalItemDetails.WeaponData.WeaponType);
                        else
                            cmbWeaponType.SelectedIndex = 0;
                        weaponChangedByUser = true;
                    }
                    else
                    {
                        cmbWeaponType.SelectedIndex = 0;
                    }

                    txtLife.Text = originalItemDetails.Life.ToString();
                    txtScore.Text = originalItemDetails.Score.ToString();
                    txtStar.Text = originalItemDetails.Star.ToString();

                    PopulateWeaponData(originalItemDetails.WeaponData);

                    btnResetItem.Enabled = false;
                    btnResetWeapon.Enabled = false;
                    break;
                case "weapon":
                    PopulateWeaponData(originalItemDetails.WeaponData);
                    btnResetWeapon.Enabled = false;
                    break;
                case "hit":
                    if (originalItemDetails.WeaponData == null)
                        originalItemDetails.WeaponData = classlib.bigfileClass.originalWeaponTypeData[classlib.weaponTypeStrings[cmbWeaponType.SelectedIndex]];

                    HitValue hitValue = originalItemDetails.WeaponData.Hits[hitRowCtr].Copy();
                    classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.Hits[hitRowCtr].Damage = hitValue.Damage;
                    classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.Hits[hitRowCtr].Hitstop = hitValue.Hitstop;
                    classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.Hits[hitRowCtr].Hitstun = hitValue.Hitstun;
                    classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.Hits[hitRowCtr].MultiHit = hitValue.MultiHit;
                    classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.Hits[hitRowCtr].RecoverHP = hitValue.RecoverHP;
                    classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.Hits[hitRowCtr].XForce = hitValue.XForce;
                    classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.Hits[hitRowCtr].YForce = hitValue.YForce;
                    classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.Hits[hitRowCtr].DamageToSelf = hitValue.DamageToSelf;

                    // if coming from Hit Reset button, will not reset the data grid view
                    if (fromHitResetButton)
                    {
                        dataGridView1.Rows[hitRowCtr].Cells["damage"].Value = hitValue.Damage;
                        dataGridView1.Rows[hitRowCtr].Cells["hitstop"].Value = hitValue.Hitstop;
                        dataGridView1.Rows[hitRowCtr].Cells["hitstun"].Value = hitValue.Hitstun;
                        dataGridView1.Rows[hitRowCtr].Cells["multi"].Value = hitValue.MultiHit;
                        dataGridView1.Rows[hitRowCtr].Cells["recoverHP"].Value = hitValue.RecoverHP;
                        dataGridView1.Rows[hitRowCtr].Cells["xForce"].Value = hitValue.XForce;
                        dataGridView1.Rows[hitRowCtr].Cells["yForce"].Value = hitValue.YForce;
                        dataGridView1.Rows[hitRowCtr].Cells["damageToSelf"].Value = hitValue.DamageToSelf;
                        dataGridView1.Rows[hitRowCtr].Cells["damage"].Style.ForeColor = Color.Black;
                        dataGridView1.Rows[hitRowCtr].Cells["hitstop"].Style.ForeColor = Color.Black;
                        dataGridView1.Rows[hitRowCtr].Cells["hitstun"].Style.ForeColor = Color.Black;
                        dataGridView1.Rows[hitRowCtr].Cells["multi"].Style.ForeColor = Color.Black;
                        dataGridView1.Rows[hitRowCtr].Cells["recoverHP"].Style.ForeColor = Color.Black;
                        dataGridView1.Rows[hitRowCtr].Cells["xForce"].Style.ForeColor = Color.Black;
                        dataGridView1.Rows[hitRowCtr].Cells["yForce"].Style.ForeColor = Color.Black;
                        dataGridView1.Rows[hitRowCtr].Cells["damageToSelf"].Style.ForeColor = Color.Black;
                    }
                    // if not, will be from Move Reset button which will clear the data grid view before this
                    else
                    {
                        dataGridView1.Rows.Add(hitRowCtr + 1, hitValue.Damage, hitValue.Hitstop, hitValue.Hitstun, hitValue.MultiHit, hitValue.RecoverHP, hitValue.XForce, hitValue.YForce, hitValue.DamageToSelf);
                    }
                    break;
            }
        }

        private void ProcessControl(Control control)
        {
            if ((selectedItemKey > -1) && weaponChangedByUser)
            {
                Control targetControl = control;
                dynamic memoryValue = "";
                dynamic originalValue = "";
                Button resetButton = null;

                if (!classlib.itemCustomizationInMemory.ContainsKey(selectedItemKey))
                    classlib.itemCustomizationInMemory[selectedItemKey] = originalItemDetails.Copy();

                switch (control.Name)
                {
                    case "txtLife":
                        memoryValue = ValidateData(control.Text.Trim(), "health", originalItemDetails.Life);
                        originalValue = originalItemDetails.Life;
                        classlib.itemCustomizationInMemory[selectedItemKey].Life = memoryValue;
                        control.Text = memoryValue.ToString();
                        targetControl = labelLife;
                        btnLifeReset.Enabled = memoryValue != originalValue;
                        labelOrigLife.Text = originalValue.ToString();
                        labelOrigLife.Visible = memoryValue != originalValue;
                        resetButton = btnLifeReset;
                        break;
                    case "txtScore":
                        memoryValue = ValidateData(control.Text.Trim(), "scale", originalItemDetails.Score);
                        originalValue = originalItemDetails.Score;
                        classlib.itemCustomizationInMemory[selectedItemKey].Score = memoryValue;
                        control.Text = memoryValue.ToString();
                        targetControl = labelScore;
                        btnScoreReset.Enabled = memoryValue != originalValue;
                        labelOrigScore.Text = originalValue.ToString();
                        labelOrigScore.Visible = memoryValue != originalValue;
                        break;
                    case "txtStar":
                        memoryValue = ValidateData(control.Text.Trim(), "scale", originalItemDetails.Star);
                        originalValue = originalItemDetails.Star;
                        classlib.itemCustomizationInMemory[selectedItemKey].Star = memoryValue;
                        control.Text = memoryValue.ToString();
                        targetControl = labelStar;
                        btnStarReset.Enabled = memoryValue != originalValue;
                        labelOrigStar.Text = originalValue.ToString();
                        labelOrigStar.Visible = memoryValue != originalValue;
                        break;
                    case "txtHealth":
                        if (originalItemDetails.WeaponData != null)
                        {
                            memoryValue = ValidateData(control.Text.Trim(), "damage", originalItemDetails.WeaponData.Health);
                            originalValue = originalItemDetails.WeaponData.Health;
                        }
                        else
                        {
                            memoryValue = ValidateData(control.Text.Trim(), "damage", 0);
                            originalValue = 0;
                        }
                        if (classlib.itemCustomizationInMemory[selectedItemKey].WeaponData != null)
                        {
                            classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.Health = memoryValue;
                            control.Text = memoryValue.ToString();
                            targetControl = labelHealth;
                            btnHealthReset.Enabled = memoryValue != originalValue;
                            labelOrigHealth.Text = originalValue.ToString();
                            labelOrigHealth.Visible = memoryValue != originalValue;
                            btnResetWeapon.Enabled = _mainwindow.currentEditable;
                        }
                        break;
                    case "txtThrowDamage":
                        if (originalItemDetails.WeaponData != null)
                        {
                            memoryValue = ValidateData(control.Text.Trim(), "damage", originalItemDetails.WeaponData.ThrowDamage);
                            originalValue = originalItemDetails.WeaponData.ThrowDamage;
                        }
                        else
                        {
                            memoryValue = ValidateData(control.Text.Trim(), "damage", 0);
                            originalValue = 0;
                        }
                        if (classlib.itemCustomizationInMemory[selectedItemKey].WeaponData != null)
                        {
                            classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.ThrowDamage = memoryValue;
                            control.Text = memoryValue.ToString();
                            targetControl = labelThrowDamage;
                            btnThrowDamage.Enabled = memoryValue != originalValue;
                            labelOrigThrowDamage.Text = originalValue.ToString();
                            labelOrigThrowDamage.Visible = memoryValue != originalValue;
                            btnResetWeapon.Enabled = _mainwindow.currentEditable;
                        }
                        break;
                    case "txtThrowX":
                        if (originalItemDetails.WeaponData != null)
                        {
                            memoryValue = ValidateData(control.Text.Trim(), "speed", originalItemDetails.WeaponData.ThrowSpeed.X);
                            originalValue = originalItemDetails.WeaponData.ThrowSpeed.X;
                        }
                        else
                        {
                            memoryValue = ValidateData(control.Text.Trim(), "speed", 0);
                            originalValue = 0;
                        }

                        if (classlib.itemCustomizationInMemory[selectedItemKey].WeaponData != null)
                        {
                            classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.ThrowSpeed.X = memoryValue;
                            control.Text = memoryValue.ToString();
                            targetControl = labelThrowX;
                            btnThrowSpeedReset.Enabled = memoryValue != originalValue;
                            labelOrigThrowX.Text = originalValue.ToString();
                            labelOrigThrowX.Visible = memoryValue != originalValue;
                            btnResetWeapon.Enabled = _mainwindow.currentEditable;
                        }

                        break;
                    case "txtThrowY":
                        if (originalItemDetails.WeaponData != null)
                        {
                            memoryValue = ValidateData(control.Text.Trim(), "speed", originalItemDetails.WeaponData.ThrowSpeed.Y);
                            originalValue = originalItemDetails.WeaponData.ThrowSpeed.Y;
                        }
                        else
                        {
                            memoryValue = ValidateData(control.Text.Trim(), "speed", 0);
                            originalValue = 0;
                        }
                        if (classlib.itemCustomizationInMemory[selectedItemKey].WeaponData != null)
                        {
                            classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.ThrowSpeed.Y = memoryValue;
                            control.Text = memoryValue.ToString();
                            targetControl = labelThrowY;
                            btnThrowSpeedReset.Enabled = memoryValue != originalValue;
                            labelOrigThrowY.Text = originalValue.ToString();
                            labelOrigThrowY.Visible = memoryValue != originalValue;
                            btnResetWeapon.Enabled = _mainwindow.currentEditable;
                        }
                        break;
                    case "txtDamageToSelfOnThrow":
                        if (originalItemDetails.WeaponData != null)
                        {
                            memoryValue = ValidateData(control.Text.Trim(), "damage", originalItemDetails.WeaponData.DamageOnSelfOnThrow);
                            originalValue = originalItemDetails.WeaponData.DamageOnSelfOnThrow;
                        }
                        else
                        {
                            memoryValue = ValidateData(control.Text.Trim(), "damage", 0);
                            originalValue = 0;
                        }
                        if (classlib.itemCustomizationInMemory[selectedItemKey].WeaponData != null)
                        {
                            classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.DamageOnSelfOnThrow = memoryValue;
                            control.Text = memoryValue.ToString();
                            targetControl = labelDamageToSelfOnThrow;
                            btnDamageToSelfOnThrowReset.Enabled = memoryValue != originalValue;
                            labelOrigDamageToSelfOnThrow.Text = originalValue.ToString();
                            labelOrigDamageToSelfOnThrow.Visible = memoryValue != originalValue;
                            btnResetWeapon.Enabled = _mainwindow.currentEditable;
                        }
                        break;
                    case "chkDespawn":
                        memoryValue = chkCatchable.Checked;
                        if (originalItemDetails.WeaponData != null)
                            originalValue = originalItemDetails.WeaponData.DestroyNoLife;
                        else
                            originalValue = false;

                        classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.DestroyNoLife = memoryValue;
                        btnResetWeapon.Enabled = _mainwindow.currentEditable;
                        break;
                    case "chkCatchable":
                        memoryValue = chkCatchable.Checked;
                        if (originalItemDetails.WeaponData != null)
                            originalValue = originalItemDetails.WeaponData.CatchableInAir;
                        else
                            originalValue = false;

                        if (classlib.itemCustomizationInMemory[selectedItemKey].WeaponData != null)
                            classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.CatchableInAir = memoryValue;
                        btnResetWeapon.Enabled = _mainwindow.currentEditable;
                        break;
                    case "chkRotate":
                        memoryValue = chkRotate.Checked;
                        if (originalItemDetails.WeaponData != null)
                            originalValue = originalItemDetails.WeaponData.RotateWhenThrown;
                        else
                            originalValue = false;

                        if (classlib.itemCustomizationInMemory[selectedItemKey].WeaponData != null)
                            classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.RotateWhenThrown = memoryValue;
                        btnResetWeapon.Enabled = _mainwindow.currentEditable;
                        break;
                    case "chkGravity":
                        memoryValue = chkGravity.Checked;
                        if (originalItemDetails.WeaponData != null)
                            originalValue = originalItemDetails.WeaponData.ApplyGravity;
                        else
                            originalValue = false;

                        if (classlib.itemCustomizationInMemory[selectedItemKey].WeaponData != null)
                            classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.ApplyGravity = memoryValue;
                        btnResetWeapon.Enabled = _mainwindow.currentEditable;
                        break;
                    case "chkPassthrough":
                        memoryValue = chkPassthrough.Checked;
                        if (originalItemDetails.WeaponData != null)
                            originalValue = originalItemDetails.WeaponData.PassThrough;
                        else
                            originalValue = false;

                        if (classlib.itemCustomizationInMemory[selectedItemKey].WeaponData != null)
                            classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.PassThrough = memoryValue;
                        btnResetWeapon.Enabled = _mainwindow.currentEditable;
                        break;
                    case "chkDroppable":
                        memoryValue = chkDroppable.Checked;
                        if (originalItemDetails.WeaponData != null)
                            originalValue = originalItemDetails.WeaponData.Droppable;
                        else
                            originalValue = false;

                        if (classlib.itemCustomizationInMemory[selectedItemKey].WeaponData != null)
                            classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.Droppable = memoryValue;
                        btnResetWeapon.Enabled = _mainwindow.currentEditable;
                        break;
                    case "chkThrowOnly":
                        memoryValue = chkThrowOnly.Checked;
                        if (originalItemDetails.WeaponData != null)
                            originalValue = originalItemDetails.WeaponData.ThrowOnly;
                        else
                            originalValue = false;

                        if (classlib.itemCustomizationInMemory[selectedItemKey].WeaponData != null)
                            classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.ThrowOnly = memoryValue;
                        btnResetWeapon.Enabled = _mainwindow.currentEditable;
                        break;
                    case "cmbFood":
                        memoryValue = classlib.foodTypeStrings[cmbFood.SelectedIndex];
                        originalValue = originalItemDetails.FoodType;
                        targetControl = labelFood;
                        classlib.itemCustomizationInMemory[selectedItemKey].FoodType = memoryValue;
                        break;
                    case "cmbTransformOnHit":
                        if ((cmbTransformOnHit.SelectedIndex != -1) && (Library.itemDictionary[cmbTransformOnHit.SelectedIndex].Path != "n/a"))
                            memoryValue = Library.itemDictionary[cmbTransformOnHit.SelectedIndex].Path;
                        else
                            memoryValue = null;
                        if ((originalItemDetails.WeaponData != null) && (originalItemDetails.WeaponData.TransformTarget != null))
                            originalValue = originalItemDetails.WeaponData.TransformTarget;
                        else
                            originalValue = null;

                        if (classlib.itemCustomizationInMemory[selectedItemKey].WeaponData != null)
                            classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.TransformTarget = memoryValue;
                        targetControl = labelTransformOnHit;
                        btnResetWeapon.Enabled = _mainwindow.currentEditable;
                        break;
                    case "cmbWeaponType":
                        memoryValue = classlib.weaponTypeStrings[cmbWeaponType.SelectedIndex];
                        if (originalItemDetails.WeaponData != null)
                            originalValue = originalItemDetails.WeaponData.WeaponType;
                        else
                            originalValue = classlib.weaponTypeStrings[0];

                        if (cmbWeaponType.SelectedIndex > 0)
                        {
                            WeaponClass weapondata = originalItemDetails.WeaponData;
                            if (originalItemDetails.WeaponData == null)
                                weapondata = classlib.bigfileClass.originalWeaponTypeData[classlib.weaponTypeStrings[cmbWeaponType.SelectedIndex]];
                            classlib.itemCustomizationInMemory[selectedItemKey].WeaponData = weapondata.Copy();
                            classlib.itemCustomizationInMemory[selectedItemKey].WeaponData.WeaponType = memoryValue;
                        }
                        else
                        {
                            classlib.itemCustomizationInMemory[selectedItemKey].WeaponData = null;
                        }

                        targetControl = labelWeapon;
                        btnResetWeapon.Enabled = _mainwindow.currentEditable;
                        break;
                }

                control.ForeColor = CompareValues(memoryValue, originalValue, resetButton);
                targetControl.ForeColor = control.ForeColor;
                if (memoryValue != originalValue)
                    btnResetItem.Enabled = _mainwindow.currentEditable;
            }
        }

        #region Process Control & Reset
        private void cmbFood_SelectedIndexChanged(object sender, EventArgs e) => ProcessControl(cmbFood);

        private void txtHealth_TextChanged(object sender, EventArgs e) => ProcessControl(txtHealth);

        private void txtThrowDamage_TextChanged(object sender, EventArgs e) => ProcessControl(txtThrowDamage);

        private void chkCatchable_CheckedChanged(object sender, EventArgs e) => ProcessControl(chkCatchable);

        private void chkRotate_CheckedChanged(object sender, EventArgs e) => ProcessControl(chkRotate);

        private void chkGravity_CheckedChanged(object sender, EventArgs e) => ProcessControl(chkGravity);

        private void chkPassthrough_CheckedChanged(object sender, EventArgs e) => ProcessControl(chkPassthrough);

        private void txtLife_TextChanged(object sender, EventArgs e) => ProcessControl(txtLife);

        private void txtScore_TextChanged(object sender, EventArgs e) => ProcessControl(txtScore);

        private void txtStar_TextChanged(object sender, EventArgs e) => ProcessControl(txtStar);

        private void btnResetWeapon_Click(object sender, EventArgs e) => ResetCustomizer("weapon");

        private void btnResetItem_Click(object sender, EventArgs e) => ResetCustomizer("item");

        private void txtThrowX_TextChanged(object sender, EventArgs e) => ProcessControl(txtThrowX);

        private void txtThrowY_TextChanged(object sender, EventArgs e) => ProcessControl(txtThrowY);

        private void chkDroppable_CheckedChanged(object sender, EventArgs e) => ProcessControl(chkDroppable);

        #endregion

        #region Reset Buttons
        private void btnLifeReset_Click(object sender, EventArgs e)
        {
            if (itemList.SelectedIndex != -1)
            {
                int selectedCharacterKey = itemList.SelectedIndex;
                int swappedCharacterKey = selectedCharacterKey;
                if (classlib.itemChangeList.ContainsKey(swappedCharacterKey)) swappedCharacterKey = classlib.itemChangeList[swappedCharacterKey];
                ItemClass swappedCharacterClass = classlib.bigfileClass.ItemCollection[swappedCharacterKey].Copy();
                txtLife.Text = swappedCharacterClass.Life.ToString();
            }
        }

        private void btnScoreReset_Click(object sender, EventArgs e) => txtScore.Text = currentItemDetails.Score.ToString();
        private void btnStarReset_Click(object sender, EventArgs e) => txtStar.Text = currentItemDetails.Star.ToString();
        private void btnThrowDamage_Click(object sender, EventArgs e)
        {
            if (originalItemDetails.WeaponData != null)
                txtThrowDamage.Text = originalItemDetails.WeaponData.ThrowDamage.ToString();
            else
                txtThrowDamage.Text = "0";
        }

        private void btnHealthReset_Click(object sender, EventArgs e)
        {
            if (originalItemDetails.WeaponData != null)
                txtHealth.Text = originalItemDetails.WeaponData.Health.ToString();
            else
                txtHealth.Text = "0";
        }
        #endregion

        private int ValidateData(string valueString, string characterProperty, int previousValue)
        {
            int returnVal;
            string errorMessage = "";
            int resetValue = 0;
            int maxValue = int.MaxValue;
            int minValue = int.MinValue;
            if (Int64.TryParse(valueString, out long inputValue))
            {
                switch (characterProperty)
                {
                    case "health":
                        maxValue = 32767;
                        minValue = 0;
                        break;
                    case "damage":
                        maxValue = 32767;
                        minValue = -32767;
                        break;
                    case "speed":
                        maxValue = 99999;
                        break;
                    case "team":
                        maxValue = 999;
                        minValue = -1;
                        break;
                    case "scale":
                        maxValue = 99999;
                        minValue = 0;
                        break;
                    case "greenHP":
                        maxValue = 100;
                        minValue = 0;
                        break;
                }
                if (inputValue > maxValue)
                {
                    resetValue = maxValue;
                    switch (characterProperty)
                    {
                        case "health":
                            //errorMessage = "The Health value you input is bigger than what Galsia understands. This has been reset down to " + resetValue + ".";
                            errorMessage = "";
                            break;
                        case "speed":
                            resetValue = 99999;
                            //errorMessage = "Shadow does not understand the Speed value you input. This has been reset down to " + resetValue + ".";
                            errorMessage = "";
                            break;
                        case "team":
                        case "scale":
                        case "damage":
                            errorMessage = "";
                            break;
                    }
                }
                else if (inputValue < minValue)
                {
                    resetValue = minValue;
                    switch (characterProperty)
                    {
                        case "health":
                            //errorMessage = "The Health value is smaller than Mr. X's patience. Resetting to " + minValue + ".";
                            errorMessage = "";
                            break;
                        case "speed":
                            errorMessage = "The Speed value is slower than... slow. This has been reset up to " + minValue + ".";
                            break;
                        case "team":
                            errorMessage = "Minimum value is -1 for \"no team\"";
                            break;
                        case "scale":
                        case "damage":
                            errorMessage = "";
                            break;
                    }
                }
                else
                {
                    resetValue = (int)inputValue;
                }
            }
            else
            {
                // filter for negative numbers depending on Property
                switch (characterProperty)
                {
                    case "health":
                        resetValue = previousValue;
                        errorMessage = "Dr. Zan doesn't understand what you meant by what you put.";
                        break;
                    case "speed":
                        if (valueString != "-")
                        {
                            resetValue = previousValue;
                            errorMessage = "Dr. Zan doesn't understand that. Resetting...";
                        }
                        else
                        {
                            resetValue = -1;
                            errorMessage = "";
                        }
                        break;
                    case "team":
                        if (valueString != "-")
                        {
                            resetValue = previousValue;
                            errorMessage = "Dr. Zan doesn't understand that. Resetting...";
                        }
                        else
                        {
                            resetValue = -1;
                            errorMessage = "";
                        }
                        break;
                    case "scale":
                        if (valueString != "-")
                        {
                            resetValue = previousValue;
                            errorMessage = "Dr. Zan doesn't understand that. Resetting...";
                        }
                        else
                        {
                            resetValue = -1;
                            errorMessage = "";
                        }
                        break;
                    case "damage":
                        if (valueString != "-")
                        {
                            resetValue = previousValue;
                            errorMessage = "Dr. Zan doesn't understand that. Resetting...";
                        }
                        else
                        {
                            resetValue = -32767;
                            errorMessage = "";
                        }
                        break;
                }
            }

            if (errorMessage != "") MessageBox.Show(errorMessage, "Value error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            returnVal = resetValue;
            return returnVal;
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (itemList.SelectedIndex > -1)
            {
                int selectedCharacterKey = itemList.SelectedIndex;
                int swappedCharacterKey = selectedCharacterKey;

                if (classlib.itemChangeList.ContainsKey(swappedCharacterKey)) swappedCharacterKey = classlib.itemChangeList[swappedCharacterKey];
                ItemClass itemClass = classlib.bigfileClass.ItemCollection[swappedCharacterKey].Copy();
                ItemClass originalItemClass = classlib.bigfileClass.ItemCollection[swappedCharacterKey].Copy();

                // if item is not originally a weapon, get the original stats of the basis weapon
                //if (originalItemClass.WeaponData == null)
                    originalItemClass.WeaponData = classlib.bigfileClass.originalWeaponTypeData[classlib.weaponTypeStrings[cmbWeaponType.SelectedIndex]];

                if (!classlib.itemCustomizationInMemory.ContainsKey(selectedCharacterKey))
                    classlib.itemCustomizationInMemory[selectedCharacterKey] = itemClass.Copy();
                if (classlib.itemCustomizationInMemory[selectedCharacterKey].WeaponData == null)
                    classlib.itemCustomizationInMemory[selectedCharacterKey].WeaponData = originalItemClass.WeaponData;


                DataGridViewRow dr = dataGridView1.Rows[e.RowIndex];
                classlib.itemCustomizationInMemory[selectedCharacterKey].WeaponData.Hits[dr.Index].Damage = Convert.ToInt32(dr.Cells["damage"].Value);
                classlib.itemCustomizationInMemory[selectedCharacterKey].WeaponData.Hits[dr.Index].Damage = Convert.ToInt32(dr.Cells["damage"].Value);
                classlib.itemCustomizationInMemory[selectedCharacterKey].WeaponData.Hits[dr.Index].Hitstop = Convert.ToInt32(dr.Cells["hitstop"].Value);
                classlib.itemCustomizationInMemory[selectedCharacterKey].WeaponData.Hits[dr.Index].Hitstun = Convert.ToInt32(dr.Cells["hitstun"].Value);
                classlib.itemCustomizationInMemory[selectedCharacterKey].WeaponData.Hits[dr.Index].MultiHit = Convert.ToBoolean(dr.Cells["multi"].Value);
                classlib.itemCustomizationInMemory[selectedCharacterKey].WeaponData.Hits[dr.Index].RecoverHP = Convert.ToBoolean(dr.Cells["recoverHP"].Value);
                classlib.itemCustomizationInMemory[selectedCharacterKey].WeaponData.Hits[dr.Index].XForce = Convert.ToInt32(dr.Cells["xForce"].Value);
                classlib.itemCustomizationInMemory[selectedCharacterKey].WeaponData.Hits[dr.Index].YForce = Convert.ToInt32(dr.Cells["yForce"].Value);
                classlib.itemCustomizationInMemory[selectedCharacterKey].WeaponData.Hits[dr.Index].DamageToSelf = Convert.ToInt32(dr.Cells["damageToSelf"].Value);

                bool changed = false;

                if (
                    (originalItemClass.WeaponData.WeaponType == classlib.itemCustomizationInMemory[selectedCharacterKey].WeaponData.WeaponType)
                    &&
                    (originalItemClass.WeaponData.Hits.Count > dr.Index)
                    &&
                    (classlib.itemCustomizationInMemory[selectedCharacterKey].WeaponData.Hits.Count > dr.Index)
                    )
                {
                    if (originalItemClass.WeaponData.Hits[dr.Index].Damage != classlib.itemCustomizationInMemory[selectedCharacterKey].WeaponData.Hits[dr.Index].Damage)
                    {
                        dr.Cells["damage"].Style.ForeColor = Color.Red;
                        changed = true;
                    }
                    else
                        dr.Cells["damage"].Style.ForeColor = Color.Black;
                    if (originalItemClass.WeaponData.Hits[dr.Index].Hitstop != classlib.itemCustomizationInMemory[selectedCharacterKey].WeaponData.Hits[dr.Index].Hitstop)
                    {
                        dr.Cells["hitstop"].Style.ForeColor = Color.Red;
                        changed = true;
                    }
                    else
                        dr.Cells["hitstop"].Style.ForeColor = Color.Black;
                    if (originalItemClass.WeaponData.Hits[dr.Index].Hitstun != classlib.itemCustomizationInMemory[selectedCharacterKey].WeaponData.Hits[dr.Index].Hitstun)
                    {
                        dr.Cells["hitstun"].Style.ForeColor = Color.Red;
                        changed = true;
                    }
                    else
                        dr.Cells["hitstun"].Style.ForeColor = Color.Black;
                    if (originalItemClass.WeaponData.Hits[dr.Index].XForce != classlib.itemCustomizationInMemory[selectedCharacterKey].WeaponData.Hits[dr.Index].XForce)
                    {
                        dr.Cells["xForce"].Style.ForeColor = Color.Red;
                        changed = true;
                    }
                    else
                        dr.Cells["xForce"].Style.ForeColor = Color.Black;
                    if (originalItemClass.WeaponData.Hits[dr.Index].YForce != classlib.itemCustomizationInMemory[selectedCharacterKey].WeaponData.Hits[dr.Index].YForce)
                    {
                        dr.Cells["yForce"].Style.ForeColor = Color.Red;
                        changed = true;
                    }
                    else
                        dr.Cells["yForce"].Style.ForeColor = Color.Black;
                    if (originalItemClass.WeaponData.Hits[dr.Index].DamageToSelf != classlib.itemCustomizationInMemory[selectedCharacterKey].WeaponData.Hits[dr.Index].DamageToSelf)
                    {
                        dr.Cells["damageToSelf"].Style.ForeColor = Color.Red;
                        changed = true;
                    }
                    else
                        dr.Cells["damageToSelf"].Style.ForeColor = Color.Black;

                }
                else
                {
                    dr.Cells["damage"].Style.ForeColor = Color.Black;
                    dr.Cells["hitstop"].Style.ForeColor = Color.Black;
                    dr.Cells["hitstun"].Style.ForeColor = Color.Black;
                    dr.Cells["xForce"].Style.ForeColor = Color.Black;
                    dr.Cells["yForce"].Style.ForeColor = Color.Black;
                    dr.Cells["damageToSelf"].Style.ForeColor = Color.Black;
                }


                if (changed)
                {
                    btnResetItem.Enabled = _mainwindow.currentEditable;
                    btnResetWeapon.Enabled = _mainwindow.currentEditable;
                }
            }
        }

        private void btnShowList_Click(object sender, EventArgs e) => _mainwindow.ToggleSwapList(_mainwindow.Width < _mainwindow.fullWindowWidth);

        private void btnClearSwapList_Click(object sender, EventArgs e) => _mainwindow.ClearSwaps("item", "custom");

        private void chkThrowOnly_CheckedChanged(object sender, EventArgs e) => ProcessControl(chkThrowOnly);

        private void cmbTransformOnHit_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            if (cmb.SelectedIndex != -1)
            {
                if (Library.itemDictionary[cmb.SelectedIndex].Path == "n/a")
                    cmb.SelectedIndex = -1;
                ProcessControl(cmbTransformOnHit); 
            }
        }

        private void txtDamageToSelfOnThrow_TextChanged(object sender, EventArgs e) => ProcessControl(txtDamageToSelfOnThrow);

        private void btnThrowYReset_Click(object sender, EventArgs e)
        {
            if (currentItemDetails.WeaponData != null)
            {
                txtThrowX.Text = currentItemDetails.WeaponData.ThrowSpeed.X.ToString();
                txtThrowY.Text = currentItemDetails.WeaponData.ThrowSpeed.Y.ToString();
            }
            else
            {
                txtThrowX.Text = "0";
                txtThrowY.Text = "0";
            }
        }

        private void btnDamageToSelfOnThrowReset_Click(object sender, EventArgs e)
        {
            if (originalItemDetails.WeaponData != null)
                txtDamageToSelfOnThrow.Text = originalItemDetails.WeaponData.DamageOnSelfOnThrow.ToString();
            else
                txtDamageToSelfOnThrow.Text = "0";
        }
    }
}
