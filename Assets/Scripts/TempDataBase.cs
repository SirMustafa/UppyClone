using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "Database")]
public class TempDataBase : ScriptableObject
{
    public string Username { get; private set; }
    private string passwordHash;

    public TempDataBase(string username, string password)
    {
        Username = username;
        passwordHash = HashPassword(password);
    }

    private string HashPassword(string password)
    {
        using (var sha256 = System.Security.Cryptography.SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            return BitConverter.ToString(bytes).Replace("-", "").ToLower();
        }
    }

    public bool VerifyPassword(string password)
    {
        return passwordHash == HashPassword(password);
    }
}