using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSelApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            CboRestaurant.Items.AddRange(new string[]
            {
                "히노아지", "스시야마", "퍼지네이블", "새마을식당", "홍콩반점", "롤링파스타"
            });
        }

        private void CboRestaurant_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selItem = sender as ComboBox;//문자열 그 자체로는 원하는 형식을 시행할 수 없다.
            //as 구문을 통해 형변환을 한다. 그래야 제 기능을 할 수 있다.
            LblResult.Text = $"이번 주 모임장소 : {selItem.SelectedItem}";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(CboRestaurant.Text != "")
            {
                CboRestaurant.Items.Add(CboRestaurant.Text);
                LblResult.Text = $"{CboRestaurant.Text}아이템 추가";
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (CboRestaurant.SelectedIndex >= -1) ;
            {
                LblResult.Text = $"{CboRestaurant.SelectedItem}아이템 삭제";
                CboRestaurant.Items.Remove(CboRestaurant.SelectedItem);
            }
        }
    }
}
