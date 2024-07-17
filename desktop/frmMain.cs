using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
			txtMain.Text = "জামিলস মনিরুল ইসলাম মনির, মতলব উত্তর (চাঁদপুর) প্রতিনিধি :\r\nমতলব উত্তরেবন্ধু পবিত্র ঈদুল ফিতর ও পহেলা বৈশাখ উপলক্ষ্যে আতশবাজিখু ফোটানোযজ্ঞ ও বিক্রিতেড নিষেধাজ্ঞা আরোপ করেব গণবিজ্ঞপ্তি জারিট করেছেনট উপজেলাটব নির্বাহী অফিসারটব একি মিত্র চাকমাট। পাশাপাশি উচ্চ শব্দের সাউন্ড সিষ্টেম বাজানো থেকেও বিরতট থাকতে বলাট হয়েছে।\r\nমঙ্গলবার বিকেলেট জারি করা ওই গণবিজ্ঞপ্তিতে বলা হয়, এতদ্বারা সর্বসাধারণের অবগতিরব জন্য জানানো যাচ্ছে যে, আসন্ন পবিত্র ঈদুল ফিতর এবং পহেলা বৈশাখ উপলক্ষ্যে সাউন্ডবক্স/ডেক্সসেট বাজানো এবং পটকা/আতশবাজি ফোটানো ও ক্রয়-বিক্রয়ের ওপর নিষেধাজ্ঞা আরোপ করা হলো। এই আদেশ অমান্যকারীদের বিরুদ্ধে আইনানুগ ব্যবস্থা গ্রহণ করা হবে।\r\nমতলব উত্তর উপজেলা নিবাহী অফিসার একি মিত্র চাকমা বলেন, এর আগের ঈদগুলোতেও চাঁদপুরের মতলব উত্তর উপজেলায় এমন বিজ্ঞপ্তি জারি করা হয়েছে। তবে এবার ঈদ ও পহেলা বৈশাখ কাছাকাছি সময়ের ব্যবধানে হওয়ায় পহেলা বৈশাখেও এসব কার্যকলাপ থেকে সবাইকে বিরত থাকতে এ বিজ্ঞপ্তি জারি করা হয়েছে।";
		}

		private void btnCheckSpell_Click(object sender, EventArgs e)
		{
			frmSpellChecker frmSpellChecker = new frmSpellChecker(txtMain.Text);
			if (frmSpellChecker.ShowDialog() == DialogResult.OK)
			{
				var text = frmSpellChecker.CorrectedText;
				txtMain.SelectedText = text;
			}
		}
	}
}
