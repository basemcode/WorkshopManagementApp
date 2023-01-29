using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManagement.Helpers;

public static class Utilities
{
    public static bool FormIsOpen(string name)
    {
        var openForms=Application.OpenForms.Cast<Form>();
        var isOpen=openForms.Any(x => x.Name == name);
        return isOpen;
    }
    public static void OpenForm<T,U>(U mdiParent) where T : new() 
    {
        T newForm = new T();
       
    }
}
