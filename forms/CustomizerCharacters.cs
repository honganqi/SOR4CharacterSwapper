using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using SOR4GameExplorer;

namespace SOR4_Swapper
{
    public partial class CustomizerCharacters : Form
    {
        Assembly imageAssembly = Assembly.GetExecutingAssembly();
        private MainWindow _mainwindow;
        Library classlib;
        bool justArrived = false;
        bool hasChanges = false;
        string tooltipNameString = "Using small letters will look awkward in the game";
        string tooltipHealthString = "A full healthbar has a value of 100";
        string tooltipSpeedXString = "Horizontal speed / X-axis\n\nIf this is red, this will be ignored by the global movement speed modifier.";
        string tooltipSpeedYString = "Vertical speed / Y-axis\n\nIf this is red, this will be ignored by the global movement speed modifier.";
        string tooltipTeamString = "Default teams are:\n \"-1\" for no team\n \"2\" for police";
        string tooltipShaderString = "Color effects like red for Elites";
        string tooltipBossString = "Enable this to clear a stage after defeating this character as a boss";
        string tooltipDespawnString = "Enable this to prevent softlocks when spawning this character";
        string tooltipMoveString = "Damage values are based on a health value of 100.\nValues for Hitstop and Hitstun are in frames (60 per second)";
        string tooltipReset = "Reset";
        ToolTip nameTooltip = new();
        ToolTip healthTooltip = new();
        ToolTip speedXTooltip = new();
        ToolTip speedYTooltip = new();
        ToolTip teamTooltip = new();
        ToolTip shaderTooltip = new();
        ToolTip bossTooltip = new();
        ToolTip despawnTooltip = new();
        ToolTip moveTooltip = new();
        ToolTip resetTooltip = new();


        public CustomizerCharacters(MainWindow mainwindow)
        {
            InitializeComponent();
            _mainwindow = mainwindow;
            classlib = mainwindow.classlib;
            characterList.DrawMode = DrawMode.OwnerDrawFixed;
            characterList.DrawItem += new DrawItemEventHandler(characterList_DrawItem);
            characterList.SelectedIndexChanged += new EventHandler(characterList_SelectedIndexChanged);
            cmbMoveList.DrawMode = DrawMode.OwnerDrawFixed;
            cmbMoveList.DrawItem += new DrawItemEventHandler(cmbMoveList_DrawItem);
            cmbMoveList.SelectedIndexChanged += new EventHandler(cmbMoveList_SelectedIndexChanged);
            labelHealth.Text = "\u271A";
            labelHealth.Font = new Font(Font.Name, Font.Size + 4.0F, FontStyle.Bold);
            labelSpeedX.Text = "\u2B0C";
            labelSpeedX.Font = new Font(Font.Name, Font.Size + 10.0F);
            labelSpeedY.Text = "\u2B0D";
            labelSpeedY.Font = new Font(Font.Name, Font.Size + 10.0F);
            labelScale.Text = "\u2931";
            labelScale.BackColor = Color.Transparent;
            labelScale.Font = new Font(Font.Name, Font.Size + 10.0F);
            btnHealthReset.Text = "\u27F3";
            btnSpeedXReset.Text = "\u27F3";
            btnSpeedYReset.Text = "\u27F3";
            resetTooltip.SetToolTip(btnHealthReset, tooltipReset);
            resetTooltip.SetToolTip(btnSpeedXReset, tooltipReset);
            resetTooltip.SetToolTip(btnSpeedYReset, tooltipReset);
        }

        private void characterList_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font fontToUse = e.Font;
            Brush brush = Brushes.Black;
            if (Library.characterDictionary[e.Index].Path == "n/a")
            {
                fontToUse = new Font("Segoe UI", 10, FontStyle.Bold | FontStyle.Regular);
            }
            else
            {
                e.DrawBackground();
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected) brush = Brushes.White;
                e.DrawFocusRectangle();
            }
            e.Graphics.DrawString(characterList.Items[e.Index].ToString(), fontToUse, brush, e.Bounds);
        }

        private void characterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            justArrived = true;
            hasChanges = false;
            ComboBox cmb = (ComboBox)sender;
            if (cmb.SelectedIndex != -1)
            {
                if (Library.characterDictionary[cmb.SelectedIndex].Path == "n/a")
                {
                    cmb.SelectedIndex = -1;
                }
                else
                {
                    // enable controls
                    int selectedCharacterKey = cmb.SelectedIndex;
                    int swappedCharacterKey = selectedCharacterKey;
                    if (classlib.changeList.ContainsKey(swappedCharacterKey)) swappedCharacterKey = classlib.changeList[swappedCharacterKey];
                    if (characterList.Text != "") picThumbOrig.Image = _mainwindow.thumbnailslib.getThumbnail("character", swappedCharacterKey);
                    Control[] controls = { txtName, txtHealth, txtSpeedX, txtSpeedY, chkBoss, chkDespawn, cmbShader, txtTeam, cmbMoveList, btnSetItem, txtScale };
                    foreach (Control ctrlname in controls) ctrlname.Enabled = true;
                    dataGridView1.Hide();

                    CharacterClass swappedCharacterClass = new(classlib.bigfileClass.characterCollection[swappedCharacterKey]);
                    CharacterClass selectedCharacterClass = new(classlib.bigfileClass.characterCollection[selectedCharacterKey]);

                    if (classlib.characterCustomizationInMemory.ContainsKey(selectedCharacterKey))
                    {
                        swappedCharacterClass = new(classlib.characterCustomizationInMemory[selectedCharacterKey]);
                    }

                    // if found in memory
                    if (classlib.characterCustomizationInMemory.ContainsKey(selectedCharacterKey))
                    {
                        txtName.Text = classlib.characterCustomizationInMemory[selectedCharacterKey].NewName;
                    }
                    else
                    if (selectedCharacterKey != swappedCharacterKey)
                    {
                        txtName.Text = swappedCharacterClass.Name;
                    }
                    else
                    if (classlib.customCharacterNames.ContainsKey(selectedCharacterClass.SwapNameIndex))
                    {
                        txtName.Text = classlib.customCharacterNames[selectedCharacterClass.SwapNameIndex];
                    } else
                    {
                        txtName.Text = selectedCharacterClass.Name;
                    }

                    txtHealth.Text = swappedCharacterClass.Health.ToString();
                    txtSpeedX.Text = swappedCharacterClass.Speed.X.ToString();
                    txtSpeedY.Text = swappedCharacterClass.Speed.Y.ToString();
                    chkBoss.Checked = swappedCharacterClass.IsBoss;
                    chkDespawn.Checked = swappedCharacterClass.DespawnsAfterDeath;
                    txtTeam.Text = swappedCharacterClass.Team.ToString();

                    txtScale.Text = swappedCharacterClass.Scale.ToString();

                    if (classlib.bigfileClass.shaderStrings.Contains(swappedCharacterClass.Shader))
                    {
                        cmbShader.SelectedIndex = classlib.bigfileClass.shaderStrings.IndexOf(swappedCharacterClass.Shader);
                    }
                    else
                    {
                        cmbShader.SelectedIndex = -1;
                    }

                    // set control color based on value if custom
                    CharacterClass referenceClass = classlib.bigfileClass.characterCollection[swappedCharacterKey];
                    txtName.ForeColor = CompareValues(txtName.Text.Trim(), swappedCharacterClass.Name, null);
                    labelName.ForeColor = txtName.ForeColor;
                    txtHealth.ForeColor = CompareValues(txtHealth.Text.Trim(), referenceClass.Health.ToString(), btnHealthReset);
                    labelHealth.ForeColor = txtHealth.ForeColor;
                    txtSpeedX.ForeColor = CompareValues(txtSpeedX.Text.Trim(), referenceClass.Speed.X.ToString(), btnSpeedXReset);
                    labelSpeedX.ForeColor = txtSpeedX.ForeColor;
                    txtSpeedY.ForeColor = CompareValues(txtSpeedY.Text.Trim(), referenceClass.Speed.Y.ToString(), btnSpeedYReset);
                    labelSpeedY.ForeColor = txtSpeedY.ForeColor;
                    chkBoss.ForeColor = CompareValues(chkBoss.Checked, referenceClass.IsBoss);
                    chkDespawn.ForeColor = CompareValues(chkDespawn.Checked, referenceClass.DespawnsAfterDeath);
                    labelShader.ForeColor = CompareValues(classlib.bigfileClass.shaderStrings[cmbShader.SelectedIndex], referenceClass.Shader);
                    cmbShader.ForeColor = labelShader.ForeColor;
                    labelTeam.ForeColor = CompareValues(txtTeam.Text.Trim(), referenceClass.Team.ToString());
                    txtTeam.ForeColor = labelTeam.ForeColor;
                    txtScale.ForeColor = CompareValues(txtScale.Text.Trim(), referenceClass.Scale.ToString());
                    labelScale.ForeColor = txtScale.ForeColor;


                    cmbMoveList.Items.Clear();
                    cmbMoveList.Text = "";
                    dataGridView1.Rows.Clear();
                    foreach (var move in swappedCharacterClass.Moveset)
                    {
                        cmbMoveList.Items.Add(move.Name);
                    }
                }
            }
            justArrived = false;
        }

        private void cmbMoveList_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font fontToUse = e.Font;
            Brush brush = Brushes.Black;
            e.DrawBackground();
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected) brush = Brushes.White;
            e.DrawFocusRectangle();
            e.Graphics.DrawString(cmbMoveList.Items[e.Index].ToString(), fontToUse, brush, e.Bounds);
        }

        private void cmbMoveList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // reset this before anything else
            btnResetMove.Enabled = false;
            if (cmbMoveList.SelectedIndex > -1)
            {
                int thisMove = cmbMoveList.SelectedIndex;
                dataGridView1.Show();
                dataGridView1.Rows.Clear();
                int selectedCharacterKey = characterList.SelectedIndex;
                int swappedCharacterKey = selectedCharacterKey;
                if (classlib.changeList.ContainsKey(swappedCharacterKey)) swappedCharacterKey = classlib.changeList[swappedCharacterKey];
                CharacterClass characterClass = new(classlib.bigfileClass.characterCollection[swappedCharacterKey]);
                CharacterClass originalCharacterClass = new(classlib.bigfileClass.characterCollection[swappedCharacterKey]);

                if (classlib.characterCustomizationInMemory.ContainsKey(selectedCharacterKey))
                {
                    characterClass = new(classlib.characterCustomizationInMemory[selectedCharacterKey]);
                }


                int hitctr = 0;
                var move = characterClass.Moveset[thisMove];

                if (move.Hits.Count > 0)
                {
                    foreach (var hit in move.Hits)
                    {
                        dataGridView1.Rows.Add(hitctr + 1, hit.Damage, hit.Hitstop, hit.Hitstun);
                        
                        if (hit.Damage != originalCharacterClass.Moveset[thisMove].Hits[hitctr].Damage)
                        {
                            dataGridView1.Rows[hitctr].Cells["damage"].Style.ForeColor = Color.Red;
                            dataGridView1.Rows[hitctr].Cells["damage"].ToolTipText = tooltipMoveString;
                            btnResetMove.Enabled = true;
                        }
                        if (hit.Hitstop != originalCharacterClass.Moveset[thisMove].Hits[hitctr].Hitstop)
                        {
                            dataGridView1.Rows[hitctr].Cells["hitstop"].Style.ForeColor = Color.Red;
                            dataGridView1.Rows[hitctr].Cells["hitstop"].ToolTipText = tooltipMoveString;
                            btnResetMove.Enabled = true;
                        }
                        if (hit.Hitstun != originalCharacterClass.Moveset[thisMove].Hits[hitctr].Hitstun)
                        {
                            dataGridView1.Rows[hitctr].Cells["hitstun"].Style.ForeColor = Color.Red;
                            dataGridView1.Rows[hitctr].Cells["hitstun"].ToolTipText = tooltipMoveString;
                            btnResetMove.Enabled = true;
                        }
                        hitctr++;
                    }
                }
            }

        }

        private void btnSetItem_Click(object sender, EventArgs e)
        {
            if (characterList.SelectedIndex > -1)
            {
                int assetKey = characterList.SelectedIndex;
                int targetKey = assetKey;
                if (classlib.changeList.ContainsKey(targetKey)) targetKey = classlib.changeList[assetKey];

                CharacterClass originalCharacter = classlib.bigfileClass.GetCustomCharacterDetails(assetKey);
                CharacterClass targetCharacter = classlib.bigfileClass.GetCustomCharacterDetails(targetKey);

                List<Moveset> moveset;
                Speed speed = new();
                if (classlib.characterCustomizationInMemory.ContainsKey(assetKey))
                {
                    moveset = classlib.characterCustomizationInMemory[assetKey].Moveset;
                }
                else
                {
                    moveset = targetCharacter.Moveset;
                }
                speed.X = int.Parse(txtSpeedX.Text.Trim());
                speed.Y = int.Parse(txtSpeedY.Text.Trim());

                CharacterClass characterDetails = new()
                {
                    NewCharacterId = targetKey,
                    NameIndex = Library.characterDictionary[assetKey].CustomNameIndex,
                    Name = originalCharacter.Name,
                    SwapNameIndex = originalCharacter.NameIndex,
                    NewName = txtName.Text.Trim(),
                    Health = int.Parse(txtHealth.Text.Trim()),
                    Moveset = moveset,
                    Speed = speed,
                    IsBoss = chkBoss.Checked,
                    DespawnsAfterDeath = chkDespawn.Checked,
                    Shader = classlib.bigfileClass.shaderStrings[cmbShader.SelectedIndex],
                    Team = int.Parse(txtTeam.Text.Trim()),
                    Scale = int.Parse(txtScale.Text.Trim()),
                };

                if (_mainwindow.Width < _mainwindow.fullWindowWidth) _mainwindow.Width = _mainwindow.fullWindowWidth;
                _mainwindow.ToggleShowHideListLabels(true);
                btnClearSwapList.Enabled = true;
                _mainwindow.charactercustomizerpanel.dataGridView1.Visible = true;
                _mainwindow.container.btnStartReplace.Enabled = true;
                _mainwindow.container.btnClearAllSwaps.Enabled = true;

                classlib.AddCustom(_mainwindow, "character", assetKey, characterDetails);

                if ((_mainwindow.info.labelLoadedSwapFile.Visible) && (!_mainwindow.info.labelLoadedSwapFile.Text.Contains(" (modified)"))) _mainwindow.info.labelLoadedSwapFile.Text += " (modified)";

            }
            else
            {
                MessageBox.Show("Please make sure, uh... Yeah.", "Character name is empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            if (_mainwindow.Width < _mainwindow.fullWindowWidth)
            {
                _mainwindow.ToggleSwapList(true);
            }
            else
            {
                _mainwindow.ToggleSwapList(false);
            }

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (characterList.SelectedIndex > -1)
            {
                int selectedCharacterKey = characterList.SelectedIndex;
                int swappedCharacterKey = selectedCharacterKey;

                if (classlib.changeList.ContainsKey(swappedCharacterKey)) swappedCharacterKey = classlib.changeList[swappedCharacterKey];
                CharacterClass characterClass = classlib.bigfileClass.GetCustomCharacterDetails(swappedCharacterKey);
                CharacterClass originalCharacterClass = classlib.bigfileClass.GetCustomCharacterDetails(swappedCharacterKey);
                if (!classlib.characterCustomizationInMemory.ContainsKey(selectedCharacterKey))
                {
                    classlib.characterCustomizationInMemory[selectedCharacterKey] = characterClass;
                }

                int thisMove = cmbMoveList.SelectedIndex;
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    classlib.characterCustomizationInMemory[selectedCharacterKey].Moveset[thisMove].Hits[dr.Index].Damage = Convert.ToInt32(dr.Cells["damage"].Value);
                    classlib.characterCustomizationInMemory[selectedCharacterKey].Moveset[thisMove].Hits[dr.Index].Hitstop = Convert.ToInt32(dr.Cells["hitstop"].Value);
                    classlib.characterCustomizationInMemory[selectedCharacterKey].Moveset[thisMove].Hits[dr.Index].Hitstun = Convert.ToInt32(dr.Cells["hitstun"].Value);
                    if (originalCharacterClass.Moveset[thisMove].Hits[dr.Index].Damage != classlib.characterCustomizationInMemory[selectedCharacterKey].Moveset[thisMove].Hits[dr.Index].Damage)
                    {
                        dr.Cells["damage"].Style.ForeColor = Color.Red;
                    }
                    if (originalCharacterClass.Moveset[thisMove].Hits[dr.Index].Hitstop != classlib.characterCustomizationInMemory[selectedCharacterKey].Moveset[thisMove].Hits[dr.Index].Hitstop)
                    {
                        dr.Cells["hitstop"].Style.ForeColor = Color.Red;
                    }
                    if (originalCharacterClass.Moveset[thisMove].Hits[dr.Index].Hitstun != classlib.characterCustomizationInMemory[selectedCharacterKey].Moveset[thisMove].Hits[dr.Index].Hitstun)
                    {
                        dr.Cells["hitstun"].Style.ForeColor = Color.Red;
                    }
                    btnResetCharacter.Enabled = true;
                    btnResetMove.Enabled = true;
                }
            }
        }

        private void btnClearSwapList_Click(object sender, EventArgs e)
        {
            _mainwindow.ClearSwaps("character", "custom");
        }

        private void ProcessControl(Control control, int selectedCharacterKey, int selectedMoveIndex = -1)
        {
            if ((selectedCharacterKey > -1) && !justArrived)
            {
                Control targetControl = control;
                dynamic memoryValue = "";
                dynamic originalValue = "";
                int swappedCharacterKey = selectedCharacterKey;

                if (classlib.changeList.ContainsKey(swappedCharacterKey)) swappedCharacterKey = classlib.changeList[swappedCharacterKey];
                CharacterClass swappedCharacterClass = classlib.bigfileClass.GetCustomCharacterDetails(swappedCharacterKey);
                if (!classlib.characterCustomizationInMemory.ContainsKey(selectedCharacterKey))
                {
                    classlib.characterCustomizationInMemory[selectedCharacterKey] = swappedCharacterClass;
                }

                switch (control.Name)
                {
                    case "txtName":
                        CharacterClass selectedCharacterClass = classlib.bigfileClass.GetCustomCharacterDetails(selectedCharacterKey);
                        string originalName = selectedCharacterClass.Name;
                        if (selectedCharacterClass.Name != swappedCharacterClass.Name)
                        {
                            originalName = classlib.customCharacterNames[swappedCharacterClass.NameIndex];
                        }
                        memoryValue = txtName.Text.Trim();
                        originalValue = originalName;
                        classlib.characterCustomizationInMemory[selectedCharacterKey].NewName = control.Text.Trim();
                        targetControl = labelName;
                        break;
                    case "txtHealth":
                        memoryValue = ValidateData(control.Text.Trim(), "health", swappedCharacterClass.Health);
                        originalValue = swappedCharacterClass.Health;
                        classlib.characterCustomizationInMemory[selectedCharacterKey].Health = memoryValue;
                        control.Text = memoryValue.ToString();
                        targetControl = labelHealth;
                        if (memoryValue != originalValue)
                        {
                            btnHealthReset.Enabled = true;
                        }
                        else
                        {
                            btnHealthReset.Enabled = false;
                        }
                        break;
                    case "txtSpeedX":
                        memoryValue = ValidateData(control.Text.Trim(), "speed", swappedCharacterClass.Speed.X);
                        originalValue = swappedCharacterClass.Speed.X;
                        classlib.characterCustomizationInMemory[selectedCharacterKey].Speed.X = memoryValue;
                        control.Text = memoryValue.ToString();
                        targetControl = labelSpeedX;
                        if (memoryValue != originalValue)
                        {
                            btnSpeedXReset.Enabled = true;
                        }
                        else
                        {
                            btnSpeedXReset.Enabled = false;
                        }
                        break;
                    case "txtSpeedY":
                        memoryValue = ValidateData(control.Text.Trim(), "speed", swappedCharacterClass.Speed.Y);
                        originalValue = swappedCharacterClass.Speed.Y;
                        classlib.characterCustomizationInMemory[selectedCharacterKey].Speed.Y = memoryValue;
                        control.Text = memoryValue.ToString();
                        targetControl = labelSpeedY;
                        if (memoryValue != originalValue)
                        {
                            btnSpeedYReset.Enabled = true;
                        }
                        else
                        {
                            btnSpeedYReset.Enabled = false;
                        }
                        break;
                    case "chkBoss":
                        memoryValue = chkBoss.Checked;
                        originalValue = swappedCharacterClass.IsBoss;
                        classlib.characterCustomizationInMemory[selectedCharacterKey].IsBoss = memoryValue;
                        break;
                    case "chkDespawn":
                        memoryValue = chkDespawn.Checked;
                        originalValue = swappedCharacterClass.DespawnsAfterDeath;
                        classlib.characterCustomizationInMemory[selectedCharacterKey].DespawnsAfterDeath = memoryValue;
                        break;
                    case "cmbShader":
                        memoryValue = classlib.bigfileClass.shaderStrings[cmbShader.SelectedIndex];
                        originalValue = swappedCharacterClass.Shader;
                        targetControl = labelShader;
                        classlib.characterCustomizationInMemory[selectedCharacterKey].Shader = memoryValue;
                        break;
                    case "txtTeam":
                        memoryValue = ValidateData(control.Text.Trim(), "team", swappedCharacterClass.Team);
                        originalValue = swappedCharacterClass.Team;
                        classlib.characterCustomizationInMemory[selectedCharacterKey].Team = memoryValue;
                        control.Text = memoryValue.ToString();
                        targetControl = labelTeam;
                        break;
                    case "txtScale":
                        memoryValue = ValidateData(control.Text.Trim(), "scale", swappedCharacterClass.Scale);
                        originalValue = swappedCharacterClass.Scale;
                        classlib.characterCustomizationInMemory[selectedCharacterKey].Scale = memoryValue;
                        control.Text = memoryValue.ToString();
                        targetControl = labelScale;
                        break;
                }

                control.ForeColor = CompareValues(memoryValue, originalValue);
                targetControl.ForeColor = control.ForeColor;
                btnResetCharacter.Enabled = true;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            ProcessControl(txtName, characterList.SelectedIndex);
        }
        private void txtHealth_TextChanged(object sender, EventArgs e)
        {
            ProcessControl(txtHealth, characterList.SelectedIndex);
        }
        private void txtSpeedX_TextChanged(object sender, EventArgs e)
        {
            ProcessControl(txtSpeedX, characterList.SelectedIndex);
        }
        private void txtSpeedY_TextChanged(object sender, EventArgs e)
        {
            ProcessControl(txtSpeedY, characterList.SelectedIndex);
        }
        private void chkBoss_CheckedChanged(object sender, EventArgs e)
        {
            ProcessControl(chkBoss, characterList.SelectedIndex);
        }
        private void chkDespawn_CheckedChanged(object sender, EventArgs e)
        {
            ProcessControl(chkDespawn, characterList.SelectedIndex);
        }
        private void cmbShader_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProcessControl(cmbShader, characterList.SelectedIndex);
        }
        private void txtTeam_TextChanged(object sender, EventArgs e)
        {
            ProcessControl(txtTeam, characterList.SelectedIndex);
        }
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
                        minValue = 1;
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
                            //errorMessage = "Are you trying to create more teams than games on Steam? No...";
                            errorMessage = "";
                            break;
                        case "scale":
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
                }
            }

            if (errorMessage != "") MessageBox.Show(errorMessage, "Value error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            returnVal = resetValue;
            return returnVal;
        }

        private void ResetCustomizer(string resetTargetType, int selectedIndex, int hitRowCtr = 0)
        {
            int selectedCharacterIndex = characterList.SelectedIndex;
            int targetCharacter = selectedCharacterIndex;
            if (classlib.changeList.ContainsKey(selectedCharacterIndex))
            {
                targetCharacter = classlib.changeList[selectedCharacterIndex];
            }
            CharacterClass origData = classlib.bigfileClass.characterCollection[targetCharacter];
            switch (resetTargetType)
            {
                case "character":
                    txtName.Text = classlib.bigfileClass.customCharacterNames[origData.NameIndex];
                    txtHealth.Text = origData.Health.ToString();
                    txtSpeedX.Text = origData.Speed.X.ToString();
                    txtSpeedY.Text = origData.Speed.Y.ToString();
                    chkBoss.Checked = origData.IsBoss;
                    chkDespawn.Checked = origData.DespawnsAfterDeath;
                    txtScale.Text = origData.Scale.ToString();
                    if (classlib.bigfileClass.shaderStrings.Contains(origData.Shader))
                    {
                        cmbShader.SelectedIndex = classlib.bigfileClass.shaderStrings.IndexOf(origData.Shader);
                    }
                    else
                    {
                        cmbShader.SelectedIndex = -1;
                    }

                    if (classlib.characterCustomizationInMemory.ContainsKey(selectedIndex))
                    {
                        classlib.characterCustomizationInMemory.Remove(selectedIndex);
                    }

                    if (cmbMoveList.SelectedIndex != -1)
                    {
                        ResetCustomizer("move", cmbMoveList.SelectedIndex);
                    }

                    txtTeam.Text = origData.Team.ToString();
                    btnResetCharacter.Enabled = false;
                    btnResetMove.Enabled = false;
                    break;
                case "move":
                    Moveset move = origData.Moveset[selectedIndex];
                    int hitctr = 0;
                    dataGridView1.Rows.Clear();
                    if (move.Hits.Count > 0)
                    {
                        foreach (var hit in move.Hits)
                        {
                            ResetCustomizer("hit", selectedIndex, hitctr);
                            hitctr++;
                        }
                    }
                    btnResetMove.Enabled = false;

                    break;
                case "hit":
                    HitValue hitValue = origData.Moveset[selectedIndex].Hits[hitRowCtr];
                    dataGridView1.Rows.Add(hitRowCtr + 1, hitValue.Damage, hitValue.Hitstop, hitValue.Hitstun);
                    break;
            }
        }

        private void btnResetCharacter_Click(object sender, EventArgs e)
        {
            if (characterList.SelectedIndex != -1)
            {
                ResetCustomizer("character", characterList.SelectedIndex);
            }
        }

        private void btnResetMove_Click(object sender, EventArgs e)
        {
            if ((characterList.SelectedIndex != -1) && (cmbMoveList.SelectedIndex != -1))
            {
                ResetCustomizer("move", cmbMoveList.SelectedIndex);
            }
        }

        private Color CompareValues(dynamic memoryValue, dynamic originalValue, Button resetBtn = null)
        {
            Color color = memoryValue != originalValue ? Color.Red : Color.Black;
            if (resetBtn == null)
            {
                resetBtn = btnResetCharacter;
            }
            if (memoryValue != originalValue)
            {
                resetBtn.Enabled = true;
                hasChanges = true;
            }
            else
            {
                resetBtn.Enabled = false;
            }
            if (hasChanges)
            {
                btnResetCharacter.Enabled = true;
            }
            return color;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var originalDetails = classlib.bigfileClass.characterCollection[characterList.SelectedIndex];
                var move = originalDetails.Moveset[cmbMoveList.SelectedIndex];
                var hit = move.Hits[e.RowIndex];
                dataGridView1.Rows[e.RowIndex].Cells["damage"].Value = hit.Damage;
                dataGridView1.Rows[e.RowIndex].Cells["hitstop"].Value = hit.Hitstop;
                dataGridView1.Rows[e.RowIndex].Cells["hitstun"].Value = hit.Hitstun;
                dataGridView1.Rows[e.RowIndex].Cells["damage"].Style.ForeColor = Color.Black;
                dataGridView1.Rows[e.RowIndex].Cells["hitstop"].Style.ForeColor = Color.Black;
                dataGridView1.Rows[e.RowIndex].Cells["hitstun"].Style.ForeColor = Color.Black;
            }
        }

        private void txtTeam_Leave(object sender, EventArgs e)
        {
            if (txtTeam.Text.Trim() == "")
            {

            }
        }

        private void txtName_MouseHover(object sender, EventArgs e)
        {
            nameTooltip.Show(tooltipNameString, this.txtName, 10000);
        }

        private void txtHealth_MouseHover(object sender, EventArgs e)
        {
            healthTooltip.Show(tooltipHealthString, this.txtHealth, 10000);
        }

        private void txtSpeedX_MouseHover(object sender, EventArgs e)
        {
            speedXTooltip.Show(tooltipSpeedXString, this.txtSpeedX, 10000);
        }

        private void txtSpeedY_MouseHover(object sender, EventArgs e)
        {
            speedYTooltip.Show(tooltipSpeedYString, this.txtSpeedY, 10000);
        }

        private void txtTeam_MouseHover(object sender, EventArgs e)
        {
            teamTooltip.Show(tooltipTeamString, this.txtTeam, 10000);
        }

        private void cmbShader_MouseHover(object sender, EventArgs e)
        {
            shaderTooltip.Show(tooltipShaderString, this.cmbShader, 10000);
        }

        private void chkBoss_MouseHover(object sender, EventArgs e)
        {
            bossTooltip.Show(tooltipBossString, this.chkBoss, 10000);
        }

        private void chkDespawn_MouseHover(object sender, EventArgs e)
        {
            despawnTooltip.Show(tooltipDespawnString, this.chkDespawn, 10000);
        }

        private void cmbMoveList_MouseHover(object sender, EventArgs e)
        {
            moveTooltip.Show(tooltipMoveString, this.cmbMoveList, 10000);
        }

        private void btnSpeedXReset_Click(object sender, EventArgs e)
        {
            if (characterList.SelectedIndex != -1)
            {
                int selectedCharacterKey = characterList.SelectedIndex;
                int swappedCharacterKey = selectedCharacterKey;
                if (classlib.changeList.ContainsKey(swappedCharacterKey)) swappedCharacterKey = classlib.changeList[swappedCharacterKey];
                CharacterClass swappedCharacterClass = new(classlib.bigfileClass.characterCollection[swappedCharacterKey]);
                txtSpeedX.Text = swappedCharacterClass.Speed.X.ToString();
            }
        }

        private void btnSpeedYReset_Click(object sender, EventArgs e)
        {
            if (characterList.SelectedIndex != -1)
            {
                int selectedCharacterKey = characterList.SelectedIndex;
                int swappedCharacterKey = selectedCharacterKey;
                if (classlib.changeList.ContainsKey(swappedCharacterKey)) swappedCharacterKey = classlib.changeList[swappedCharacterKey];
                CharacterClass swappedCharacterClass = new(classlib.bigfileClass.characterCollection[swappedCharacterKey]);
                txtSpeedY.Text = swappedCharacterClass.Speed.Y.ToString();
            }

        }

        private void btnHealthReset_Click(object sender, EventArgs e)
        {
            if (characterList.SelectedIndex != -1)
            {
                int selectedCharacterKey = characterList.SelectedIndex;
                int swappedCharacterKey = selectedCharacterKey;
                if (classlib.changeList.ContainsKey(swappedCharacterKey)) swappedCharacterKey = classlib.changeList[swappedCharacterKey];
                CharacterClass swappedCharacterClass = new(classlib.bigfileClass.characterCollection[swappedCharacterKey]);
                txtHealth.Text = swappedCharacterClass.Health.ToString();
            }
        }

        private void txtScale_TextChanged(object sender, EventArgs e)
        {
            ProcessControl(txtScale, characterList.SelectedIndex);
        }
    }
}
