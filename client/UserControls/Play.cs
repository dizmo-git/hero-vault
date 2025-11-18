using client.Models;
using client.Repositories;
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

namespace client.UserControls
{
    public partial class Play : UserControl
    {
        public Play()
        {
            InitializeComponent();
        }

        private void Play_Load(object sender, EventArgs e)
        {
            flowPanel.Controls.Clear();
            CharacterRepository charRepo = new CharacterRepository();
            List<Character> list = charRepo.GetAllCharacters(XmlStorageService.DirectoryPath);
            Debug.WriteLine("CharListSize: " + list.Count);
            foreach (Character character in list)
            {
                Button btn = new Button();
                btn.Text = character.Name + " " + character.Level;
                btn.Width = 100;
                btn.Height = 30;
                btn.Tag = character;
                btn.Click += EditCharButton_Click;
                flowPanel.Controls.Add(btn);
            }
        }

        private void EditCharButton_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if(btn.Tag is Character character)
            {
                CharacterEditorForm editor = new CharacterEditorForm(character);
                editor.ShowDialog();

                btn.Text = character.Name;
            }
        }
    }
}
