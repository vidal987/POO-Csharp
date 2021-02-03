using System;


namespace ExecComposicao.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour  { get; set; }
        public int Hours { get; set; }
        public HourContract() { }

        public HourContract(DateTime data, double valuePerHour, int hours)
        {
            Date = data;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return
                 Hours * ValuePerHour;
        }
    }
}
