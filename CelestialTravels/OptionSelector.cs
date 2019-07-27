using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CelestialTravels
{
    public class OptionSelector
    {
        public T GetOption<T>(List<T> options) where T : IOption
        {
            Console.WriteLine($"Please select one:");

            foreach (var option in options)
            {
                Console.WriteLine($"{option.Id}. {option.Name}");
            }

            // check cast
            var optionId = int.Parse(Console.ReadLine());

            // check that option actually exists and ask for new input if not

            ////foreach (var opt in options) {
            ////    if(opt.Id == optionId) {
            ////        return opt;
            ////    }
            ////}

            return options.Single(opt => opt.Id == optionId);
        }
    }
}
