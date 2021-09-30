using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBlazor
{
    internal class AppState
    {
        public int Counter { get; private set; } = 0;

        public event EventHandler<int> CounterChanged;

        public void IncrementCounter()
        {
            Counter++;
            CounterChanged?.Invoke(this, Counter);
        }
    }
}
