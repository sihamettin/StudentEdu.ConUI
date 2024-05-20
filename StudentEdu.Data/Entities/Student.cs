using System;

namespace StudentEdu.Data

{
    public class Student
    {

        public int StudentId { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public Nullable<bool> Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreaDate { get; set; }//01 01 19000-> NULL



    }

    // CLASS MAPPING: VERİ TİPİ DEĞİŞKEN ADI , BOŞ GEÇİLİP GEÇİLEMEDĞİ BU ÜÇ ÖZELLİK BİR ARAYA
    // GELİNCE MAPPING TAMAMLANMIŞ OLUR..
    // database tablolualarının c# tarafındaki karşılığına entity deriz
    /* normal şartlar altında hiçbir zaman null değer almaz taki biz null able yapana kadar
    byte
    int
    short
    long
    float double decimal
    bool
    datetiem 
    null değer almasını istiyorsak veritürü? şeklinde yaparız.
    Nullable<veritürü> bu şekilde yaparız.

    string kendiliğinden nullable ozelliği vardır.
    */
}
