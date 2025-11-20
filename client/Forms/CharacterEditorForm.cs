using client.Models;
using client.Models.Classes;
using client.Repositories;
using client.UserControls;
using client.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace client
{
    public partial class CharacterEditorForm : Form
    {
        private Character _characterToEdit;
        private CharacterRepository _characterRepo = new();

        public CharacterEditorForm(Character character)
        {
            InitializeComponent();
            _characterToEdit = character;
            nameInput.Text = _characterToEdit.Name;
            healthLabel.Text = _characterToEdit.CurrentHealth.ToString();
            DisplayCharacterInfo();
            //for (int i = 0; i < 10; i++)
            //    inventoryListBox.Items.Add("TEST");

            //btnLevelUp.Enabled = false;
            btnSave.Enabled = false;
        }

        private void SetLabel(Label label, string name, int value)
        {
            label.Text = $"{name}: {value}";
        }

        private void CharacterEditorForm_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void StatUp_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (btn == null) return;

            int cost = 1;
            string statName = "";
            int currentStatValue = 0;

            switch (btn.Name)
            {
                case "StrengthUp":
                    statName = "Strength";
                    currentStatValue = _characterToEdit.Stats.Strength;
                    break;
                case "DexterityUp":
                    statName = "Dexterity";
                    currentStatValue = _characterToEdit.Stats.Dexterity;
                    break;
                case "ConstitutionUp":
                    statName = "Constitution";
                    currentStatValue = _characterToEdit.Stats.Constitution;
                    break;
                case "InteligenceUp":
                    statName = "Intelligence";
                    currentStatValue = _characterToEdit.Stats.Intelligence;
                    break;
                case "WisdomUp":
                    statName = "Wisdom";
                    currentStatValue = _characterToEdit.Stats.Wisdom;
                    break;
                case "CharismaUp":
                    statName = "Charisma";
                    currentStatValue = _characterToEdit.Stats.Charisma;
                    break;
                default:
                    return;
            }
            if (currentStatValue >= 14)
            {
                cost = 2;
            }
            if (_characterToEdit.StatPoints < cost)
            {
                MessageBox.Show($"Для підвищення {statName} необхідно {cost} очок.", "Недостатньо очок", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch (statName)
            {
                case "Strength": _characterToEdit.Stats.Strength++; break;
                case "Dexterity": _characterToEdit.Stats.Dexterity++; break;
                case "Constitution":
                    _characterToEdit.Stats.Constitution++;
                    _characterToEdit.CurrentHealth += 1;
                    break;
                case "Intelligence": _characterToEdit.Stats.Intelligence++; break;
                case "Wisdom": _characterToEdit.Stats.Wisdom++; break;
                case "Charisma": _characterToEdit.Stats.Charisma++; break;
            }
            _characterToEdit.StatPoints -= cost;
            StatsInfoRefresh();
            btnSave.Enabled = true;
        }

        private void btnLevelUp_Click(object sender, EventArgs e)
        {
            if (_characterToEdit.Level >= 20)
            {
                MessageBox.Show("Персонаж вже досяг максимального рівня (20).", "Обмеження");
                return;
            }

            try
            {
                int d20Roll = new Random().Next(1, 21);
                int conBonus = (_characterToEdit.Stats.Constitution - 10) / 2;
                int pointsGained = CalculateLevelUpPoints(_characterToEdit.Level);
                _characterToEdit.StatPoints += pointsGained;
                _characterToEdit.LevelUp(d20Roll);

                MessageBox.Show(
                    $"Рівень підвищено! (Кидок D20: {d20Roll}, Бонус CON: {conBonus})\n" +
                    $"Новий рівень: {_characterToEdit.Level}\n" +
                    $"Отримано очок характеристик: {pointsGained}",
                    "Рівень Підвищено");
                DisplayCharacterInfo();
                btnSave.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при підвищенні рівня: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int CalculateLevelUpPoints(int currentLevel)
        {
            if (currentLevel >= 16) return 10;
            if (currentLevel >= 11) return 8;
            if (currentLevel >= 6) return 6;
            if (currentLevel >= 1) return 4;
            return 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _characterRepo.Save(_characterToEdit);
                MessageBox.Show($"Зміни для персонажа '{_characterToEdit.Name}' успішно збережено!",
                    "Збереження успішне", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні персонажа: {ex.Message}", "Помилка збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayCharacterInfo()
        {
            lvlLabel.Text = _characterToEdit.Level.ToString();
            raceLabel.Text = _characterToEdit.Race?.Name ?? "Unknown";
            classLabel.Text = _characterToEdit.Class?.Name ?? "Unknown";

            StatsInfoRefresh();

            // Активуємо кнопку підняти рівень, якщо рівень менше 20
            btnLevelUp.Enabled = _characterToEdit.Level < 20;

            int availablePoints = _characterToEdit.StatPoints;
            StrengthUp.Enabled = availablePoints >= (_characterToEdit.Stats.Strength >= 14 ? 2 : 1);
            DexterityUp.Enabled = availablePoints >= (_characterToEdit.Stats.Dexterity >= 14 ? 2 : 1);
            ConstitutionUp.Enabled = availablePoints >= (_characterToEdit.Stats.Constitution >= 14 ? 2 : 1);
            InteligenceUp.Enabled = availablePoints >= (_characterToEdit.Stats.Intelligence >= 14 ? 2 : 1);
            WisdomUp.Enabled = availablePoints >= (_characterToEdit.Stats.Wisdom >= 14 ? 2 : 1);
            CharismaUp.Enabled = availablePoints >= (_characterToEdit.Stats.Charisma >= 14 ? 2 : 1);

            inventoryListBox.Items.Clear();
            if (_characterToEdit.Inventory?.Items != null)
            {
                foreach (var item in _characterToEdit.Inventory.Items)
                    inventoryListBox.Items.Add($"{item.Name} ({item.Type})");
            }
        }
        private void StatsInfoRefresh()
        {
            Stats stats = _characterToEdit.Stats;
            labelStrength.Text = _characterToEdit.Stats.Strength.ToString();
            labelDexterity.Text = _characterToEdit.Stats.Dexterity.ToString();
            labelConstitution.Text = _characterToEdit.Stats.Constitution.ToString();
            labelInteligence.Text = _characterToEdit.Stats.Intelligence.ToString();
            labelWisdom.Text = _characterToEdit.Stats.Wisdom.ToString();
            labelCharisma.Text = _characterToEdit.Stats.Charisma.ToString();
            labelPoints.Text = _characterToEdit.StatPoints.ToString();
        }

        private void nameInput_TextChanged(object sender, EventArgs e)
        {
            string newName = nameInput.Text.Trim();
            if (string.IsNullOrEmpty(newName))
            {
                return;
            }
            _characterToEdit.Name = newName;
            btnSave.Enabled = true;
        }

        private void healthLabel_TextChanged(object sender, EventArgs e)
        {
            string newHealth = healthLabel.Text.Trim();
            if (string.IsNullOrEmpty(newHealth))
            {
                return;
            }
            _characterToEdit.CurrentHealth = int.Parse(newHealth);
            btnSave.Enabled = true;
        }
    }
}
