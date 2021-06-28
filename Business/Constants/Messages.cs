using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string GetAllAdmin = "Bütün admin kullanıcıları listelendi";
        public static string AdminAdded = "Yeni admin eklendi";
        public static string AdminUpdated = "Admin güncellendi";
        public static string AdminDeleted = "Admin silindi";
        public static string ListedCourses = "Bütün Kurslar Listelendi";
        public static string AddedCourse = "Yeni kurs eklendi";
        public static string UpdatedCourse = "Kurs güncellendi";
        public static string DeletedCourse = "Kurs silindi";
        public static string AddedStudent = "Öğrenci eklendi";
        public static string UpdatedStudent = "Öğrenci güncellendi";
        public static string DeletedStudent = "Öğrenci silindi";
        public static string ListedStudent = "Öğrenciler listelendi";
        public static string AddedTeacher = "Öğretmen eklendi";
        public static string UpdatedTeacher = "Öğretmen güncellendi";
        public static string DeletedTeacher = "Öğretmen silindi";
        public static string ListedTeacher = "Öğretmenler listelendi";
        public static string AdminCountExceeded = "10 dan fazla admin eklenemez";
        public static string StudentCountLessThan = "Öğrenci sayısı 10 dan az bu yüzden yeni kurs eklenemez";
        public static string UserRegistered ="Kullanıcı kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola yanlış";
        public static string SuccessfulLogin = "Login olundu";
        public static string UserAlreadyExists = "Kullanıcı mecvut";
        public static string AccessTokenCreated = "Token oluşturuldu";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string StudentCourseDetailListed = "Öğrenci Kurs Detayları Listelendi";
        public static string AddedCourseDetail = "Kurs Detayı Eklendi";
        public static string UpdatedCourseDetail = "Kurs Detayı Güncellendi";
        public static string ListedCourseDetail = "Kurs Detayı Listelendi";
    }
}
