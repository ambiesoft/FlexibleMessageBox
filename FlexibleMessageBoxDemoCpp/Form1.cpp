#pragma once
#include "stdafx.h"
#include "ResUtil.h"
#include "Form1.h"

namespace FlexibleMessageBoxDemoCpp {
	System::Void Form1::button1_Click(System::Object^ sender, System::EventArgs^ e) {
		String^ aaa = ResUtil::getString("STR_HEARTS");

		//LR"V0G0N(
		//
		//)V0G0N";

		JR::Utils::GUI::Forms::FlexibleMessageBox::FONT = gcnew System::Drawing::Font("Segoe UI Emoji", 12);
		JR::Utils::GUI::Forms::FlexibleMessageBox::Show(this,
			aaa,
			"MyApp",
			MessageBoxButtons::OK,
			MessageBoxIcon::Information);
	}
}