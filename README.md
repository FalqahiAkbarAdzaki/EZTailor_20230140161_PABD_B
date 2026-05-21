IMPLEMENTASI SQL INJECTION PADA APLIKASI EZTAILOR
Latar Belakang

SQL Injection merupakan salah satu jenis serangan pada database yang memanfaatkan kelemahan query SQL yang dibuat tanpa validasi atau parameterized query. Serangan ini memungkinkan pengguna memasukkan perintah SQL tambahan melalui input aplikasi.

Pada aplikasi EZTailor, implementasi SQL Injection dilakukan pada fitur pencarian pelanggan sebagai simulasi pembelajaran keamanan database.

Implementasi SQL Injection

SQL Injection diterapkan pada tombol pencarian vulnerable (btnCariVulnerable) dengan menggunakan query yang menggabungkan input user secara langsung ke dalam string SQL.

Kode Vulnerable Query
private void btnCariVulnerable_Click(
    object sender,
    EventArgs e)
{
    SqlDataAdapter da =
        new SqlDataAdapter(
        "SELECT * FROM Pelanggan WHERE nama='"
        + txtCari.Text + "'",
        conn);

    DataTable dt =
        new DataTable();

    da.Fill(dt);

    dataGridView1.DataSource = dt;
}

Pada kode tersebut, nilai dari txtCari.Text langsung digabungkan ke query SQL tanpa menggunakan parameter.

Skenario SQL Injection
Percobaan Normal

User memasukkan:

Andi

Maka query yang dijalankan:

SELECT * FROM Pelanggan
WHERE nama='Andi'

Hasil:

Sistem hanya menampilkan data pelanggan bernama Andi.
Percobaan SQL Injection

User memasukkan payload:

' OR '1'='1

Maka query berubah menjadi:

SELECT * FROM Pelanggan
WHERE nama='' OR '1'='1'

Karena kondisi:

'1'='1'

selalu bernilai TRUE, maka seluruh data pelanggan pada database akan ditampilkan.

Dampak SQL Injection

SQL Injection dapat menyebabkan beberapa masalah keamanan, antara lain:

Kebocoran data database
Bypass validasi sistem
Manipulasi data
Penghapusan data database
Pengambilalihan akses sistem

Pada implementasi ini, SQL Injection digunakan hanya untuk simulasi pembelajaran dan tidak digunakan untuk tindakan merusak database.

Pencegahan SQL Injection

Untuk mencegah SQL Injection, aplikasi EZTailor menggunakan:

Stored Procedure
Parameterized Query

Contoh query aman:

SqlDataAdapter da =
    new SqlDataAdapter(
        "sp_SearchPelanggan",
        conn);

da.SelectCommand.CommandType =
    CommandType.StoredProcedure;

da.SelectCommand.Parameters.AddWithValue(
    "@keyword",
    txtCari.Text);

Dengan parameterized query, input user tidak akan dianggap sebagai bagian dari perintah SQL.

Kesimpulan

Implementasi SQL Injection pada aplikasi EZTailor menunjukkan bahwa penggunaan query concatenation sangat berbahaya karena dapat dimanfaatkan untuk memanipulasi query database. Oleh karena itu, penggunaan Stored Procedure dan Parameterized Query sangat disarankan untuk meningkatkan keamanan aplikasi database.
