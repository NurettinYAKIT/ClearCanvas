﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:2.0.50727.5485
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.Desktop.Explorer {
    using System;
    
    
    /// <summary>
    ///   Yerelleştirilmiş dizeleri aramak gibi işlemler için, türü kesin olarak belirtilmiş kaynak sınıfı.
    /// </summary>
    // Bu sınıf ResGen veya Visual Studio gibi bir araç kullanılarak StronglyTypedResourceBuilder
    // sınıfı tarafından otomatik olarak oluşturuldu.
    // Üye eklemek veya kaldırmak için .ResX dosyanızı düzenleyin ve sonra da ResGen
    // komutunu /str seçeneğiyle yeniden çalıştırın veya VS projenizi yeniden oluşturun.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class SR {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SR() {
        }
        
        /// <summary>
        ///   Bu sınıf tarafından kullanılan, önbelleğe alınmış ResourceManager örneğini döndürür.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ClearCanvas.Desktop.Explorer.SR", typeof(SR).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Bu türü kesin olarak belirtilmiş kaynak sınıfını kullanarak geçerli iş parçacığının
        ///   CurrentUICulture özelliğini tüm kaynak aramaları için geçersiz kılar.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Shows the Explorer, allowing access to studies in the DICOM store and local file system. benzeri yerelleştirilmiş bir dize arar.
        /// </summary>
        public static string DescriptionExplorer {
            get {
                return ResourceManager.GetString("DescriptionExplorer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Explorer benzeri yerelleştirilmiş bir dize arar.
        /// </summary>
        public static string MenuExplorer {
            get {
                return ResourceManager.GetString("MenuExplorer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Explorer benzeri yerelleştirilmiş bir dize arar.
        /// </summary>
        public static string PathExplorer {
            get {
                return ResourceManager.GetString("PathExplorer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Explorer benzeri yerelleştirilmiş bir dize arar.
        /// </summary>
        public static string TitleExplorer {
            get {
                return ResourceManager.GetString("TitleExplorer", resourceCulture);
            }
        }
    }
}
