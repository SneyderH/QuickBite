using QuickBite.Forms;
using QuickBite.Services;

namespace QuickBite
{
    public partial class Form1 : Form
    {
        private readonly UserService _userService = new UserService();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = _userService.AuthLogin(txtUsername.Text);

            if (user != null)
            {
                CurrentSession.CurrentUser = user;
                OpenFormBasedOnRole();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
            }
        }

        private void OpenFormBasedOnRole()
        {
            string rol = CurrentSession.CurrentUser.Role.RoleName;

            switch (rol)
            {
                case "Waiter":
                    this.Hide();
                    WaiterForm wtrForm = new WaiterForm();
                    wtrForm.Show();
                    break;
                case "Cooker":
                    this.Hide();
                    KitchenForm ckrForm = new KitchenForm();
                    ckrForm.Show();
                    break;
                case "Cashier":
                    this.Hide();
                    CashierForm chrForm = new CashierForm();
                    chrForm.Show();
                    break;
                case "Admin":
                    this.Hide();
                    AdminForm admForm = new AdminForm();
                    admForm.Show();
                    break;
                default:
                    MessageBox.Show("Este usuario no se ha asignado a ningún rol");
                    break;
            }
        }
    }
}
