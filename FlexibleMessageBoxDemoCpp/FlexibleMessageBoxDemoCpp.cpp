#include "stdafx.h"
#include "Form1.h"

using namespace FlexibleMessageBoxDemoCpp;

[STAThreadAttribute]
int main(array<System::String ^> ^args)
{
	Ambiesoft::CppUtils::AmbSetProcessDPIAware();

	// Enabling Windows XP visual effects before any controls are created
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false); 

	// Create the main window and run it
	Application::Run(gcnew Form1());
	return 0;
}
