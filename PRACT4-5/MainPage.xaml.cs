namespace PRACT4_5
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void nn_Clicked(object sender, EventArgs e) //ЦИФРЫ
        {
            var z = sender as Button;
            switch (z.Text)
            {
                case "0": numtext.Text += "0"; break;
                case "1": numtext.Text += "1"; break;
                case "2": numtext.Text += "2"; break;
                case "3": numtext.Text += "3"; break;
                case "4": numtext.Text += "4"; break;
                case "5": numtext.Text += "5"; break;
                case "6": numtext.Text += "6"; break;
                case "7": numtext.Text += "7"; break;
                case "8": numtext.Text += "8"; break;
                case "9": numtext.Text += "9"; break;
                case "/": numtext.Text += "/"; break;
                case "*": numtext.Text += "*"; break;
                case "+": numtext.Text += "+"; break;
                case "-": numtext.Text += "-"; break;
                case ",": numtext.Text += ","; break;
                case "(": numtext.Text += "("; break;
                case ")": numtext.Text += ")"; break;


            }
        }

        private void db_Clicked(object sender, EventArgs e) //УДАЛЕНИЕ ПО ОДНОМУ СИМВОЛУ
        {
            string text = numtext.Text;
            if (!string.IsNullOrEmpty(text))
            {
                numtext.Text = text.Substring(0, text.Length-1);
            }
        }

        private void nDegit_Clicked(object sender, EventArgs e)
        {
            
        }

        private void bAC_Clicked(object sender, EventArgs e)
        {
            numtext.Text = "";
        }
    }

}
