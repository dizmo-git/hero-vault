using client.UserControls;

namespace client
{
    //Це фронтенд, по суті. 
    public partial class ClientInterface : Form
    {
        public ClientInterface()
        {
            InitializeComponent();
        }
        private void ClientInterface_Load(object sender, EventArgs e)
        {
            AddUserControl(new Login());
        }

        public void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        
        //У нас тільки одна форма на весь додаток. Все інше це "User Controls"
        //З ними можна так само працювати як з формами, тобто, додавати компоненти і т.д.
        private void loginButton_Click(object sender, EventArgs e)
        {
            AddUserControl(new Login());
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            AddUserControl(new CreateCharacter());
        }

        private void charactersButton_Click(object sender, EventArgs e)
        {
            AddUserControl(new Characters());
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            AddUserControl(new Play());
        }
    }
}