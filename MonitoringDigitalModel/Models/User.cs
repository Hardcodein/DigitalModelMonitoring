﻿

namespace MonitoringDigitalModel.Models;

public class User
{
    public int Id { get; set; }
    public Guid Guid { get; set; }

    public string Name { get; set; }

    public string Password { get; set; }
    public string Login { get; set; }
    public string Email { get; set; }


}
