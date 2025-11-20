using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using client.Utilities;
using client.Models;
using client.Factories;
using client.Models.Classes;
using client.Models.Races;
using client.Repositories;

namespace client.UserControls
{
    public partial class CreateCharacter : UserControl
    {
        private const int CB_SETCUEBANNER = 0x1703;

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);

        public CreateCharacter()
        {
            InitializeComponent();
        }

        private void CreateCharacter_Load(object sender, EventArgs e)
        {
            InitRaceDropdown();
            InitClassDropdown();
            UpdateStatsPreview();
        }

        private void InitClassDropdown()
        {
            classDropdown.Items.AddRange(new[] { "Warrior", "Mage", "Ranger" });
            SendMessage(classDropdown.Handle, CB_SETCUEBANNER, 0, "Class");
            classDropdown.SelectedIndex = -1;
        }

        private void InitRaceDropdown()
        {
            raceDropdown.Items.AddRange(new[] { "Human", "Elf", "Dwarf" });
            SendMessage(raceDropdown.Handle, CB_SETCUEBANNER, 0, "Race");
            raceDropdown.SelectedIndex = -1;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text.Trim();
            string raceName = raceDropdown.SelectedItem?.ToString();
            string className = classDropdown.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(name) || raceName == null || className == null)
            {
                MessageBox.Show(
                    "Please enter a name and select a race and class.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            var race = RaceFactory.Create(raceName);
            var characterClass = ClassFactory.Create(className);
            var character = new Character(name, race, characterClass);

            var repository = new CharacterRepository();
            repository.Save(character);

            MessageBox.Show(
                $"Character '{character.Name}' created successfully!",
                "Character Created",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            ClearForm();
        }

        private void ClearForm()
        {
            nameInput.Clear();
            raceDropdown.SelectedIndex = -1;
            classDropdown.SelectedIndex = -1;
            UpdateStatsPreview();
        }

        private void raceDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatsPreview();
        }

        private void classDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatsPreview();
        }

        private void UpdateStatsPreview()
        {
            Stats raceStats = raceDropdown.SelectedItem != null
                ? RaceFactory.Create(raceDropdown.SelectedItem.ToString()).BaseStats
                : null;

            Stats classBonus = classDropdown.SelectedItem != null
                ? ClassFactory.Create(classDropdown.SelectedItem.ToString()).GetClassBonus()
                : null;

            Stats tempStats = (raceStats ?? new Stats()) + (classBonus ?? new Stats());

            SetLabel(strengthLabel, "Strength", tempStats.Strength);
            SetLabel(dexterityLabel, "Dexterity", tempStats.Dexterity);
            SetLabel(constitutionLabel, "Constitution", tempStats.Constitution);
            SetLabel(intelligenceLabel, "Intelligence", tempStats.Intelligence);
            SetLabel(wisdomLabel, "Wisdom", tempStats.Wisdom);
            SetLabel(charismaLabel, "Charisma", tempStats.Charisma);

            inventoryListBox.Items.Clear();
            if (classDropdown.SelectedItem != null)
            {
                var characterClass = ClassFactory.Create(classDropdown.SelectedItem.ToString());
                foreach (var item in characterClass.StartingEquipment)
                    inventoryListBox.Items.Add(item.Name);
            }
        }

        private void SetLabel(Label label, string name, int value)
        {
            label.Text = $"{name}: {value}";
        }
    }
}
