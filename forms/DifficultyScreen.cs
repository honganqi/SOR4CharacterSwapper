using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SOR4GameExplorer;

namespace SOR4_Swapper
{
    public partial class DifficultyScreen : Form
    {
        private MainWindow _mainwindow;
        Library classlib;
        public bool difficultyJustArrived = false;
        Dictionary<Control, int> controlsWithPreviousValues = new();
        ToolTip lifeUpScoreTooltip = new();
        ToolTip lifeUpScoreArcadeTooltip = new();
        ToolTip moveSpeedTooltip = new();
        ToolTip gravityTooltip = new();

        public DifficultyScreen(MainWindow mainwindow)
        {
            difficultyJustArrived = true;
            InitializeComponent();
            _mainwindow = mainwindow;
            classlib = mainwindow.classlib;
            cmbPlayerHitstopValuesOptions.SelectedItem = "Default";
            cmbPlayerHitstunValuesOptions.SelectedItem = "Default";
            cmbEnemyHitstopValuesOptions.SelectedItem = "Default";
            cmbEnemyHitstunValuesOptions.SelectedItem = "Default";
            difficultyJustArrived = false;


            controlsWithPreviousValues = new()
            {
                [txtPlayerDefense] = 0,
                [txtPlayerGreen] = 0,
                [txtPlayerLives] = 0,
                [txtPlayerLivesArcade] = 0,
                [txtLifeUp] = 0,
                [txtLifeUpArcade] = 0,
                [txtPlayerStars] = 0,
                [txtPlayerSpeed] = 0,
                [txtPlayerHitstop] = 0,
                [txtPlayerHitstun] = 0,
                [txtEnemyHP] = 0,
                [txtEnemySpawn] = 0,
                [txtEnemyAFK] = 0,
                [txtEnemyAggro] = 0,
                [txtEnemySpeedMultiplier] = 0,
                [txtEnemySpeed] = 0,
                [txtEnemyHitstop] = 0,
                [txtEnemyHitstun] = 0,
                [txtPlayerHitstopMin] = 0,
                [txtPlayerHitstunMin] = 0,
                [txtEnemyHitstopMin] = 0,
                [txtEnemyHitstunMin] = 0,
                [txtGravity] = 0,
            };
        }

        private void cmbDifficultyCollection_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetDifficultyValues(cmbDifficultyCollection.SelectedIndex);
            btnReset.Text = "Reset to " + cmbDifficultyCollection.Text;
        }

        private void cmbPlayerHitstopValuesOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbPlayerHitstopValuesOptions.Text)
            {
                case "Default":
                    txtPlayerHitstop.Enabled = false;
                    txtPlayerHitstopMin.Enabled = false;
                    txtPlayerHitstopMin.Visible = false;
                    labelPlayerHitstopMinLabel.Visible = false;
                    cmbPlayerHitstopValuesOptions.Size = new Size(107, 21);
                    break;
                case "%":
                    txtPlayerHitstop.Text = "100";
                    txtPlayerHitstopMin.Text = "100";
                    txtPlayerHitstop.Enabled = true;
                    txtPlayerHitstopMin.Enabled = true;
                    txtPlayerHitstopMin.Visible = true;
                    labelPlayerHitstopMinLabel.Visible = true;
                    cmbPlayerHitstopValuesOptions.Size = new Size(60, 21);
                    break;
                case "Frames":
                    txtPlayerHitstop.Text = "6";
                    txtPlayerHitstopMin.Text = "6";
                    txtPlayerHitstop.Enabled = true;
                    txtPlayerHitstopMin.Enabled = true;
                    txtPlayerHitstopMin.Visible = true;
                    labelPlayerHitstopMinLabel.Visible = true;
                    cmbPlayerHitstopValuesOptions.Size = new Size(60, 21);
                    break;
                default:
                    txtPlayerHitstop.Enabled = true;
                    txtPlayerHitstopMin.Enabled = true;
                    txtPlayerHitstopMin.Visible = true;
                    labelPlayerHitstopMinLabel.Visible = true;
                    cmbPlayerHitstopValuesOptions.Size = new Size(60, 21);
                    break;
            }
        }

        private void cmbPlayerHitstunValuesOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbPlayerHitstunValuesOptions.Text)
            {
                case "Default":
                    txtPlayerHitstun.Enabled = false;
                    txtPlayerHitstunMin.Enabled = false;
                    txtPlayerHitstunMin.Visible = false;
                    labelPlayerHitstunMinLabel.Visible = false;
                    cmbPlayerHitstunValuesOptions.Size = new Size(107, 21);
                    break;
                case "%":
                    txtPlayerHitstun.Text = "100";
                    txtPlayerHitstunMin.Text = "100";
                    txtPlayerHitstun.Enabled = true;
                    txtPlayerHitstunMin.Enabled = true;
                    txtPlayerHitstunMin.Visible = true;
                    labelPlayerHitstunMinLabel.Visible = true;
                    cmbPlayerHitstunValuesOptions.Size = new Size(60, 21);
                    break;
                case "Frames":
                    txtPlayerHitstun.Text = "6";
                    txtPlayerHitstunMin.Text = "6";
                    txtPlayerHitstun.Enabled = true;
                    txtPlayerHitstunMin.Enabled = true;
                    txtPlayerHitstunMin.Visible = true;
                    labelPlayerHitstunMinLabel.Visible = true;
                    cmbPlayerHitstunValuesOptions.Size = new Size(60, 21);
                    break;
                default:
                    txtPlayerHitstun.Enabled = true;
                    txtPlayerHitstunMin.Enabled = true;
                    txtPlayerHitstunMin.Visible = true;
                    labelPlayerHitstunMinLabel.Visible = true;
                    cmbPlayerHitstunValuesOptions.Size = new Size(60, 21);
                    break;
            }
        }

        private void cmbEnemyHitstopValuesOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbEnemyHitstopValuesOptions.Text)
            {
                case "Default":
                    txtEnemyHitstop.Enabled = false;
                    txtEnemyHitstopMin.Enabled = false;
                    txtEnemyHitstopMin.Visible = false;
                    labelEnemyHitstopMinLabel.Visible = false;
                    cmbEnemyHitstopValuesOptions.Size = new Size(107, 21);
                    break;
                case "%":
                    txtEnemyHitstop.Text = "100";
                    txtEnemyHitstopMin.Text = "100";
                    txtEnemyHitstop.Enabled = true;
                    txtEnemyHitstopMin.Enabled = true;
                    txtEnemyHitstopMin.Visible = true;
                    labelEnemyHitstopMinLabel.Visible = true;
                    cmbEnemyHitstopValuesOptions.Size = new Size(60, 21);
                    break;
                case "Frames":
                    txtEnemyHitstop.Text = "6";
                    txtEnemyHitstopMin.Text = "6";
                    txtEnemyHitstop.Enabled = true;
                    txtEnemyHitstopMin.Enabled = true;
                    txtEnemyHitstopMin.Visible = true;
                    labelEnemyHitstopMinLabel.Visible = true;
                    cmbEnemyHitstopValuesOptions.Size = new Size(60, 21);
                    break;
                default:
                    txtEnemyHitstop.Enabled = true;
                    txtEnemyHitstopMin.Enabled = true;
                    txtEnemyHitstopMin.Visible = true;
                    labelEnemyHitstopMinLabel.Visible = true;
                    cmbEnemyHitstopValuesOptions.Size = new Size(60, 21);
                    break;
            }

        }

        private void cmbEnemyHitstunValuesOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbEnemyHitstunValuesOptions.Text)
            {
                case "Default":
                    txtEnemyHitstun.Enabled = false;
                    txtEnemyHitstunMin.Enabled = false;
                    txtEnemyHitstunMin.Visible = false;
                    labelEnemyHitstunMinLabel.Visible = false;
                    cmbEnemyHitstunValuesOptions.Size = new Size(107, 21);
                    break;
                case "%":
                    txtEnemyHitstun.Text = "100";
                    txtEnemyHitstunMin.Text = "100";
                    txtEnemyHitstun.Enabled = true;
                    txtEnemyHitstunMin.Enabled = true;
                    txtEnemyHitstunMin.Visible = true;
                    labelEnemyHitstunMinLabel.Visible = true;
                    cmbEnemyHitstunValuesOptions.Size = new Size(60, 21);
                    break;
                case "Frames":
                    txtEnemyHitstun.Text = "6";
                    txtEnemyHitstunMin.Text = "6";
                    txtEnemyHitstun.Enabled = true;
                    txtEnemyHitstunMin.Enabled = true;
                    txtEnemyHitstunMin.Visible = true;
                    labelEnemyHitstunMinLabel.Visible = true;
                    cmbEnemyHitstunValuesOptions.Size = new Size(60, 21);
                    break;
                default:
                    txtEnemyHitstun.Enabled = true;
                    txtEnemyHitstunMin.Enabled = true;
                    txtEnemyHitstunMin.Visible = true;
                    labelEnemyHitstunMinLabel.Visible = true;
                    cmbEnemyHitstunValuesOptions.Size = new Size(60, 21);
                    break;
            }
        }

        public void LoadSettings(DifficultyClass difficulty, GameplayConfigDataClass gcd, Dictionary<string, CharacterClass> globalCharacterSettings)
        {  
            txtDifficultyName.Text = difficulty.Name;
            txtPlayerDefense.Text = difficulty.Defense.ToString();
            txtPlayerLives.Text = difficulty.Lives.ToString();
            txtPlayerLivesArcade.Text = difficulty.LivesArcade.ToString();
            txtPlayerStars.Text = difficulty.Stars.ToString();
            txtPlayerGreen.Text = difficulty.GreenHealthMultiplier.ToString();
            txtLifeUp.Text = gcd.ScoreLifeUp.ToString();
            txtLifeUpArcade.Text = gcd.ScoreLifeUpArcade.ToString();
            txtGravity.Text = gcd.Gravity.ToString();

            txtEnemyHP.Text = difficulty.EnemyHealthMultiplier.ToString();
            txtEnemySpawn.Text = difficulty.EnemyMultiplier.ToString();
            txtEnemyAFK.Text = difficulty.EnemyAFKPercentage.ToString();
            txtEnemyAggro.Text = difficulty.AggroLimit.ToString();
            txtEnemySpeedMultiplier.Text = difficulty.EnemySpeedMultiplier.ToString();

            chkRemoveArmor.Checked = difficulty.RemoveArmor;

            if (globalCharacterSettings != null)
            {
                if (globalCharacterSettings.ContainsKey("playables"))
                {
                    txtPlayerSpeed.Text = globalCharacterSettings["playables"].MoveSpeed.ToString();
                    if (globalCharacterSettings["playables"].Hitstop > -1)
                    {
                        txtPlayerHitstop.Text = globalCharacterSettings["playables"].Hitstop.ToString();
                    }
                    txtPlayerHitstopMin.Text = globalCharacterSettings["playables"].HitstopIgnoreBelow.ToString();
                    if (globalCharacterSettings["playables"].GetType().GetProperty("HitstopValueType") != null)
                    {
                        switch (globalCharacterSettings["playables"].HitstopValueType)
                        {
                            case "percent":
                                cmbPlayerHitstopValuesOptions.Text = "%";
                                txtPlayerHitstop.Text = globalCharacterSettings["playables"].Hitstop.ToString();
                                txtPlayerHitstopMin.Text = globalCharacterSettings["playables"].HitstopIgnoreBelow.ToString();
                                break;
                            case "value":
                                cmbPlayerHitstopValuesOptions.Text = "Frames";
                                txtPlayerHitstop.Text = globalCharacterSettings["playables"].Hitstop.ToString();
                                txtPlayerHitstopMin.Text = globalCharacterSettings["playables"].HitstopIgnoreBelow.ToString();
                                break;
                            default:
                                cmbPlayerHitstopValuesOptions.Text = "Default";
                                break;
                        }
                    }
                    else
                    {
                        cmbPlayerHitstopValuesOptions.Text = "Default";
                    }

                    if (globalCharacterSettings["playables"].Hitstun > -1)
                    {
                        txtPlayerHitstun.Text = globalCharacterSettings["playables"].Hitstun.ToString();
                    }

                    txtPlayerHitstunMin.Text = globalCharacterSettings["playables"].HitstunIgnoreBelow.ToString();
                    if (globalCharacterSettings["playables"].GetType().GetProperty("HitstunValueType") != null)
                    {
                        switch (globalCharacterSettings["playables"].HitstunValueType)
                        {
                            case "percent":
                                cmbPlayerHitstunValuesOptions.Text = "%";
                                txtPlayerHitstun.Text = globalCharacterSettings["playables"].Hitstun.ToString();
                                txtPlayerHitstunMin.Text = globalCharacterSettings["playables"].HitstunIgnoreBelow.ToString();
                                break;
                            case "value":
                                cmbPlayerHitstunValuesOptions.Text = "Frames";
                                txtPlayerHitstun.Text = globalCharacterSettings["playables"].Hitstun.ToString();
                                txtPlayerHitstunMin.Text = globalCharacterSettings["playables"].HitstunIgnoreBelow.ToString();
                                break;
                            default:
                                cmbPlayerHitstunValuesOptions.Text = "Default";
                                break;
                        }
                    }
                    else
                    {
                        cmbPlayerHitstunValuesOptions.Text = "Default";
                    }
                }

                if (globalCharacterSettings.ContainsKey("enemies"))
                {
                    txtEnemySpeed.Text = globalCharacterSettings["enemies"].MoveSpeed.ToString();
                    if (globalCharacterSettings["enemies"].Hitstop > -1)
                    {
                        txtEnemyHitstop.Text = globalCharacterSettings["enemies"].Hitstop.ToString();
                    }

                    txtEnemyHitstopMin.Text = globalCharacterSettings["enemies"].HitstopIgnoreBelow.ToString();
                    if (globalCharacterSettings["enemies"].GetType().GetProperty("HitstopIgnoreBelow") != null)
                    {
                        switch (globalCharacterSettings["enemies"].HitstopValueType)
                        {
                            case "percent":
                                cmbEnemyHitstopValuesOptions.Text = "%";
                                txtEnemyHitstop.Text = globalCharacterSettings["enemies"].Hitstop.ToString();
                                txtEnemyHitstopMin.Text = globalCharacterSettings["enemies"].HitstopIgnoreBelow.ToString();
                                break;
                            case "value":
                                cmbEnemyHitstopValuesOptions.Text = "Frames";
                                txtEnemyHitstop.Text = globalCharacterSettings["enemies"].Hitstop.ToString();
                                txtEnemyHitstopMin.Text = globalCharacterSettings["enemies"].HitstopIgnoreBelow.ToString();
                                break;
                            default:
                                cmbEnemyHitstopValuesOptions.Text = "Default";
                                break;
                        }
                    }
                    if (globalCharacterSettings["enemies"].Hitstun > -1)
                    {
                        txtEnemyHitstun.Text = globalCharacterSettings["enemies"].Hitstun.ToString();
                    }

                    txtEnemyHitstunMin.Text = globalCharacterSettings["enemies"].HitstunIgnoreBelow.ToString();
                    if (globalCharacterSettings["enemies"].GetType().GetProperty("HitstunIgnoreBelow") != null)
                    {
                        switch (globalCharacterSettings["enemies"].HitstunValueType)
                        {
                            case "percent":
                                cmbEnemyHitstunValuesOptions.Text = "%";
                                txtEnemyHitstun.Text = globalCharacterSettings["enemies"].Hitstun.ToString();
                                txtEnemyHitstunMin.Text = globalCharacterSettings["enemies"].HitstunIgnoreBelow.ToString();
                                break;
                            case "value":
                                cmbEnemyHitstunValuesOptions.Text = "Frames";
                                txtEnemyHitstun.Text = globalCharacterSettings["enemies"].Hitstun.ToString();
                                txtEnemyHitstunMin.Text = globalCharacterSettings["enemies"].HitstunIgnoreBelow.ToString();
                                break;
                            default:
                                cmbEnemyHitstunValuesOptions.Text = "Default";
                                break;
                        }
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetDifficultyValues(cmbDifficultyCollection.SelectedIndex);
        }
        private void ResetDifficultyValues(int diffIndex)
        {
            Dictionary<string, CharacterClass> globalCharacterSettings = new()
            {
                ["playables"] = new()
                {
                    MoveSpeed = 100
                },
                ["enemies"] = new()
                {
                    MoveSpeed = 100
                }
            };
            LoadSettings(classlib.bigfileClass.difficultyCollection[diffIndex], classlib.bigfileClass.gameplayConfigData, globalCharacterSettings);
        }


        private void ProcessInput(object sender, EventArgs e)
        {
            Control thisControl = (Control)sender;
            if (uint.TryParse(thisControl.Text, out uint inputValue))
            {
                int resetValue = controlsWithPreviousValues[thisControl];
                int minValue = 0;
                int maxValue = 9999;
                if (!difficultyJustArrived)
                {
                    if (cmbDifficultyCollection.SelectedIndex != -1)
                    {
                        DifficultyClass originalDifficultyValues = classlib.bigfileClass.difficultyCollection[cmbDifficultyCollection.SelectedIndex];
                        GameplayConfigDataClass originalGCD = classlib.bigfileClass.gameplayConfigData;
                        // fetch original values and compare them with input
                        int originalValue = 100;
                        switch (thisControl.Name)
                        {
                            case "txtPlayerDefense":
                                originalValue = originalDifficultyValues.Defense;
                                break;
                            case "txtPlayerGreen":
                                originalValue = originalDifficultyValues.GreenHealthMultiplier;
                                break;
                            case "txtEnemyHP":
                                originalValue = originalDifficultyValues.EnemyHealthMultiplier;
                                break;
                            case "txtEnemySpawn":
                                originalValue = originalDifficultyValues.EnemyMultiplier;
                                break;
                            case "txtPlayerLives":
                                maxValue = int.MaxValue;
                                originalValue = originalDifficultyValues.Lives;
                                break;
                            case "txtPlayerLivesArcade":
                                maxValue = int.MaxValue;
                                originalValue = originalDifficultyValues.LivesArcade;
                                break;
                            case "txtPlayerStars":
                                maxValue = int.MaxValue;
                                originalValue = originalDifficultyValues.Stars;
                                break;
                            case "txtLifeUp":
                                maxValue = int.MaxValue;
                                originalValue = originalGCD.ScoreLifeUp;
                                break;
                            case "txtLifeUpArcade":
                                maxValue = int.MaxValue;
                                originalValue = originalGCD.ScoreLifeUpArcade;
                                break;
                            case "txtEnemyAFK":
                                originalValue = originalDifficultyValues.EnemyAFKPercentage;
                                break;
                            case "txtEnemyAggro":
                                originalValue = originalDifficultyValues.AggroLimit;
                                break;
                            case "txtEnemySpeedMultiplier":
                                originalValue = originalDifficultyValues.EnemySpeedMultiplier;
                                break;
                            case "txtGravity":
                                maxValue = 5200;
                                originalValue = originalGCD.Gravity;
                                break;
                        }
                        thisControl.ForeColor = CompareValues(thisControl.Text.Trim(), originalValue.ToString());
                    }
                    if (inputValue > maxValue)
                    {
                        resetValue = maxValue;
                        thisControl.Text = resetValue.ToString();
                    }
                    else
                    if (inputValue < minValue)
                    {
                        resetValue = minValue;
                        thisControl.Text = resetValue.ToString();
                    }
                    else
                    {
                        resetValue = (int)inputValue;
                    }
                }
                controlsWithPreviousValues[thisControl] = resetValue;

 
            }
            else
            {
                thisControl.Text = controlsWithPreviousValues[thisControl].ToString();
            }

        }

        public DifficultyClass GetDifficultyValues()
        {
            DifficultyClass difficulty = new();
            if (txtDifficultyName.Text.Trim() != "")
            {
                difficulty.Name = txtDifficultyName.Text.Trim();
            }
            else
            {
                difficulty.Name = "CUSTOM";
            }

            difficulty.BasisIndex = cmbDifficultyCollection.SelectedIndex;
            var textToInt = DifficultyCheckValue(txtPlayerDefense.Text.Trim(), "%");
            if (textToInt != null)
            {
                difficulty.Defense = (int)textToInt;
            }
            textToInt = DifficultyCheckValue(txtPlayerLives.Text.Trim(), "value");
            if (textToInt != null)
            {
                difficulty.Lives = (int)textToInt;
            }
            textToInt = DifficultyCheckValue(txtPlayerLivesArcade.Text.Trim(), "value");
            if (textToInt != null)
            {
                difficulty.LivesArcade = (int)textToInt;
            }
            textToInt = DifficultyCheckValue(txtPlayerStars.Text, "value");
            if (textToInt != null)
            {
                difficulty.Stars = (int)textToInt;
            }
            textToInt = DifficultyCheckValue(txtPlayerGreen.Text.Trim(), "%");
            if (textToInt != null)
            {
                difficulty.GreenHealthMultiplier = (int)textToInt;
            }
            textToInt = DifficultyCheckValue(txtEnemySpawn.Text.Trim(), "%");
            if (textToInt != null)
            {
                difficulty.EnemyMultiplier = (int)textToInt;
            }
            textToInt = DifficultyCheckValue(txtEnemyHP.Text.Trim(), "%");
            if (textToInt != null)
            {
                difficulty.EnemyHealthMultiplier = (int)textToInt;
            }
            textToInt = DifficultyCheckValue(txtEnemyAFK.Text.Trim(), "%");
            if (textToInt != null)
            {
                difficulty.EnemyAFKPercentage = (int)textToInt;
            }
            textToInt = DifficultyCheckValue(txtEnemyAggro.Text.Trim(), "value");
            if (textToInt != null)
            {
                difficulty.AggroLimit = (int)textToInt;
            }
            textToInt = DifficultyCheckValue(txtEnemySpeedMultiplier.Text.Trim(), "%");
            if (textToInt != null)
            {
                difficulty.EnemySpeedMultiplier = (int)textToInt;
            }
            difficulty.RemoveArmor = chkRemoveArmor.Checked;
            return difficulty;
        }

        public GameplayConfigDataClass GetGCDValues()
        {
            GameplayConfigDataClass gcd = new();

            int? textToInt = DifficultyCheckValue(txtLifeUp.Text.Trim(), "value");
            if (textToInt != null) gcd.ScoreLifeUp = (int)textToInt;

            textToInt = DifficultyCheckValue(txtLifeUpArcade.Text.Trim(), "value");
            if (textToInt != null) gcd.ScoreLifeUpArcade = (int)textToInt;

            textToInt = DifficultyCheckValue(txtGravity.Text.Trim(), "value");
            if (textToInt != null) gcd.Gravity = (int)textToInt;

            return gcd;
        }

        public Dictionary<string, CharacterClass> GetGlobalCharacterValues()
        {
            Dictionary<string, CharacterClass> globalCharacterCollection = new()
            {
                ["playables"] = new(),
                ["enemies"] = new()
            };

            int? textToInt = DifficultyCheckValue(txtPlayerHitstop.Text.Trim(), cmbPlayerHitstopValuesOptions.Text.Trim());
            if (textToInt != null)
            {
                globalCharacterCollection["playables"].Hitstop = (int)textToInt;
                globalCharacterCollection["playables"].HitstopValueType = ProcessValueType(cmbPlayerHitstopValuesOptions.Text.Trim());
                if (txtPlayerHitstopMin.Text.Trim() != "")
                {
                    globalCharacterCollection["playables"].HitstopIgnoreBelow = int.Parse(txtPlayerHitstopMin.Text.Trim());
                }
            }
            else
            {
                globalCharacterCollection["playables"].Hitstop = -1;
            }
            textToInt = DifficultyCheckValue(txtPlayerHitstun.Text, cmbPlayerHitstunValuesOptions.Text);
            if (textToInt != null)
            {
                globalCharacterCollection["playables"].Hitstun = (int)textToInt;
                globalCharacterCollection["playables"].HitstunValueType = ProcessValueType(cmbPlayerHitstunValuesOptions.Text);
                if (txtPlayerHitstunMin.Text.Trim() != "")
                {
                    globalCharacterCollection["playables"].HitstunIgnoreBelow = int.Parse(txtPlayerHitstunMin.Text);
                }
            }
            else
            {
                globalCharacterCollection["playables"].Hitstun = -1;
            }
            textToInt = DifficultyCheckValue(txtPlayerSpeed.Text, "%");
            if (textToInt != null)
            {
                globalCharacterCollection["playables"].MoveSpeed = (int)textToInt;
            }
            else
            {
                globalCharacterCollection["playables"].MoveSpeed = 100;
            }
            textToInt = DifficultyCheckValue(txtEnemyHitstop.Text, cmbEnemyHitstopValuesOptions.Text);
            if (textToInt != null)
            {
                globalCharacterCollection["enemies"].Hitstop = (int)textToInt;
                globalCharacterCollection["enemies"].HitstopValueType = ProcessValueType(cmbEnemyHitstopValuesOptions.Text);
                if (txtEnemyHitstopMin.Text.Trim() != "")
                {
                    globalCharacterCollection["enemies"].HitstopIgnoreBelow = int.Parse(txtEnemyHitstopMin.Text);
                }
            }
            else
            {
                globalCharacterCollection["enemies"].Hitstop = -1;
            }
            textToInt = DifficultyCheckValue(txtEnemyHitstun.Text, cmbEnemyHitstunValuesOptions.Text);
            if (textToInt != null)
            {
                if (!globalCharacterCollection.ContainsKey("enemies")) globalCharacterCollection["enemies"] = new CharacterClass();
                globalCharacterCollection["enemies"].Hitstun = (int)textToInt;
                globalCharacterCollection["enemies"].HitstunValueType = ProcessValueType(cmbEnemyHitstunValuesOptions.Text);
                if (txtEnemyHitstunMin.Text.Trim() != "")
                {
                    globalCharacterCollection["enemies"].HitstunIgnoreBelow = int.Parse(txtPlayerHitstunMin.Text);
                }
            }
            else
            {
                globalCharacterCollection["enemies"].Hitstun = -1;
            }
            textToInt = DifficultyCheckValue(txtEnemySpeed.Text, "%");
            if (textToInt != null)
            {
                globalCharacterCollection["enemies"].MoveSpeed = (int)textToInt;
            }
            else
            {
                globalCharacterCollection["enemies"].MoveSpeed = 100;
            }

            return globalCharacterCollection;
        }

        private int? DifficultyCheckValue(string textBoxValue, string valueOption)
        {
            return valueOption switch
            {
                "%" => int.Parse(textBoxValue.Trim()),
                "value" or "Frames" => int.Parse(textBoxValue.Trim()),
                _ => null,
            };
        }

        private string ProcessValueType(string selectedOption)
        {
            return selectedOption switch
            {
                "%" => "percent",
                "Frames" => "value",
                _ => "",
            };
        }

        private Color CompareValues(dynamic memoryValue, dynamic originalValue)
        {
            Color color = memoryValue != originalValue ? Color.Red : Color.Black;
            return color;
        }

        private void txtLifeUp_MouseHover(object sender, EventArgs e)
        {
            lifeUpScoreTooltip.Show("The score requirement to gain lives in Story Mode and Stage Select. This will take effect regardless of difficulty.", txtLifeUp, 10000);
        }

        private void txtLifeUpArcade_MouseHover(object sender, EventArgs e)
        {
            lifeUpScoreArcadeTooltip.Show("The score requirement to gain lives in Arcade Mode. This will take effect regardless of difficulty.", txtLifeUpArcade, 10000);
        }

        private void txtPlayerSpeed_MouseHover(object sender, EventArgs e)
        {
            moveSpeedTooltip.Show("This will take effect regardless of difficulty. Also, this will be ignored by customized characters whose speed values are in red (changed).", txtPlayerSpeed, 10000);
        }

        private void txtEnemySpeed_MouseHover(object sender, EventArgs e)
        {
            moveSpeedTooltip.Show("This will take effect regardless of difficulty. Also, this will be ignored by customized characters whose speed values are in red (changed).", txtEnemySpeed, 10000);
        }

        private void txtGravity_MouseHover(object sender, EventArgs e)
        {
            gravityTooltip.Show("The lower the number, the lower the gravity (characters flying). This will take effect regardless of difficulty.\n\nAnybody who complains that % is not a valid way to represent gravity will be banned from future updates to the Swapper...\n\n\n\n\n\nJust kidding!", txtGravity, 10000);
        }
    }
}
