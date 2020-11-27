using System;
using Sorter;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Radix_Sort_GUI {


    public partial class FormPrincipal : Form {

  

        public FormPrincipal() {
            InitializeComponent();
        }

        private int[] arregloVersus, arregloVersusDos;

        private int[] arregloUniversal;
        private Empleado[] empleados;

        private int[] arregloBuckets;

        private ListBox[] buckets = default;

        private void btnGenerar_Click(object sender, EventArgs e) {
            if (CamposCompletadosTabNormal()) {
                listNumerosTabNormal.Items.Clear();
                arregloUniversal = new int[int.Parse(txtCuantosNumerosNormales.Text.ToString())];

                int valorInicial = (int)desde.Value;
                int valorFinal = (int)hasta.Value;
                int cuantos = int.Parse(txtCuantosNumerosNormales.Text.ToString());
                GenerarNumeros(valorInicial, valorFinal, cuantos);

            } else MessageBox.Show("Error en los campos completados");
        }


        private  void GenerarNumeros(int valorInicial, int valorFinal, int cuantos) {
            btnGenerar.Enabled = false;
            btnOrdenar.Enabled = false;
            Random random = new Random();
            for (int i = 0; i <cuantos; i++) {
                arregloUniversal[i] = random.Next(valorInicial, valorFinal + 1);
                listNumerosTabNormal.Items.Add(arregloUniversal[i]);
            }
            btnGenerar.Enabled = true;
            btnOrdenar.Enabled = true;
        }

        private bool CamposCompletadosTabNormal() {
            return !(string.IsNullOrEmpty(txtCuantosNumerosNormales.Text))
                && desde.Value >= 0 && hasta.Value > 0
                && (desde.Value < hasta.Value);
        }


        public  void MostrarArregloOrdenado() {
            listNumerosOrdenadosTabNormal.Items.Clear();
            for (int i = 0; i < int.Parse(txtCuantosNumerosNormales.Text.ToString()); i++) {
                listNumerosOrdenadosTabNormal.Items.Add(arregloUniversal[i]);
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e) {

            btnGenerar.Enabled = false;
            btnOrdenar.Enabled = false;

            var reloj = System.Diagnostics.Stopwatch.StartNew();
            Sorting.RadixSort(ref arregloUniversal);
            reloj.Stop();
            var elapsedMs = reloj.Elapsed.TotalMilliseconds;
            lblTiempoNormal.Text = "";
            lblTiempoNormal.Text = $"Tiempo en ordenar: {elapsedMs} ms";
            MessageBox.Show("Ordenado");
            MostrarArregloOrdenado();

            btnGenerar.Enabled = true;
            btnOrdenar.Enabled = true;
        }

        private void btnGeneraObjetos_Click(object sender, EventArgs e) {

            dtgObjetos.Rows.Clear();
            

            Random random = new Random();

            int intCantidad = int.Parse(txtCantidadObjetos.Text.ToString());

            empleados = new Empleado[intCantidad];

            Empleado empleado; 
            for( var i =0; i < intCantidad; i++) {
                empleado = new Empleado() {
                    Nombre = Guid.NewGuid().ToString().Substring(0, 10),
                    Edad = random.Next(1, 101),
                    HorasTrabajadas = random.Next(1, 60),
                    ID = random.Next(1000, 10000)
                };

                empleados[i] = empleado;
                dtgObjetos.Rows.Add(empleado.ID, empleado.Nombre,
                    empleado.Edad, empleado.HorasTrabajadas);
            }


        }

        private void MostrarEmpleados() {
            dtgObjetos.Rows.Clear();
            for(var i =0; i<empleados.Length; i++) {
                dtgObjetos.Rows.Add(empleados[i].ID,
                    empleados[i].Nombre, empleados[i].Edad,
                    empleados[i].HorasTrabajadas);
            }
        }


        private void btnOrdenarObjetos_Click(object sender, EventArgs e) {
            var reloj = System.Diagnostics.Stopwatch.StartNew();
            Sorting.RadixSort(ref empleados);
            reloj.Stop();
            var elapsedMs = reloj.Elapsed.TotalMilliseconds;
            lblTiempoOrdenamientoObjetos.Text = "Tiempo en ordenar los objetos: "+elapsedMs.ToString()+" ms";
            MostrarEmpleados();
        }


        private void btnGenerarBuckets_Click(object sender, EventArgs e) {
            Random random = new Random();
            listNumerosEnBuckets.Items.Clear();

            int intCantidad = (int)numericNumerosBuckets.Value;

            arregloBuckets = new int[intCantidad];
            for( var i = 0; i < arregloBuckets.Length; i++) {
                arregloBuckets[i] = random.Next(1001, 10001);
                listNumerosEnBuckets.Items.Add(arregloBuckets[i]);
            }

            btnSimular.Enabled = true;
        }

        //Compare
        private void RadixSort(ref int[] arreglo) {
            Queue<int>[] cubetas = new Queue<int>[10];
            for (var i = 0; i < 10; i++)
                cubetas[i] = new Queue<int>();

            int intRadix;
            int intPosicion = 1;

            int intMaximoDelArreglo = arreglo.Max();
            while (intMaximoDelArreglo / intPosicion > 0) {
                foreach (var intElemento in arreglo) {
                    intRadix = intElemento / intPosicion;
                    cubetas[intRadix % 10].Enqueue(intElemento);
                }
                for (int i = 0, posicion = 0; i < 10; i++) {
                    while (cubetas[i].Count != 0) {
                        arreglo[posicion++] = cubetas[i].Dequeue();
                    }
                }
                intPosicion *= 10;
            }
        }
        //Compare
       private  void QuickSort(ref int[] arreglo, int bajo, int tope) {
            int i = bajo;
            int j = tope;
            int pivote = arreglo[(i + j) / 2];
            int temporal; // pa cambiar xd

            while (i <= j) {
                while (arreglo[i] < pivote)
                    i++;
                while (arreglo[j] > pivote)
                    j--;
                if (i <= j) {
                    temporal = arreglo[i];
                    arreglo[i] = arreglo[j];
                    arreglo[j] = temporal;
                    i++;
                    j--;
                }
            }
            if (j > bajo)
                QuickSort(ref arreglo, bajo, j);
            if (i < tope)
                 QuickSort(ref arreglo, i, tope);


        }



        public  async void RadixSortSimulado(int[] arreglo) {
            int intArregloDesencolador = 0;

            btnGenerarBuckets.Enabled = false;
            btnSimular.Enabled = false;
            numericDelay.Enabled = false;

            int intDelay = (int) numericDelay.Value;

            Queue<int>[] cubetas = new  Queue<int>[10];

            for (var i = 0; i < 10; i++) {
                cubetas[i] = new Queue<int>();
            }

            var intIteraciones = 0;

            int intRadix;
            int intPosicion = 1;

            int intMaximoDelArreglo = arreglo.Max();
            while (intMaximoDelArreglo / intPosicion > 0) {



                intIteraciones++;

                lblIteraciones.Text = $"Iteracion: {intIteraciones}";

                LimpiarBuckets();

                foreach (var intElemento in arreglo) {
                    intRadix = intElemento / intPosicion;
                    await Task.Delay(intDelay);
                    cubetas[intRadix % 10].Enqueue(intElemento);
                    await KeepRemovingOrdered(intDelay);
                    AddBucketItems(buckets[intRadix%10], cubetas[intRadix%10]);

                }

                for (int i = 0, posicion = 0; i < 10; i++) {
                    while (cubetas[i].Count != 0) {
                        arreglo[posicion++] = cubetas[i].Dequeue();
                        intArregloDesencolador++;
                        await Task.Delay(intDelay);
                        RemoveBucketItem(buckets[i]);
                    }
                }
                intPosicion *= 10;

               
            }

            MessageBox.Show("Ordenado");
            MessageBox.Show("Accesos al arreglo (cuando se desencola): "+intArregloDesencolador);

            btnGenerarBuckets.Enabled = true;
            btnSimular.Enabled = true;
            numericDelay.Enabled = true;
        }

        private async Task KeepRemovingOrdered(int intDelay) {
            while (listBeingOrdered.Items.Count != 0) {
                listBeingOrdered.Items.RemoveAt(0);
                await Task.Delay(intDelay);
            }
        }

        private void LimpiarBuckets() {
            //listBeingOrdered.Items.Clear();
            foreach (var i in buckets)
                i.Items.Clear();
        }

        private void RemoveBucketItem(ListBox listBox) {
            listBeingOrdered.Items.Add(listBox.Items[0]);
            listBox.Items.RemoveAt(0);
        }

        private void AddBucketItems(ListBox listBox, Queue<int> queues) {
            listBox.Items.Clear();
            foreach(var item in queues) {
                listBox.Items.Add(item);
            }
        }
        private void button1_Click(object sender, EventArgs e) {
            listBeingOrdered.Items.Clear();
            buckets = new ListBox[]{bucket0, bucket1
            ,bucket2, bucket3, bucket4, bucket5, bucket6, bucket7,
            bucket8, bucket9};
            RadixSortSimulado(  arregloBuckets);
        }

        private void numericDelay_Scroll(object sender, ScrollEventArgs e) {
            lblDelay.Text = $"Delay: {numericDelay.Value}";
        }

        private void numericDelay_ValueChanged(object sender, EventArgs e) {
            lblDelay.Text = $"Delay: {numericDelay.Value}";
        }

        private async void btnGenerarVersus_Click(object sender, EventArgs e) {

            listVersusNumeros.Items.Clear();
            listRadix.Items.Clear();
            listQuick.Items.Clear();

            Random random = new Random();

            int intCuantos = int.Parse(txtCtdVersus.Text.ToString());

            arregloVersus = new int[intCuantos];
            arregloVersusDos = new int[intCuantos];


            await LlenarLBoxVersus(random, arregloVersus);



            var reloj = System.Diagnostics.Stopwatch.StartNew();
            Sorting.RadixSort(ref arregloVersus);
            reloj.Stop();
            tiempoRadix.Text = $"Tiempo de ejecución: {reloj.Elapsed.TotalMilliseconds} ms";

            reloj.Restart();
            QuickSort(ref arregloVersusDos, 0 ,arregloVersusDos.Length-1);
            reloj.Stop();
            tiempoQuick.Text = $"Tiempo de ejecución: {reloj.Elapsed.TotalMilliseconds} ms";

            MessageBox.Show("Procediendo a llenado ...");

            for (int i = 0; i < intCuantos; i++) {
                listRadix.Items.Add(arregloVersus[i]);
                listQuick.Items.Add(arregloVersusDos[i]);
            }

        }


        private async Task LlenarLBoxVersus(Random random, int[] arregloVersus) {
            if (chkLongitudFija.Checked) {
                for (var i = 0; i < arregloVersus.Length; i++) {
                    arregloVersus[i] = random.Next(0, 10);
                    arregloVersusDos[i] = arregloVersus[i];
                   // await Task.Delay(1);
                    listVersusNumeros.Items.Add(arregloVersus[i]);
                }

            } else {
                for (var i = 0; i < arregloVersus.Length; i++) {
                    arregloVersus[i] = random.Next(0, int.MaxValue - 1);
                    arregloVersusDos[i] = arregloVersus[i];
                    await Task.Delay(1);
                    listVersusNumeros.Items.Add(arregloVersus[i]);
                }
            }
        }

    }
}
