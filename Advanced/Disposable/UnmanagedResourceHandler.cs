using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Disposable
{
    class UnmanagedResourceHandler : IDisposable
    {
        private Timer _timer;
            public UnmanagedResourceHandler()
        {
            _timer = new Timer(o => DoOnTick(o), null, 100, 100);
        }

        public void Start()
        {
            if (disposedValue == true)
                throw new ObjectDisposedException("UnmanagedResourceHandler");
        }


        private void DoOnTick(object obj)
        {
            System.Console.WriteLine("Tick.");
            Console.ReadLine();
        }

        #region IDisposable Support
        private bool disposedValue = false; // Для определения избыточных вызовов

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: освободить управляемое состояние (управляемые объекты).
                    _timer.Dispose();
                    _timer = null;
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить ниже метод завершения.
                // TODO: задать большим полям значение NULL.

                disposedValue = true;
            }
        }

        // TODO: переопределить метод завершения, только если Dispose(bool disposing) выше включает код для освобождения неуправляемых ресурсов.
        // ~UnmanagedResourceHandler()
        // {
        //   // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
        //   Dispose(false);
        // }

        // Этот код добавлен для правильной реализации шаблона высвобождаемого класса.
        public void Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
