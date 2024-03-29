﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.FinalnyjjProekt
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Графики отпуска.
    /// </summary>
    // *** Start programmer edit section *** (ГрафикиОтпуска CustomAttributes)

    // *** End programmer edit section *** (ГрафикиОтпуска CustomAttributes)
    [AutoAltered()]
    [Caption("Графики отпуска")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ГрафикиОтпускаE", new string[] {
            "НомерДок as \'Номер документа\'",
            "Дата as \'Дата составления\'",
            "ДатаНач as \'Дата начала\'",
            "КолДней as \'Количество дней\'",
            "Отправлено as \'Отправлено\'",
            "Сотрудники as \'Сотрудники\'",
            "Сотрудники.Фамилия as \'Фамилия\'"}, Hidden=new string[] {
            "Сотрудники.Фамилия"})]
    [MasterViewDefineAttribute("ГрафикиОтпускаE", "Сотрудники", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Фамилия")]
    [View("ГрафикиОтпускаL", new string[] {
            "НомерДок as \'Номер документа\'",
            "Дата as \'Дата составления\'",
            "ДатаНач as \'Дата начала\'",
            "КолДней as \'Количество дней\'",
            "Отправлено as \'Отправлено\'",
            "Сотрудники.Фамилия as \'Фамилия\'"})]
    public class ГрафикиОтпуска : ICSSoft.STORMNET.DataObject
    {
        
        private int fНомерДок;
        
        private System.DateTime fДата = System.DateTime.Now;
        
        private System.DateTime fДатаНач;
        
        private bool fОтправлено = false;
        
        private int fКолДней;
        
        private IIS.FinalnyjjProekt.Сотрудники fСотрудники;
        
        // *** Start programmer edit section *** (ГрафикиОтпуска CustomMembers)

        // *** End programmer edit section *** (ГрафикиОтпуска CustomMembers)

        
        /// <summary>
        /// Дата.
        /// </summary>
        // *** Start programmer edit section *** (ГрафикиОтпуска.Дата CustomAttributes)

        // *** End programmer edit section *** (ГрафикиОтпуска.Дата CustomAttributes)
        public virtual System.DateTime Дата
        {
            get
            {
                // *** Start programmer edit section *** (ГрафикиОтпуска.Дата Get start)

                // *** End programmer edit section *** (ГрафикиОтпуска.Дата Get start)
                System.DateTime result = this.fДата;
                // *** Start programmer edit section *** (ГрафикиОтпуска.Дата Get end)

                // *** End programmer edit section *** (ГрафикиОтпуска.Дата Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ГрафикиОтпуска.Дата Set start)

                // *** End programmer edit section *** (ГрафикиОтпуска.Дата Set start)
                this.fДата = value;
                // *** Start programmer edit section *** (ГрафикиОтпуска.Дата Set end)

                // *** End programmer edit section *** (ГрафикиОтпуска.Дата Set end)
            }
        }
        
        /// <summary>
        /// ДатаНач.
        /// </summary>
        // *** Start programmer edit section *** (ГрафикиОтпуска.ДатаНач CustomAttributes)

        // *** End programmer edit section *** (ГрафикиОтпуска.ДатаНач CustomAttributes)
        [NotNull()]
        public virtual System.DateTime ДатаНач
        {
            get
            {
                // *** Start programmer edit section *** (ГрафикиОтпуска.ДатаНач Get start)

                // *** End programmer edit section *** (ГрафикиОтпуска.ДатаНач Get start)
                System.DateTime result = this.fДатаНач;
                // *** Start programmer edit section *** (ГрафикиОтпуска.ДатаНач Get end)

                // *** End programmer edit section *** (ГрафикиОтпуска.ДатаНач Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ГрафикиОтпуска.ДатаНач Set start)

                // *** End programmer edit section *** (ГрафикиОтпуска.ДатаНач Set start)
                this.fДатаНач = value;
                // *** Start programmer edit section *** (ГрафикиОтпуска.ДатаНач Set end)

                // *** End programmer edit section *** (ГрафикиОтпуска.ДатаНач Set end)
            }
        }
        
        /// <summary>
        /// КолДней.
        /// </summary>
        // *** Start programmer edit section *** (ГрафикиОтпуска.КолДней CustomAttributes)

        // *** End programmer edit section *** (ГрафикиОтпуска.КолДней CustomAttributes)
        [NotNull()]
        public virtual int КолДней
        {
            get
            {
                // *** Start programmer edit section *** (ГрафикиОтпуска.КолДней Get start)

                // *** End programmer edit section *** (ГрафикиОтпуска.КолДней Get start)
                int result = this.fКолДней;
                // *** Start programmer edit section *** (ГрафикиОтпуска.КолДней Get end)

                // *** End programmer edit section *** (ГрафикиОтпуска.КолДней Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ГрафикиОтпуска.КолДней Set start)

                // *** End programmer edit section *** (ГрафикиОтпуска.КолДней Set start)
                this.fКолДней = value;
                // *** Start programmer edit section *** (ГрафикиОтпуска.КолДней Set end)

                // *** End programmer edit section *** (ГрафикиОтпуска.КолДней Set end)
            }
        }
        
        /// <summary>
        /// НомерДок.
        /// </summary>
        // *** Start programmer edit section *** (ГрафикиОтпуска.НомерДок CustomAttributes)

        // *** End programmer edit section *** (ГрафикиОтпуска.НомерДок CustomAttributes)
        [NotNull()]
        public virtual int НомерДок
        {
            get
            {
                // *** Start programmer edit section *** (ГрафикиОтпуска.НомерДок Get start)

                // *** End programmer edit section *** (ГрафикиОтпуска.НомерДок Get start)
                int result = this.fНомерДок;
                // *** Start programmer edit section *** (ГрафикиОтпуска.НомерДок Get end)

                // *** End programmer edit section *** (ГрафикиОтпуска.НомерДок Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ГрафикиОтпуска.НомерДок Set start)

                // *** End programmer edit section *** (ГрафикиОтпуска.НомерДок Set start)
                this.fНомерДок = value;
                // *** Start programmer edit section *** (ГрафикиОтпуска.НомерДок Set end)

                // *** End programmer edit section *** (ГрафикиОтпуска.НомерДок Set end)
            }
        }
        
        /// <summary>
        /// Отправлено.
        /// </summary>
        // *** Start programmer edit section *** (ГрафикиОтпуска.Отправлено CustomAttributes)

        // *** End programmer edit section *** (ГрафикиОтпуска.Отправлено CustomAttributes)
        public virtual bool Отправлено
        {
            get
            {
                // *** Start programmer edit section *** (ГрафикиОтпуска.Отправлено Get start)

                // *** End programmer edit section *** (ГрафикиОтпуска.Отправлено Get start)
                bool result = this.fОтправлено;
                // *** Start programmer edit section *** (ГрафикиОтпуска.Отправлено Get end)

                // *** End programmer edit section *** (ГрафикиОтпуска.Отправлено Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ГрафикиОтпуска.Отправлено Set start)

                // *** End programmer edit section *** (ГрафикиОтпуска.Отправлено Set start)
                this.fОтправлено = value;
                // *** Start programmer edit section *** (ГрафикиОтпуска.Отправлено Set end)

                // *** End programmer edit section *** (ГрафикиОтпуска.Отправлено Set end)
            }
        }
        
        /// <summary>
        /// Графики отпуска.
        /// </summary>
        // *** Start programmer edit section *** (ГрафикиОтпуска.Сотрудники CustomAttributes)

        // *** End programmer edit section *** (ГрафикиОтпуска.Сотрудники CustomAttributes)
        [PropertyStorage(new string[] {
                "Сотрудники"})]
        [NotNull()]
        public virtual IIS.FinalnyjjProekt.Сотрудники Сотрудники
        {
            get
            {
                // *** Start programmer edit section *** (ГрафикиОтпуска.Сотрудники Get start)

                // *** End programmer edit section *** (ГрафикиОтпуска.Сотрудники Get start)
                IIS.FinalnyjjProekt.Сотрудники result = this.fСотрудники;
                // *** Start programmer edit section *** (ГрафикиОтпуска.Сотрудники Get end)

                // *** End programmer edit section *** (ГрафикиОтпуска.Сотрудники Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ГрафикиОтпуска.Сотрудники Set start)

                // *** End programmer edit section *** (ГрафикиОтпуска.Сотрудники Set start)
                this.fСотрудники = value;
                // *** Start programmer edit section *** (ГрафикиОтпуска.Сотрудники Set end)

                // *** End programmer edit section *** (ГрафикиОтпуска.Сотрудники Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ГрафикиОтпускаE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ГрафикиОтпускаE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ГрафикиОтпускаE", typeof(IIS.FinalnyjjProekt.ГрафикиОтпуска));
                }
            }
            
            /// <summary>
            /// "ГрафикиОтпускаL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ГрафикиОтпускаL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ГрафикиОтпускаL", typeof(IIS.FinalnyjjProekt.ГрафикиОтпуска));
                }
            }
        }
    }
}
