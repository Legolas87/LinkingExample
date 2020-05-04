using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LinkingExample
{
  // Learn more about making custom code visible in the Xamarin.Forms previewer
  // by visiting https://aka.ms/xamarinforms-previewer
  [DesignTimeVisible(false)]
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
      //ClassLibrary1.Class1 f = new ClassLibrary1.Class1();
     //var s = f.GetType().Name;

      var z = nameof(ClassLibrary1.Class1);

      var t = Type.GetType("ClassLibrary1.Class1, ClassLibrary1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"); 
      var instance = Activator.CreateInstance(t);

      MethodInfo methodInfo = t.GetMethods().FirstOrDefault(x => x.Name == "ff");

     
      DisplayAlert("", methodInfo.Invoke(instance,null).ToString(), "ok");
    }
  }
}
