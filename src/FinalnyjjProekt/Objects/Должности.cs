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
    /// Должности.
    /// </summary>
    // *** Start programmer edit section *** (Должности CustomAttributes)

    // *** End programmer edit section *** (Должности CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ДолжностиE", new string[] {
            "КодДол as \'Код должности\'",
            "Наименование as \'Наименование\'"})]
    [View("ДолжностиL", new string[] {
            "КодДол as \'Код должности\'",
            "Наименование as \'Наименование\'"})]
    public class Должности : ICSSoft.STORMNET.DataObject
    {
        
        private int fКодДол;
        
        private string fНаименование;
        
        // *** Start programmer edit section *** (Должности CustomMembers)

        // *** End programmer edit section *** (Должности CustomMembers)

        
        /// <summary>
        /// КодДол.
        /// </summary>
        // *** Start programmer edit section *** (Должности.КодДол CustomAttributes)

        // *** End programmer edit section *** (Должности.КодДол CustomAttributes)
        [NotNull()]
        public virtual int КодДол
        {
            get
            {
                // *** Start programmer edit section *** (Должности.КодДол Get start)

                // *** End programmer edit section *** (Должности.КодДол Get start)
                int result = this.fКодДол;
                // *** Start programmer edit section *** (Должности.КодДол Get end)

                // *** End programmer edit section *** (Должности.КодДол Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Должности.КодДол Set start)

                // *** End programmer edit section *** (Должности.КодДол Set start)
                this.fКодДол = value;
                // *** Start programmer edit section *** (Должности.КодДол Set end)

                // *** End programmer edit section *** (Должности.КодДол Set end)
            }
        }
        
        /// <summary>
        /// Наименование.
        /// </summary>
        // *** Start programmer edit section *** (Должности.Наименование CustomAttributes)

        // *** End programmer edit section *** (Должности.Наименование CustomAttributes)
        [StrLen(255)]
        [NotNull()]
        public virtual string Наименование
        {
            get
            {
                // *** Start programmer edit section *** (Должности.Наименование Get start)

                // *** End programmer edit section *** (Должности.Наименование Get start)
                string result = this.fНаименование;
                // *** Start programmer edit section *** (Должности.Наименование Get end)

                // *** End programmer edit section *** (Должности.Наименование Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Должности.Наименование Set start)

                // *** End programmer edit section *** (Должности.Наименование Set start)
                this.fНаименование = value;
                // *** Start programmer edit section *** (Должности.Наименование Set end)

                // *** End programmer edit section *** (Должности.Наименование Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ДолжностиE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ДолжностиE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ДолжностиE", typeof(IIS.FinalnyjjProekt.Должности));
                }
            }
            
            /// <summary>
            /// "ДолжностиL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ДолжностиL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ДолжностиL", typeof(IIS.FinalnyjjProekt.Должности));
                }
            }
        }
    }
}
