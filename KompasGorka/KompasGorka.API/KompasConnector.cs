using System;
using Kompas6API5;
using Kompas6Constants3D;

namespace KompasGorka.API
{
    /// <summary>
    ///     Класс используется для подключения
    ///     к САПР Компас 3Д.
    /// </summary>
    public class KompasConnector
    {
        /// <summary>
        ///     Документ Компас 3D.
        /// </summary>
        private ksDocument3D _doc3D;

        /// <summary>
        ///     Главный обьект Компас 3D.
        /// </summary>
        private KompasObject _kompas;

        /// <summary>
        ///     Конструктор класса.
        /// </summary>
        public KompasConnector()
        {
            ConnectToKompas();
        }

        /// <summary>
        ///     Интерфейс компонента.
        /// </summary>
        public ksPart Part { get; set; }

        /// <summary>
        ///     Включает и подключает Компас 3D.
        /// </summary>
        private void ConnectToKompas()
        {
            var t = Type.GetTypeFromProgID("KOMPAS.Application.5");

            _kompas = (KompasObject) Activator.CreateInstance(t);

            _kompas.Visible = true;

            _kompas.ActivateControllerAPI();
        }

        /// <summary>
        ///     Создает новый документ.
        /// </summary>
        public void NewDocument()
        {
            _doc3D = (ksDocument3D) _kompas.Document3D();

            _doc3D.Create();

            Part = (ksPart) _doc3D.GetPart((short) Part_Type.pTop_Part);
        }
    }
}