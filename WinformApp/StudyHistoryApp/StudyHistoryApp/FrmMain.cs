using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyHistoryApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            TreeNode root = new TreeNode("영국 왕실");

            TreeNode stuart = new TreeNode("스튜어트 가");
            stuart.Nodes.Add("ANN1", "앤(1665~1714)");

            TreeNode hanover = new TreeNode("하노버 가");
            hanover.Nodes.Add("GRG1", "조지 1세(1714~1727)");
            hanover.Nodes.Add("GRG2", "조지 2세(1727~1760)");
            hanover.Nodes.Add("GRG3", "조지 3세(1760~1820)");
            hanover.Nodes.Add("GRG4", "조지 4세(1820~1830)");
            hanover.Nodes.Add("WRM4", "윌리엄 4세(1830~1837)");
            hanover.Nodes.Add("BTR1", "빅토리아(1837~1901)");

            root.Nodes.Add(stuart);
            root.Nodes.Add(hanover);

            TrvList.Nodes.Add(root);
            TrvList.ExpandAll();
        }

        private void TrvList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show(e.Node.ToString());
            PcbPicture.Image = null;
            TxtDescription.Text = string.Empty;

            if (e.Node.Name.Equals("ANN1"))
            {
                PcbPicture.Image = Bitmap.FromFile("./Images/Anne.jpg");
                TxtDescription.Text = "메리 2세는 1694년 이미 사망했고, 1702년에 단독 통치를 계속하고 있던 윌리엄 3세가 죽으면서 앤이 잉글랜드, 스코틀랜드, 아일랜드 여왕으로 즉위했다. 즉위식 때 '나의 모든 정성을 오로지 영국을 위해 바치겠노라'고 하여 국민의 갈채를 받았다. 부군이었던 덴마크의 조지는 여왕의 배우자로서의 지위가 주어져서 통치자로서의 군림은 실시하지 않았다.";
            }
            else if (e.Node.Name.Equals("GRG1")){
                PcbPicture.Image = Bitmap.FromFile("./Images/King_George_I.jpg");
                TxtDescription.Text = "조지 1세(George I, 1660년 5월 28일 ~ 1727년 6월 11일)는 영국 하노버 왕가의 시조로 재위기간은 1714년 8월 1일부터 1727년 6월 11일까지다. 신성 로마 제국의 제후국 중 하나인 하노버 선제후국의 선제후이자 브라운슈바이크뤼네부르크 공작 에른스트 아우구스트와 팔츠의 조피 사이에서 태어났으며, 영국 왕 제임스 1세의 외외증손자(딸의 외손자)가 된다."
                                        + "\n\n\n\n"
                                        + "23세 때 사촌 누이 브라운슈바이크뤼네부르크의 조피 도로테아와 결혼했고, 조지 2세와 조피 도로테아(훗날 프리드리히 2세의 어머니)를 뒀다. 그러나 결혼 13년 만에 아내의 부정을 이유로 즉시 이혼하고 알든 성에 유폐한 후, 자신의 정부 멜루지네 폰 슐렌부르크와의 사이에서 세 딸 안나 루이즈 조피, 멜루시나, 그리고 마르가레테 게르투르트를 뒀다."
                                        + "\n\n\n\n"
                                        + "1701년 제정된 영국 왕위계승법으로 제임스 1세의 손자인 어머니에 이어 영국 왕위 계승 3순위가 됐다. 그보다 앤 여왕에 더 가까운 친척들도 50인 이상 있었으나 영국 왕위계승법은 카톨릭 신자의 왕위 계승을 원천 금지하고 있어, 조지 1세와 그 어머니가 앤 여왕의 가장 가까운 신교도 혈육으로서 왕위 계승자에 이름을 올렸다."
                                        + "\n\n\n\n"
                                        + "1714년 7월 8일에 어머니가 향년 84세로 죽자 차기 계승자가 됐고, 앤 여왕이 같은 해 8월 1일 후사 없이 향년 49세에 비만으로 인한 당뇨 합병증 등의 원인으로 서거하자 54세의 나이에 영국 왕에 올랐다.그는 영어를 할 줄 몰랐고 정치에 관심이 없었다. 그는 점차 각의를 주재하지 않게 됐고, 1721년 로버트 월폴(Robert Walpole)에게 전권을 줘 각의를 주재하게 하면서, 이른바 '각의의 수석'(Primius inter pares, the first in equals)이라는 개념이 생겼다.이는 동시에 '군주는 군림하지만, 통치하지는 않는다'는 입헌군주제의 원칙을 확립되는 계기가 됐다. 이후 의원내각제와 입헌군주제가 영국에서 뿌리내렸다."
                                        + "\n\n\n\n"
                                        + "1727년 6월 11일 당뇨 합병증의 원인으로 서거 후 시신은 그가 태어난 하노버 라인 궁(Leineschloss) 헤렌하우젠 정원(Herrenhausen)에 묻혔다.";
            }
        }
    }
}
