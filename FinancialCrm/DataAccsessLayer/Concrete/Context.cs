using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialCrm.DataAccsessLayer.Concrete
{
    /*
     * Ne için boş bir Context sınıfı var?
     Şimdi boş bir Context sınıfı oluşturduk. Bu sınıf, 
    Entity Framework'ün DbContext sınıfından türetilmiştir ve veritabanı işlemlerini yönetmek için kullanılır.
    
    Ama biz ado.net entity data Modeli kullanacağız.
    örneğin, veritabanı bağlantısı, tabloların tanımlanması ve diğer veritabanı işlemleri bu sınıf içinde yapılabilir.
    Bu sınıfı daha sonra genişletebiliriz ve veritabanı işlemlerini gerçekleştirmek için gerekli özellikleri ve 
    yöntemleri ekleyebiliriz.

     */
    // Entity Framework DbContext sınıfından türetilmiş boş bir sınıf
    // Bu sınıf, veritabanı işlemlerini yönetmek için kullanılabilir
    // Ancak şu anda içinde herhangi bir özellik veya yöntem tanımlanmamış
    //
    public class Context : FinancialCrmDbGuncelEntities
    {


    }

}