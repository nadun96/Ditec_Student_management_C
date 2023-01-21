using System;
using System.Data;
using System.Data.SqlClient;



namespace DITEC
{
    public partial class FormRegister : Form
    {
        // coonnection object
        string gender = "";
        ListBox lb = new ListBox();


        public FormRegister()
        {
            InitializeComponent();

        }

        private void linkLabelLogout_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            FormLogin login = new FormLogin();
            login.Show();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
   
            // Create a new AutoCompleteStringCollection
            AutoCompleteStringCollection source = new();

            // Get the data from the database
            string connectionString = @"Data Source = (localdb)\ProjectModels; Initial Catalog = student; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                using SqlCommand command = new("SELECT regNo FROM student", connection);
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    source.Add(reader.GetInt32(0).ToString());
                }
            }

            // Set the autocomplete source of the TextBox
            textBoxRegNo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxRegNo.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxRegNo.AutoCompleteCustomSource = source;           

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try {

                string connectionString = @"Data Source = (localdb)\ProjectModels; Initial Catalog = student; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "INSERT INTO student (firstName, lastName , gender,dateOfBirth, address, email, mobilePhone, homePhone, parentName, nic, contactNo) VALUES (@firstName, @lastName, @gender, @dateOfBirth, @address, @email, @mobilePhone, @homePhone, @parentName, @nic, @contactNo)";
                        command.Parameters.AddWithValue("@firstName", textBoxFname.Text);
                        command.Parameters.AddWithValue("@lastName", textBoxLname.Text);
                        command.Parameters.AddWithValue("@gender", gender);
                        command.Parameters.AddWithValue("@dateOfBirth", dateTimePickerBdate.Value);
                        command.Parameters.AddWithValue("@address", textBoxAddress.Text);
                        command.Parameters.AddWithValue("@email", textBoxEmail.Text);
                        command.Parameters.AddWithValue("@mobilePhone", textBoxMobile.Text);
                        command.Parameters.AddWithValue("@homePhone", textBoxHome.Text);
                        command.Parameters.AddWithValue("@parentName", textBoxPname.Text);
                        command.Parameters.AddWithValue("@nic", textBoxNIC.Text);
                        command.Parameters.AddWithValue("@contactNo", textBoxContact.Text);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }


                var text =
                  "first name = " + textBoxFname.Text + Environment.NewLine +
                  "last name = " + textBoxLname.Text + Environment.NewLine +
                  "gender = " + gender + Environment.NewLine +
                  "birthday, value" + dateTimePickerBdate.Value + "text =" + dateTimePickerBdate.Value + Environment.NewLine +
                  "Address , text" + textBoxAddress.Text + Environment.NewLine +
                  "Email , text" + textBoxEmail.Text + Environment.NewLine +
                  "Mobile , text" + textBoxMobile.Text + Environment.NewLine +
                  "Home , text" + textBoxHome.Text + Environment.NewLine +
                  "Pname , text" + textBoxPname.Text + Environment.NewLine +
                  "NIC , text" + textBoxNIC.Text + Environment.NewLine +
                  "Contact , text" + textBoxContact.Text;


                  MessageBox.Show(text);

                DialogResult result = MessageBox.Show("Do you want Save ?", "Confirm", MessageBoxButtons.YesNo);
            
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Saving Complete !");
                
                    // info section
                    textBoxRegNo.Clear();
                    textBoxFname.Clear();
                    textBoxLname.Clear();
                    dateTimePickerBdate.Refresh();
                    radioButtonFemale.Checked = false;
                    radioButtonMale.Checked = false;
                
                    // contact
                    textBoxAddress.Clear();
                    textBoxEmail.Clear();
                    textBoxMobile.Clear();
                    textBoxHome.Clear();
                
                    // parent
                    textBoxPname.Clear();
                    textBoxContact.Clear();
                    textBoxNIC.Clear();

                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMale.Checked)
            {
                gender = "Male";
            }
            else if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }
        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMale.Checked)
            {
                gender = "Male";
            }
            else if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Claer ?", "Confirm", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                // info section
                textBoxRegNo.Clear();
                textBoxFname.Clear();
                textBoxLname.Clear();
                dateTimePickerBdate.Refresh();
                radioButtonFemale.Checked = false;
                radioButtonMale.Checked = false;

                // contact
                textBoxAddress.Clear();
                textBoxEmail.Clear();
                textBoxMobile.Clear();
                textBoxHome.Clear();

                // parent
                textBoxPname.Clear();
                textBoxContact.Clear();
                textBoxNIC.Clear();

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
            
        {
        
            DialogResult result = MessageBox.Show("Do you want to Delete ?", "Confirm", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string connectionString = @"Data Source = (localdb)\ProjectModels; Initial Catalog = student; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                string query = "DELETE FROM student WHERE regNo = @regNo";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int regNo;
                        if (!int.TryParse(textBoxRegNo.Text, out regNo))
                        {
                            // show error message or clear textboxes
                            return;
                        }
                        command.Parameters.AddWithValue("@regNo", regNo);
                        command.ExecuteNonQuery();
                        //clear textboxes
                        textBoxFname.Text = "";
                        textBoxLname.Text = "";
                        radioButtonMale.Checked = false;
                        radioButtonFemale.Checked = false;
                        dateTimePickerBdate.Value = DateTime.Now;
                        textBoxAddress.Text = "";
                        textBoxEmail.Text = "";
                        textBoxMobile.Text = "";
                        textBoxHome.Text = "";
                        textBoxPname.Text = "";
                        textBoxNIC.Text = "";
                        textBoxContact.Text = "";
                    }
                    connection.Close();
                }
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You SUre to Update!", "Confirm", MessageBoxButtons.YesNo);
            
            if(result == DialogResult.Yes)
            {

                var regNo = textBoxRegNo.Text;

                string connectionString = @"Data Source = (localdb)\ProjectModels; Initial Catalog = student; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "UPDATE student SET firstName = @firstName, lastName = @lastName, gender = @gender, dateOfBirth = @dateOfBirth, address = @address, email = @email, mobilePhone = @mobilePhone, homePhone = @homePhone, parentName = @parentName, nic = @nic, contactNo = @contactNo WHERE regNo = @regNo";
                        command.Parameters.AddWithValue("@firstName", textBoxFname.Text);
                        command.Parameters.AddWithValue("@lastName", textBoxLname.Text);
                        command.Parameters.AddWithValue("@gender", gender);
                        command.Parameters.AddWithValue("@dateOfBirth", dateTimePickerBdate.Value);
                        command.Parameters.AddWithValue("@address", textBoxAddress.Text);
                        command.Parameters.AddWithValue("@email", textBoxEmail.Text);
                        command.Parameters.AddWithValue("@mobilePhone", textBoxMobile.Text);
                        command.Parameters.AddWithValue("@homePhone", textBoxHome.Text);
                        command.Parameters.AddWithValue("@parentName", textBoxPname.Text);
                        command.Parameters.AddWithValue("@nic", textBoxNIC.Text);
                        command.Parameters.AddWithValue("@contactNo", textBoxContact.Text);
                        command.Parameters.AddWithValue("@regNo", regNo);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }


            }

        }
        
        private void groupBoxStudentRegistration_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxRegNo_TextChanged(object sender, EventArgs e)
        {
            string connectionString = @"Data Source = (localdb)\ProjectModels; Initial Catalog = student; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            string query = "SELECT firstName, lastName, gender, dateOfBirth, address, email, mobilePhone, homePhone, parentName, nic, contactNo FROM student WHERE regNo = @regNo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int regNo;
                    if (!int.TryParse(textBoxRegNo.Text, out regNo))
                    {
                        // show error message or clear textboxes
                        return;
                    }
                    command.Parameters.AddWithValue("@regNo", regNo);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBoxFname.Text = reader["firstName"].ToString();
                            textBoxLname.Text = reader["lastName"].ToString();
                            if ( reader["gender"].ToString() == "Male" ){
                                
                                    radioButtonMale.Checked = true;
                                
                            }
                            else{
                                    radioButtonFemale.Checked = true;
                                
                            }
                            
                            dateTimePickerBdate.Value = (DateTime)reader["dateOfBirth"];
                            textBoxAddress.Text = reader["address"].ToString();
                            textBoxEmail.Text = reader["email"].ToString();
                            textBoxMobile.Text = reader["mobilePhone"].ToString();
                            textBoxHome.Text = reader["homePhone"].ToString();
                            textBoxPname.Text = reader["parentName"].ToString();
                            textBoxNIC.Text = reader["nic"].ToString();
                            textBoxContact.Text = reader["contactNo"].ToString();
                        }
                    }
                }
                connection.Close();
            }

        }

    }
}
