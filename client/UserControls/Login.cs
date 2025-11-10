using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace client.UserControls
{
    public partial class Login : UserControl
    {
        private string filePath = "users.xml";
        private int currentUserId = 1;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            InitializeUserIdCounter();
            label5.Text = "Status: Awaiting login or registration";
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void InitializeUserIdCounter()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    XDocument doc = XDocument.Load(filePath);
                    var maxId = doc.Root?.Elements("User")
                                     .Select(el => (int?)el.Attribute("id"))
                                     .Max();

                    if (maxId.HasValue)
                    {
                        currentUserId = maxId.Value + 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading existing XML file to determine ID: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Username cannot be empty.");
                return;
            }

            try
            {
                XDocument doc;
                bool fileExists = File.Exists(filePath);

                if (fileExists)
                {
                    doc = XDocument.Load(filePath);

                    bool userExists = doc.Root.Elements("User")
                                              .Any(el => (string)el.Element("Name") == name);

                    if (userExists)
                    {
                        MessageBox.Show($"Error: User with name '{name}' already exists.");
                        return;
                    }
                }
                else
                {
                    doc = new XDocument(new XElement("Users"));
                }

                XElement newUser = new XElement("User",
                    new XAttribute("id", currentUserId),
                    new XElement("Name", name),
                    new XElement("Password", password)
                );

                if (doc.Root != null)
                {
                    doc.Root.Add(newUser);
                }
                else
                {
                    doc.Add(new XElement("Users", newUser));
                }

                doc.Save(filePath);

                MessageBox.Show($"User {name} (ID: {currentUserId}) successfully added.");

                currentUserId++;

                textBox1.Clear();
                textBox2.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding to XML file: " + ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            if (!File.Exists(filePath))
            {
                MessageBox.Show("User database not found. Please register first.");
                return;
            }

            try
            {
                XDocument doc = XDocument.Load(filePath);

                XElement user = doc.Root.Elements("User")
                                       .FirstOrDefault(el =>
                                           (string)el.Element("Name") == name &&
                                           (string)el.Element("Password") == password);

                if (user != null)
                {
                    MessageBox.Show($"Welcome, {name}!");

                    label5.Text = $"Logged in as: {name} (ID: {(string)user.Attribute("id")})";

                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("Login error: Incorrect username or password.");
                    label5.Text = "Status: Login error";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading XML file for login: " + ex.Message);
                label5.Text = "Status: DB read error";
            }
        }
    }
}

