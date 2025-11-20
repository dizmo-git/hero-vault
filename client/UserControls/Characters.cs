using client.Models;
using client.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.UserControls
{
    public partial class Characters : UserControl
    {
        // Приватне поле для репозиторію та списку персонажів
        private readonly CharacterRepository _repository = new CharacterRepository();
        private List<Character> _allCharacters;
        private Character _selectedCharacter;
        private static readonly Random _random = new Random();

        public Characters()
        {
            InitializeComponent();
            // Додаємо обробники подій динамічно (або через Designer)
            textBox1.TextChanged += textBox1_TextChanged;
            button1.Click += button1_Click;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            btnView.Click += btnView_Click;
            btnDelete.Click += btnDelete_Click;
            btnLevelUp.Click += btnLevelUp_Click;
            StrengthUp.Click += StatUp_Click;
            DexterityUp.Click += StatUp_Click;
            ConstitutionUp.Click += StatUp_Click;
            InteligenceUp.Click += StatUp_Click;
            WisdomUp.Click += StatUp_Click;
            CharismaUp.Click += StatUp_Click;
            AddToInventorybutton.Click += AddToInventorybutton_Click;
            textBox2.TextChanged += textBox2_TextChanged;
            InventorylistBoxUp.SelectedIndexChanged += InventorylistBoxUp_SelectedIndexChanged;

            btnRefresh.Click += btnRefresh_Click;
        }

        // Завантаження даних при відображенні контролу
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadCharactersData();
            // Налаштовуємо DataGridView
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            // Деактивуємо кнопку View на старті та очищаємо деталі
            btnView.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnRefresh.Enabled = true;

            StrengthUp.Enabled = false;
            DexterityUp.Enabled = false;
            ConstitutionUp.Enabled = false;
            InteligenceUp.Enabled = false;
            WisdomUp.Enabled = false;
            CharismaUp.Enabled = false;

            btnDelete.Text = "Видалити";

            ClearDetailsPanel();
        }

        /// <summary>
        /// Завантажує всі персонажі та оновлює DataGridView.
        /// </summary>
        public void LoadCharactersData()
        {
            _allCharacters = _repository.GetAllCharacters();
            DisplayCharacters(_allCharacters);
        }

        /// <summary>
        /// Відображає заданий список персонажів у DataGridView.
        /// </summary>
        private void DisplayCharacters(List<Character> characters)
        {
            // Створюємо анонімний тип для відображення лише потрібних стовпців
            var displayList = characters.Select(c => new
            {
                Name = c.Name,
                Race = c.Race?.Name ?? "Unknown",
                Class = c.Class?.Name ?? "Unknown",
                Level = c.Level,
                FullCharacter = c
            }).ToList();

            dataGridView1.DataSource = displayList;

            // Налаштування заголовків та приховування службового поля
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["Name"].HeaderText = "Ім'я Персонажа";
                dataGridView1.Columns["Race"].HeaderText = "Раса";
                dataGridView1.Columns["Class"].HeaderText = "Клас";
                dataGridView1.Columns["Level"].HeaderText = "Рівень";

                // Приховуємо поле з повним об'єктом
                dataGridView1.Columns["FullCharacter"].Visible = false;
            }

            // Скидання вибору, оскільки список оновлено
            _selectedCharacter = null;
            btnView.Enabled = false;
            btnDelete.Enabled = false;
        }

        /// <summary>
        /// Визначає, скільки очок характеристик персонаж отримує при підвищенні рівня.
        /// </summary>
        private int CalculateLevelUpPoints(int currentLevel)
        {
            if (currentLevel >= 16) return 10;
            if (currentLevel >= 11) return 8;
            if (currentLevel >= 6) return 6;
            if (currentLevel >= 1) return 4;
            return 0;
        }

        /// <summary>
        /// Очищає панель деталей персонажа.
        /// </summary>
        private void ClearDetailsPanel()
        {
            // Основні дані
            lblName.Text = "-";
            lblLevel.Text = "-";
            lblHealth.Text = "-";
            lblCurrentLevel.Text = "-";
            labelPoints.Text = "-";

            // Характеристики
            labelStrength.Text = "-";
            labelDexterity.Text = "-";
            labelConstitution.Text = "-";
            labelInteligence.Text = "-";
            labelWisdom.Text = "-";
            labelCharisma.Text = "-";

            // Інвентар
            InventorylistBoxUp.Items.Clear();
        }

        /// <summary>
        /// Обробник зміни вибраного рядка в таблиці.
        /// </summary>
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Перевіряємо, чи вибрано хоча б один рядок
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Отримуємо повний об'єкт Character зі службового поля FullCharacter
                dynamic selectedItem = selectedRow.DataBoundItem;
                _selectedCharacter = selectedItem.FullCharacter as Character;

                btnView.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                _selectedCharacter = null;
                btnView.Enabled = false;
                btnDelete.Enabled = false;
                ClearDetailsPanel(); // Очищаємо панель
            }
        }

        /// <summary>
        /// Обробник натискання кнопки "View".
        /// </summary>
        private void btnView_Click(object sender, EventArgs e)
        {
            if (_selectedCharacter == null)
            {
                MessageBox.Show("Помилка: Не вибрано жодного персонажа.");
                return;
            }

            // 1. Виведення основних даних
            lblName.Text = _selectedCharacter.Name;
            lblLevel.Text = _selectedCharacter.Level.ToString();

            // Поточне здоров'я беремо з поля CurrentHealth
            lblHealth.Text = _selectedCharacter.CurrentHealth.ToString();

            // Наступний рівень = Поточний рівень + 1
            lblCurrentLevel.Text = (_selectedCharacter.Level + 1).ToString();

            // Виведення очок характеристик
            labelPoints.Text = _selectedCharacter.StatPoints.ToString();

            // 2. Виведення характеристик (Stats)
            labelStrength.Text = _selectedCharacter.Stats.Strength.ToString();
            labelDexterity.Text = _selectedCharacter.Stats.Dexterity.ToString();
            labelConstitution.Text = _selectedCharacter.Stats.Constitution.ToString();
            labelInteligence.Text = _selectedCharacter.Stats.Intelligence.ToString();
            labelWisdom.Text = _selectedCharacter.Stats.Wisdom.ToString();
            labelCharisma.Text = _selectedCharacter.Stats.Charisma.ToString();

            // 3. Виведення інвентаря
            InventorylistBoxUp.Items.Clear();
            if (_selectedCharacter.Inventory?.Items != null)
            {
                foreach (var item in _selectedCharacter.Inventory.Items)
                {
                    // Виводимо Ім'я та Тип предмета
                    InventorylistBoxUp.Items.Add($"{item.Name} ({item.Type})");
                }
            }

            int availablePoints = _selectedCharacter.StatPoints;

            // Логіка: доступні_очки >= (показник >= 14 ? 2 : 1)
            // Активуємо кнопку підняти рівень, якщо рівень менше 20
            btnLevelUp.Enabled = _selectedCharacter.Level < 20;

            StrengthUp.Enabled = availablePoints >= (_selectedCharacter.Stats.Strength >= 14 ? 2 : 1);
            DexterityUp.Enabled = availablePoints >= (_selectedCharacter.Stats.Dexterity >= 14 ? 2 : 1);
            ConstitutionUp.Enabled = availablePoints >= (_selectedCharacter.Stats.Constitution >= 14 ? 2 : 1);
            InteligenceUp.Enabled = availablePoints >= (_selectedCharacter.Stats.Intelligence >= 14 ? 2 : 1);
            WisdomUp.Enabled = availablePoints >= (_selectedCharacter.Stats.Wisdom >= 14 ? 2 : 1);
            CharismaUp.Enabled = availablePoints >= (_selectedCharacter.Stats.Charisma >= 14 ? 2 : 1);
        }

        /// <summary>
        /// Обробник натискання кнопки "Level Up". 
        /// Підвищує рівень, здоров'я та нараховує StatPoints.
        /// </summary>
        private void btnLevelUp_Click(object sender, EventArgs e)
        {
            if (_selectedCharacter == null)
            {
                MessageBox.Show("Будь ласка, оберіть персонажа для підвищення рівня.");
                return;
            }

            // Максимальний рівень 20
            if (_selectedCharacter.Level >= 20)
            {
                MessageBox.Show("Персонаж вже досяг максимального рівня (20).", "Обмеження");
                return;
            }

            try
            {
                // 1. Кидок D20
                int d20Roll = _random.Next(1, 21); // Імітація кидка D20
                int conBonus = (_selectedCharacter.Stats.Constitution - 10) / 2;

                // 2. Нарахування очок характеристик (до підвищення рівня)
                int pointsGained = CalculateLevelUpPoints(_selectedCharacter.Level);
                _selectedCharacter.StatPoints += pointsGained;

                // 3. Виклик методу моделі (оновлює Level та CurrentHealth)
                _selectedCharacter.LevelUp(d20Roll);

                // Зберігаємо новий рівень для повідомлення
                int newLevel = _selectedCharacter.Level;

                // Автоматично зберігаємо зміни
                _repository.Save(_selectedCharacter);

                // 4. Повідомлення про успіх
                MessageBox.Show(
                    $"Рівень підвищено! (Кидок D20: {d20Roll}, Бонус CON: {conBonus})\n" +
                    $"Новий рівень: {_selectedCharacter.Level}\n" +
                    $"Отримано очок характеристик: {pointsGained}",
                    "Рівень Підвищено");

                // 5. Оновлюємо список спочатку
                string selectedName = _selectedCharacter.Name;
                LoadCharactersData();

                // Відновлюємо вибір
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dynamic item = dataGridView1.Rows[i].DataBoundItem;
                    if (item.Name == selectedName)
                    {
                        dataGridView1.ClearSelection();
                        dataGridView1.Rows[i].Selected = true;
                        _selectedCharacter = item.FullCharacter as Character;
                        break;
                    }
                }

                // Тепер оновлюємо UI
                btnView_Click(btnView, EventArgs.Empty);

                // Зміни вже збережені автоматично
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при підвищенні рівня: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обробник натискання кнопок підвищення характеристик (StrengthUp, DexterityUp, і т.д.).
        /// Витрачає StatPoints для підвищення відповідної характеристики персонажа.
        /// Вартість підвищення: 1 очко (до 14) або 2 очки (14+).
        /// </summary>
        private void StatUp_Click(object sender, EventArgs e)
        {
            if (_selectedCharacter == null) return;

            Button btn = sender as Button;
            if (btn == null) return;

            int cost = 1;
            string statName = "";
            int currentStatValue = 0;

            // 1. Визначаємо характеристику та її поточне значення
            switch (btn.Name)
            {
                case "StrengthUp":
                    statName = "Strength";
                    currentStatValue = _selectedCharacter.Stats.Strength;
                    break;
                case "DexterityUp":
                    statName = "Dexterity";
                    currentStatValue = _selectedCharacter.Stats.Dexterity;
                    break;
                case "ConstitutionUp":
                    statName = "Constitution";
                    currentStatValue = _selectedCharacter.Stats.Constitution;
                    break;
                case "InteligenceUp":
                    statName = "Intelligence";
                    currentStatValue = _selectedCharacter.Stats.Intelligence;
                    break;
                case "WisdomUp":
                    statName = "Wisdom";
                    currentStatValue = _selectedCharacter.Stats.Wisdom;
                    break;
                case "CharismaUp":
                    statName = "Charisma";
                    currentStatValue = _selectedCharacter.Stats.Charisma;
                    break;
                default:
                    return;
            }

            // 2. Визначаємо вартість: 1 очко (якщо < 14) або 2 очки (якщо >= 14)
            if (currentStatValue >= 14)
            {
                cost = 2;
            }

            // 3. Перевірка достатньої кількості очок
            if (_selectedCharacter.StatPoints < cost)
            {
                MessageBox.Show($"Для підвищення {statName} необхідно {cost} очок.", "Недостатньо очок", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Підвищення характеристики та оновлення здоров'я для Constitution
            switch (statName)
            {
                case "Strength": _selectedCharacter.Stats.Strength++; break;
                case "Dexterity": _selectedCharacter.Stats.Dexterity++; break;
                case "Constitution":
                    _selectedCharacter.Stats.Constitution++;
                    // Додаємо +1 до здоров'я (якщо це окремий пункт CON)
                    _selectedCharacter.CurrentHealth += 1;
                    break;
                case "Intelligence": _selectedCharacter.Stats.Intelligence++; break;
                case "Wisdom": _selectedCharacter.Stats.Wisdom++; break;
                case "Charisma": _selectedCharacter.Stats.Charisma++; break;
            }

            // 5. Витрата очок
            _selectedCharacter.StatPoints -= cost;

            // 6. Оновлення UI (це також оновить стан активності кнопок)
            btnView_Click(btnView, EventArgs.Empty);

            // Активуємо кнопку Edit для збереження змін
            btnEdit.Enabled = true;
        }

        /// <summary>
        /// Обробник натискання кнопки "Додати до інвентаря".
        /// Додає введений користувачем предмет до інвентаря персонажа.
        /// </summary>
        private void AddToInventorybutton_Click(object sender, EventArgs e)
        {
            if (_selectedCharacter == null)
            {
                MessageBox.Show("Будь ласка, оберіть персонажа.", "Помилка");
                return;
            }

            string itemName = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(itemName))
            {
                // Цей код не повинен виконуватись, якщо кнопка правильно деактивована,
                // але це додаткова перевірка.
                return;
            }

            try
            {
                // Створюємо новий базовий предмет (без Power та детальних описів)
                var newItem = new Item(itemName, $"Custom item: {itemName}", ItemType.Trinket);

                // 1. Додаємо предмет до моделі
                _selectedCharacter.Inventory.AddItem(newItem);

                // 2. Оновлюємо UI (InventorylistBoxUp відображає інвентар)
                InventorylistBoxUp.Items.Add(newItem.Name); // Використовуйте InventorylistBox для відображення

                // 3. Очищуємо поле вводу
                textBox2.Clear();

                // 4. Деактивуємо кнопку Add (через зміну тексту в textBox2)
                // Обробник textBox2_TextChanged автоматично подбає про це.

                // 5. Активуємо кнопку Edit для збереження змін
                btnEdit.Enabled = true;

                MessageBox.Show($"Предмет '{itemName}' додано до інвентаря.", "Успіх");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні предмета: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обробник зміни вибраного елемента у списку інвентарю.
        /// Активує кнопку "Видалити предмет" та змінює її текст, якщо вибрано предмет.
        /// </summary>
        private void InventorylistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Перевіряємо, чи вибрано хоча б один предмет
            if (InventorylistBoxUp.SelectedIndex != -1)
            {
                // Активуємо кнопку
                btnDelete.Enabled = true;
                // Змінюємо текст
                btnDelete.Text = "Вид Пред";
            }
            else
            {
                // Якщо нічого не вибрано, деактивуємо кнопку та повертаємо стандартний текст
                btnDelete.Enabled = false;
                btnDelete.Text = "Видалити";
            }
        }

        /// <summary>
        /// Обробник зміни тексту в полі textBox2.
        /// Керує активністю кнопки AddToInventorybutton.
        /// </summary>
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Кнопка активна, тільки якщо поле не порожнє (після видалення пробілів) 
            // і персонаж вибраний
            bool isTextValid = !string.IsNullOrWhiteSpace(textBox2.Text);
            bool isCharacterSelected = _selectedCharacter != null;

            AddToInventorybutton.Enabled = isTextValid && isCharacterSelected;
        }

        /// <summary>
        /// Обробник натискання кнопки "Edit" (Зберегти).
        /// Зберігає всі поточні зміни (_selectedCharacter) у сховищі.
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // 1. Перевірка наявності вибраного персонажа
            if (_selectedCharacter == null)
            {
                MessageBox.Show("Спочатку оберіть персонажа для збереження.", "Помилка збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 2. Використання CharacterRepository для збереження
                _repository.Save(_selectedCharacter);

                // 3. Візуальне підтвердження успіху
                MessageBox.Show($"Зміни для персонажа '{_selectedCharacter.Name}' успішно збережено!", "Збереження успішне", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 4. Деактивація кнопки "Edit"
                // Після збереження кнопка має бути неактивною, щоб сигналізувати, 
                // що нових незбережених змін немає.
                btnEdit.Enabled = false;

                // 5. Оновлення списку персонажів
                LoadCharactersData();
            }
            catch (Exception ex)
            {
                // Обробка можливих помилок, наприклад, помилок запису на диск
                MessageBox.Show($"Помилка при збереженні персонажа: {ex.Message}", "Помилка збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Обробник натискання кнопки "Видалити".
        /// Видаляє або персонажа, або вибраний предмет з інвентарю.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedCharacter == null)
            {
                MessageBox.Show("Спочатку оберіть персонажа.", "Помилка");
                return;
            }

            if (btnDelete.Text == "Вид Пред")
            {
                // --- ЛОГІКА ВИДАЛЕННЯ ПРЕДМЕТА З ІНВЕНТАРЮ ---

                string selectedItemName = InventorylistBoxUp.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedItemName))
                {
                    MessageBox.Show("Виберіть предмет для видалення.", "Помилка");
                    return;
                }

                if (MessageBox.Show($"Ви впевнені, що хочете видалити предмет '{selectedItemName}'?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // 1. Видаляємо з моделі
                    _selectedCharacter.Inventory.RemoveItem(selectedItemName);

                    // 2. Оновлюємо UI (Listbox)
                    InventorylistBoxUp.Items.RemoveAt(InventorylistBoxUp.SelectedIndex);

                    // 3. Скидаємо стан кнопки
                    btnDelete.Text = "Видалити";
                    btnDelete.Enabled = false;

                    // 4. Активуємо кнопку Edit для збереження змін
                    btnEdit.Enabled = true;

                    MessageBox.Show($"Предмет '{selectedItemName}' видалено.", "Успіх");
                }
            }
            else // btnDelete.Text == "Видалити" (Логіка видалення персонажа)
            {
                if (MessageBox.Show($"Ви впевнені, що хочете видалити персонажа '{_selectedCharacter.Name}'?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _repository.Delete(_selectedCharacter.Name);
                    _selectedCharacter = null;
                    LoadCharactersData();
                    ClearDetailsPanel();
                    MessageBox.Show("Персонажа видалено.", "Успіх");
                }
            }
        }

        /// <summary>
        /// Обробник натискання кнопки "Refresh".
        /// Повністю перезавантажує список персонажів з файлової системи.
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Викликаємо метод, який завантажує дані з CharacterRepository
            LoadCharactersData();

            // Очищаємо деталі та деактивуємо кнопки, оскільки вибір може зникнути після оновлення
            ClearDetailsPanel();
            btnView.Enabled = false;
            btnDelete.Enabled = false;
        }

        // Обробник події TextChanged для textBox1
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                // Якщо поле пусте, показуємо всіх персонажів
                DisplayCharacters(_allCharacters);
            }
            else
            {
                // Фільтруємо список персонажів за іменем (часткова відповідність, без урахування регістру)
                var filteredCharacters = _allCharacters
                    .Where(c => c.Name.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();

                DisplayCharacters(filteredCharacters);
            }
        }

        // Обробник події Click для button1
        private void button1_Click(object sender, EventArgs e)
        {
            // Очищення поля вводу
            textBox1.Clear();
        }


        private void InventorylistBoxUp_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Логіка для кнопки "Видалити"
            if (InventorylistBoxUp.SelectedIndex != -1)
            {
                btnDelete.Enabled = true;
                btnDelete.Text = "Вид Пред";
            }
            else
            {
                btnDelete.Enabled = false;
                btnDelete.Text = "Видалити";
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            // Залишити порожнім
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            // Залишити порожнім
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            // Залишити порожнім
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Залишити порожнім
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Залишити порожнім
        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {
            // Залишити порожнім
        }

        // Помилка, пов'язана з текстовим полем, імовірно, дублікат
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            // Залишити порожнім
        }
    }
}
