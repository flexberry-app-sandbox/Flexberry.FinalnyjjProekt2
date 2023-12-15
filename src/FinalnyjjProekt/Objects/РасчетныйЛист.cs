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
    /// Расчетный лист.
    /// </summary>
    // *** Start programmer edit section *** (РасчетныйЛист CustomAttributes)

    // *** End programmer edit section *** (РасчетныйЛист CustomAttributes)
    [AutoAltered()]
    [Caption("Расчетный лист")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("РасчетныйЛистE", new string[] {
            "НомерДок as \'Номер документа\'",
            "Дата as \'Дата составления\'",
            "Отправлено as \'Отправлено\'",
            "Сотрудники as \'Сотрудники\'",
            "Сотрудники.Фамилия as \'Фамилия\'"}, Hidden=new string[] {
            "Сотрудники.Фамилия"})]
    [AssociatedDetailViewAttribute("РасчетныйЛистE", "СоставРасчета", "СоставРасчетаE", true, "", "Состав расчета", true, new string[] {
            ""})]
    [MasterViewDefineAttribute("РасчетныйЛистE", "Сотрудники", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Фамилия")]
    [View("РасчетныйЛистL", new string[] {
            "НомерДок as \'Номер документа\'",
            "Дата as \'Дата составления\'",
            "Отправлено as \'Отправлено\'",
            "Сотрудники.Фамилия as \'Фамилия\'"})]
    public class РасчетныйЛист : ICSSoft.STORMNET.DataObject
    {
        
        private int fНомерДок;
        
        private System.DateTime fДата = System.DateTime.Now;
        
        private bool fОтправлено = false;
        
        private IIS.FinalnyjjProekt.Сотрудники fСотрудники;
        
        private IIS.FinalnyjjProekt.DetailArrayOfСоставРасчета fСоставРасчета;
        
        // *** Start programmer edit section *** (РасчетныйЛист CustomMembers)

        // *** End programmer edit section *** (РасчетныйЛист CustomMembers)

        
        /// <summary>
        /// Дата.
        /// </summary>
        // *** Start programmer edit section *** (РасчетныйЛист.Дата CustomAttributes)

        // *** End programmer edit section *** (РасчетныйЛист.Дата CustomAttributes)
        public virtual System.DateTime Дата
        {
            get
            {
                // *** Start programmer edit section *** (РасчетныйЛист.Дата Get start)

                // *** End programmer edit section *** (РасчетныйЛист.Дата Get start)
                System.DateTime result = this.fДата;
                // *** Start programmer edit section *** (РасчетныйЛист.Дата Get end)

                // *** End programmer edit section *** (РасчетныйЛист.Дата Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РасчетныйЛист.Дата Set start)

                // *** End programmer edit section *** (РасчетныйЛист.Дата Set start)
                this.fДата = value;
                // *** Start programmer edit section *** (РасчетныйЛист.Дата Set end)

                // *** End programmer edit section *** (РасчетныйЛист.Дата Set end)
            }
        }
        
        /// <summary>
        /// НомерДок.
        /// </summary>
        // *** Start programmer edit section *** (РасчетныйЛист.НомерДок CustomAttributes)

        // *** End programmer edit section *** (РасчетныйЛист.НомерДок CustomAttributes)
        [NotNull()]
        public virtual int НомерДок
        {
            get
            {
                // *** Start programmer edit section *** (РасчетныйЛист.НомерДок Get start)

                // *** End programmer edit section *** (РасчетныйЛист.НомерДок Get start)
                int result = this.fНомерДок;
                // *** Start programmer edit section *** (РасчетныйЛист.НомерДок Get end)

                // *** End programmer edit section *** (РасчетныйЛист.НомерДок Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РасчетныйЛист.НомерДок Set start)

                // *** End programmer edit section *** (РасчетныйЛист.НомерДок Set start)
                this.fНомерДок = value;
                // *** Start programmer edit section *** (РасчетныйЛист.НомерДок Set end)

                // *** End programmer edit section *** (РасчетныйЛист.НомерДок Set end)
            }
        }
        
        /// <summary>
        /// Отправлено.
        /// </summary>
        // *** Start programmer edit section *** (РасчетныйЛист.Отправлено CustomAttributes)

        // *** End programmer edit section *** (РасчетныйЛист.Отправлено CustomAttributes)
        public virtual bool Отправлено
        {
            get
            {
                // *** Start programmer edit section *** (РасчетныйЛист.Отправлено Get start)

                // *** End programmer edit section *** (РасчетныйЛист.Отправлено Get start)
                bool result = this.fОтправлено;
                // *** Start programmer edit section *** (РасчетныйЛист.Отправлено Get end)

                // *** End programmer edit section *** (РасчетныйЛист.Отправлено Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РасчетныйЛист.Отправлено Set start)

                // *** End programmer edit section *** (РасчетныйЛист.Отправлено Set start)
                this.fОтправлено = value;
                // *** Start programmer edit section *** (РасчетныйЛист.Отправлено Set end)

                // *** End programmer edit section *** (РасчетныйЛист.Отправлено Set end)
            }
        }
        
        /// <summary>
        /// Расчетный лист.
        /// </summary>
        // *** Start programmer edit section *** (РасчетныйЛист.Сотрудники CustomAttributes)

        // *** End programmer edit section *** (РасчетныйЛист.Сотрудники CustomAttributes)
        [PropertyStorage(new string[] {
                "Сотрудники"})]
        [NotNull()]
        public virtual IIS.FinalnyjjProekt.Сотрудники Сотрудники
        {
            get
            {
                // *** Start programmer edit section *** (РасчетныйЛист.Сотрудники Get start)

                // *** End programmer edit section *** (РасчетныйЛист.Сотрудники Get start)
                IIS.FinalnyjjProekt.Сотрудники result = this.fСотрудники;
                // *** Start programmer edit section *** (РасчетныйЛист.Сотрудники Get end)

                // *** End programmer edit section *** (РасчетныйЛист.Сотрудники Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РасчетныйЛист.Сотрудники Set start)

                // *** End programmer edit section *** (РасчетныйЛист.Сотрудники Set start)
                this.fСотрудники = value;
                // *** Start programmer edit section *** (РасчетныйЛист.Сотрудники Set end)

                // *** End programmer edit section *** (РасчетныйЛист.Сотрудники Set end)
            }
        }
        
        /// <summary>
        /// Расчетный лист.
        /// </summary>
        // *** Start programmer edit section *** (РасчетныйЛист.СоставРасчета CustomAttributes)

        // *** End programmer edit section *** (РасчетныйЛист.СоставРасчета CustomAttributes)
        public virtual IIS.FinalnyjjProekt.DetailArrayOfСоставРасчета СоставРасчета
        {
            get
            {
                // *** Start programmer edit section *** (РасчетныйЛист.СоставРасчета Get start)

                // *** End programmer edit section *** (РасчетныйЛист.СоставРасчета Get start)
                if ((this.fСоставРасчета == null))
                {
                    this.fСоставРасчета = new IIS.FinalnyjjProekt.DetailArrayOfСоставРасчета(this);
                }
                IIS.FinalnyjjProekt.DetailArrayOfСоставРасчета result = this.fСоставРасчета;
                // *** Start programmer edit section *** (РасчетныйЛист.СоставРасчета Get end)

                // *** End programmer edit section *** (РасчетныйЛист.СоставРасчета Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РасчетныйЛист.СоставРасчета Set start)

                // *** End programmer edit section *** (РасчетныйЛист.СоставРасчета Set start)
                this.fСоставРасчета = value;
                // *** Start programmer edit section *** (РасчетныйЛист.СоставРасчета Set end)

                // *** End programmer edit section *** (РасчетныйЛист.СоставРасчета Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "РасчетныйЛистE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View РасчетныйЛистE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("РасчетныйЛистE", typeof(IIS.FinalnyjjProekt.РасчетныйЛист));
                }
            }
            
            /// <summary>
            /// "РасчетныйЛистL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View РасчетныйЛистL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("РасчетныйЛистL", typeof(IIS.FinalnyjjProekt.РасчетныйЛист));
                }
            }
        }
    }
}
