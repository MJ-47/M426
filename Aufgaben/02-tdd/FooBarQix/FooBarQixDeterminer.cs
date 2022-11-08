using System;
using Xunit;


namespace FooBarQix {
  public class FooBarQixDeterminer {

    
    public string Determine(int number) {
      string output = null;

      if (number % 3 == 0) {
        output += "Foo";
      }

      if (number % 5 == 0) {
        output += "Bar";
      }

      if (number % 7 == 0) {
        output += "Qix";
      }

      if (number % 3 != 0 && number % 5 != 0 && number % 7 != 0) output = number.ToString();

      return output;
    }
  }
}