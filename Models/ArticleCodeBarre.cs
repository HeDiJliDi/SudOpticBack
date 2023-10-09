using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class ArticleCodeBarre
{
    public string CodeArticle { get; set; } = null!;

    public string CodeBarre { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public byte[] ImageCodeBarre { get; set; } = null!;

    public decimal PrixVenteTtc { get; set; }
}
