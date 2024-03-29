#pragma once


namespace FlexibleMessageBoxDemoCpp {

	using namespace System;

	ref class ResUtil abstract {
	public:

		static System::Globalization::CultureInfo^ ci_;
		static System::Resources::ResourceManager^ theResource_ = gcnew System::Resources::ResourceManager(L"FlexibleMessageBoxDemoCpp.FlexibleMessageBoxDemoCppStrings", System::Reflection::Assembly::GetExecutingAssembly());

#ifdef _DEBUG
		static System::Collections::ArrayList^ da_ = gcnew System::Collections::ArrayList;

		static void showUnI18Ned() 
		{
			DTRACE(L"IIIIIIIIIIIIIIIIIIIIIIIIIIIIIII18NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN");
			for each(Object^ o in da_)
			{
				DTRACE(o->ToString());
			}
			DTRACE(L"IIIIIIIIIIIIIIIIIIIIIIIIIIIIIII18NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN");
		}
#endif

		static String^ getString(String^ s)
		{
			String^ ret = theResource_->GetString(s, ci_);

#ifdef _DEBUG
			if ( String::IsNullOrEmpty(ret) && !da_->Contains(s) )
			{
				DTRACE(L"\"" + s + "\" is not I18Ned.");
				da_->Add(s);
			}
#endif
			return String::IsNullOrEmpty(ret) ? s : ret;
		}

		static void setCultureInfo(System::Globalization::CultureInfo^ ci)
		{
			ci_ = ci;
		}
	};

} 