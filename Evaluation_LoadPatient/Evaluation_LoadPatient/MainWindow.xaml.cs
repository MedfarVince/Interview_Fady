using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Evaluation_LoadPatient
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void button_Click(object sender, RoutedEventArgs e)
    {
      //Do our stuff here
	    List<Patient> patients = GetPatients(this.textBox.Text);

	    foreach (var patient in patients)
	    {
		    InjectPatient(patient, "DataBase");
	    }
    }

	  private void InjectPatient(Patient patient, string DataBase)
	  {
		  throw new NotImplementedException("To Do");
	  }

	  private List<Patient> GetPatients(string textBoxText)
	  {
		  throw new NotImplementedException("To Do");
	  }
  }

	internal class Patient
	{
		public string FirstName;
		public string LastName;
	}
}
