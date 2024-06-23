namespace SchoolManagementApp.MVC.Data;
using Microsoft.AspNetCore.Mvc;

public class LecturerMetaData
{
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;
}

[ModelMetadataType(typeof(StudentMetaData))]
public partial class Lecturer{};