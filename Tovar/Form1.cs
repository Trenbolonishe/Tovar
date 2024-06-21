using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tovar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Получаем данные из текстовых полей
            string productName = txtProductName.Text;
            string quantityText = txtQuantity.Text;
            string priceText = txtPrice.Text;

            // Проверяем, что все поля заполнены
            if (string.IsNullOrWhiteSpace(productName) || string.IsNullOrWhiteSpace(quantityText) || string.IsNullOrWhiteSpace(priceText))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверяем, что количество и цена являются числами
            if (!int.TryParse(quantityText, out int quantity) || !decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("Количество и цена должны быть числовыми значениями.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Создаем строку для отображения в списке
            string productInfo = $"{productName} - Количество: {quantity}, Цена: {price:C}";

            // Добавляем строку в список
            lstProducts.Items.Add(productInfo);

            // Очищаем текстовые поля
            txtProductName.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
        }
    }
    }

