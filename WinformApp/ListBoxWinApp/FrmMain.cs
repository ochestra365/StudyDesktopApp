using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxWinApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //살기좋은 도시 초기화, 가장 기본적인 리스트박스 추가
            LsbGoodCity.Items.Add("오스트리아,빈");
            LsbGoodCity.Items.Add("호주,멜버른");
            LsbGoodCity.Items.Add("일본,오사카");
            LsbGoodCity.Items.Add("캐나다,캘거리");
            LsbGoodCity.Items.Add("호주,시드니");
            LsbGoodCity.Items.Add("캐나다,밴쿠버");
            LsbGoodCity.Items.Add("일본,도쿄");
            LsbGoodCity.Items.Add("캐나다,토론토");
            LsbGoodCity.Items.Add("덴마크,코펜하겐");
            LsbGoodCity.Items.Add("호주,애들레이드");
            //데이터 바인딩 방식 중 하나.
            List<string> lstCountry = new List<string> { 
            "미국", "러시아", "중국", "영국", "독일", "프랑스", "일본", "이스라엘", "사우디아라비아",
            "UAE", "필리핀"
            };
            LsbHappyCountry.DataSource = lstCountry;
            LsbHappyCountry.SelectedIndex = -1;//초기화
        }

        private void LsbGdpCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            //선택된 값 확인
            // MessageBox.Show(sender.ToString());
            var selItem = sender as ListBox;//원래 컨트롤이 리스트 박스였다.(Boxing을 해서 값들이 Object화되자 
            //Object를 못 쓴다. 최상위 오브젝트밖에 못쓴다.)-->리스트박스의 형변환을 해줘야 한다.
            //형변환은 기본타입과 참조형식이 있다. 두가지 방식으로 바꿀 수 있다. as 값타입은 () 참조타입은 as
            //MessageBox.Show($"{selItem.SelectedIndex}/{selItem.SelectedItem}");
            TxtIndexGdp.Text = selItem.SelectedIndex.ToString();
            TxtItemGdp.Text = selItem.SelectedItem.ToString();
            //Tostring은 해당 메서드에서 필요한 연산을 string 형식으로 변환시켜 주는 것이다.
        }

        private void LsbGoodCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selItem = sender as ListBox;
            TxtIndexGood.Text = selItem.SelectedIndex.ToString();
            TxtItemGood.Text = selItem.SelectedItem.ToString();
        }

        private void LsbHappyCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selItem = sender as ListBox;
            TxtIndexHappy.Text = selItem.SelectedIndex.ToString();
            TxtItemHappy.Text = selItem.SelectedItem == null ? string.Empty : selItem.SelectedItem.ToString();
         }

        private void BtnInit_Click(object sender, EventArgs e)
        {
            LsbGdpCountries.SelectedIndex = LsbGoodCity.SelectedIndex = LsbHappyCountry.SelectedIndex = -1;
        }
    }
}
