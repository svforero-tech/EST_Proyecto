namespace EST_Proyecto
{
    public partial class Form1 : Form
    {
        LinkedListaStack<int> pilaA = new LinkedListaStack<int>();
        LinkedListaStack<int> pilaB = new LinkedListaStack<int>();
        LinkedListaStack<int> pilaC = new LinkedListaStack<int>();

        LinkedListaStack<int> pilaOrigen = null;

        ListBox origenList = null;


        int movimientos = 0;
        int n = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // REINICIAR
        private void ReiniciarJuego()
        {
            pilaA = new LinkedListaStack<int>();
            pilaB = new LinkedListaStack<int>();
            pilaC = new LinkedListaStack<int>();

            StackA.Items.Clear();
            StackB.Items.Clear();
            StackC.Items.Clear();

            movimientos = 0;
            Mov.Text = "0";

        }

        private void ClearLabels()
        {
            txtStackA.Text = string.Empty;
            txtStackB.Text = string.Empty;
            txtStackC.Text = string.Empty;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ReiniciarJuego();
        }

        private void btnSelectA_Click_1(object sender, EventArgs e)
        {
            ClearLabels();
            txtStackA.Text = "Seleccionado";
            SeleccionarTorre(pilaA, StackA);
        }

        private void btnSelectB_Click_1(object sender, EventArgs e)
        {
            ClearLabels();
            txtStackB.Text = "Seleccionado";
            SeleccionarTorre(pilaB, StackB);
        }

        private void btnSelectC_Click_1(object sender, EventArgs e)
        {
            ClearLabels();
            txtStackC.Text = "Seleccionado";
            SeleccionarTorre(pilaC, StackC);
        }

        private void SeleccionarTorre(LinkedListaStack<int> pila, ListBox lista)
        {
            if (pilaOrigen == null)
            {
                if (pila.IsEmpty())
                {
                    MessageBox.Show("La torre está vacía");
                    return;
                }

                pilaOrigen = pila;
                origenList = lista;
            }
            
        }        

        private void btnIniciar_Click_1(object sender, EventArgs e)
        {

            try
            {
                int N = int.Parse(txtAgregar.Text);
                if (n < 0)
                {
                    MessageBox.Show("Ingrese un número mayor a 0");
                    return;
                }



                for (int i = n; i >= 1; i--)
                {
                    pilaA.Push(i);
                    StackA.Items.Add(i);
                }

                movimientos = 0;
                Mov.Text = "0";

                int min = (int)Math.Pow(2, n) - 1;
                MinMov.Text = min.ToString();

            }

            catch (Exception ex) { MessageBox.Show(ex.Message); return; }
        }

        
    }
}