using System;
using System.Collections.Generic;
using System.Collections;
namespace hayvanatyonetim
{
    class Program
    {
        static void Main(string[] args)
        {
            atlar at=new();
            at.getFeedSchedule();

        }
    }
    public abstract class hayvanlar
    {
        public string yas;
        public string agirlik;
        public virtual void getDosage()
        {

        }
        public virtual void getFeedSchedule()
        {

        }
    }
    public class atlar:hayvanlar
    {
        public string tur="atlar";
        public override void getDosage()
        {
            Console.WriteLine("haftada 1 doz");
        }
        public override void getFeedSchedule()
        {
            Console.WriteLine("günde 2 balya saman");
        }
    }
    public class kedigillerlar:hayvanlar
    {
        public string tur="kedigiller";
        public override void getDosage()
        {
            Console.WriteLine("haftada 2 doz");
        }
        public override void getFeedSchedule()
        {
            Console.WriteLine("günde 5 kg kemikli et");
        }
    }
    public class kemirgenler:hayvanlar
    {
        public string tur="kemirgenler";
        public override void getDosage()
        {
            Console.WriteLine("haftada 3 doz");
        }
        public override void getFeedSchedule()
        {
            Console.WriteLine("günde 1 kg bugday");
        }
    }
}