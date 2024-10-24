﻿using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Library
{
    public partial class AdminDeleteUser : Form
    {
        private string jsonFilePath;

        public AdminDeleteUser()
        {
            InitializeComponent();

            // Set the path to the users.json file
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            jsonFilePath = Path.Combine(baseDirectory, "Data", "users.json");
        }

        // This method is triggered when the form loads
        private void AdminDeleteUser_Load(object sender, EventArgs e)
        {
            // Optionally, you can add any initialization logic here
        }

        // Confirm Button Click (buttonConfirm) - Deletes user by ID
        private void button4_Click(object sender, EventArgs e)
        {
            // Get the user ID entered by the admin
            string userId = textBox1.Text.Trim();

            // Check if user ID is entered
            if (string.IsNullOrEmpty(userId))
            {
                MessageBox.Show("Please enter a User ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Attempt to delete the user by the entered ID
            try
            {
                bool isDeleted = DeleteUserById(userId);

                if (isDeleted)
                {
                    MessageBox.Show($"User with ID {userId} has been successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear(); // Clear the input after success
                }
                else
                {
                    MessageBox.Show($"No user found with ID {userId}.", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Back Button Click - Return to the previous form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form
        }

        // Method to delete a user by ID from the JSON file
        private bool DeleteUserById(string userId)
        {
            // Read the existing JSON data
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                var usersList = JsonConvert.DeserializeObject<List<User>>(json) ?? [];

                // Check if the user exists in the list
                var userToDelete = usersList.FirstOrDefault(u => u.UserID.ToString() == userId);
                if (userToDelete != null)
                {
                    // Remove the user from the list
                    usersList.Remove(userToDelete);

                    // Write the updated list back to the JSON file
                    string updatedJson = JsonConvert.SerializeObject(usersList, Formatting.Indented);
                    File.WriteAllText(jsonFilePath, updatedJson);

                    return true; // User was successfully deleted
                }
            }
            return false; // No user found with the given ID
        }

        // User class (matching the JSON structure)
        public class User
        {
            public int UserID { get; set; }
            public string Username { get; set; } = string.Empty;
            public string Password { get; set; } = string.Empty;
            public string Role { get; set; } = string.Empty;
        }
    }
}
