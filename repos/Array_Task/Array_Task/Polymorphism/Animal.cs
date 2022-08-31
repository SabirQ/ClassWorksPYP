using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Task.Polymorphism
{
    public class Animal
    {
        public string Renk { get; set; }
        public string Tur { get; set; }
        public virtual string Ses() => "Default Ses"; 
    }
    public class Kedi:Animal{
        public override string Ses()
        {

            return "Kedi sesi";
        }
    }
    public class Kopek:Animal 
    { 

    }
    public class Kus : Animal
    {

    }
    public interface IService
    {

    }



}
