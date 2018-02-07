using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algortimiek_CircusTrein
{
    public partial class CircusTrein : Form
    {
        List<Animal> Animals = new List<Animal>();
        Train mainTrain = new Train();

        public CircusTrein()
        {
            InitializeComponent();

            CbbFormaat.DataSource = Enum.GetValues(typeof(AnimalSizes));
            CbbEetSoort.DataSource = Enum.GetValues(typeof(EatingOptions));
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = TbNaam.Text; // getting the name of the new animal
                Enum.TryParse(CbbFormaat.SelectedValue.ToString(), out AnimalSizes size); // getting selected size of the new animal 
                Enum.TryParse(CbbEetSoort.SelectedValue.ToString(), out EatingOptions eatingKind); // getting selected eating kind of the new animal

                Animal newAnimal = new Animal(name, eatingKind, size);
                Animals.Add(newAnimal); // add animal to list of all animals

                ListViewItem lvi = new ListViewItem();
                lvi.Text = name;
                lvi.SubItems.Add(newAnimal.AnimalSize.ToString());
                lvi.SubItems.Add(newAnimal.EatOption.ToString());
                lvi.SubItems.Add(newAnimal.Points.ToString());
                lvi.Tag = newAnimal;

                LvAnimals.Items.Add(lvi);

                // Resize Columns when adding items 
                LvAnimals.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                LvAnimals.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //Animals.Sort((x, y) => -1* x.Points.CompareTo(y.Points));

            foreach (var animal in Animals)
            {
                mainTrain.AddAnimalToTrain(animal);
            }

            foreach (TrainWagon wagon in mainTrain.wagonList) // fill in the data fields on the right side of the form.
            {

                LbWagons.Items.Add($"{wagon.AnimalsInJoint.Count} dieren in wagon id: {wagon.ID}");
                foreach (Animal animal in wagon.AnimalsInJoint)
                {
                    LbAntimalsInWagon.Items.Add($"{animal.Name} | {animal.AnimalSize} | {animal.EatOption} | {animal.Points} - wagon id: {wagon.ID}");
                }
            }
        }
    }

    public enum AnimalSizes
    {
        Klein,
        Middel,
        Groot
    }

    public enum EatingOptions
    {
        Planten,
        Vlees
    }
}
