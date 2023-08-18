**Timestamp (UTC):** 2020-04-01T16:53:07.8183925Z

* File: AccountAndCompanyNameTests.cs
	* Method: CompanyNameIsDisplayedForUsers
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: CompanyNameIsNotDisplayedForInsuredUser
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: AcordFormsLicensingRulesTests.cs
	* Method: AccessToAcordFormsOnFormsTabOnMarketSide
		* TestCaseLink: "AFL_001: https://docs.google.com/spreadsheets/d/15BKVbjmMURWcymxGYk4vsVf5FgA4PihL7ragnXcN7tA/edit#gid=1399149024&range=A2:A11"
		* Categories: [UNDEFINED]
			* Log.Step($"Log in as a market {market} user, create an insured and a WC RFQ");
			* Log.Step("Open Forms tab");
			* Log.ExpectedResult("Check the 'access Acord forms' message");
			* Log.Step("Click 'Contact our sales team' link to open Contact us page");
			* Log.Step($"Go to admin site and enable the 'Allow using ACORD forms' setting for the {market}");
			* Log.Step($"Return to forms tab on the main site and download {acordName}");
			* Log.ExpectedResult($"Check that {acordName} is downloaded successfully");
	* Method: MarketHasAccessToAcordFormsInSendEmailDialog
		* TestCaseLink: "AFL_002: https://docs.google.com/spreadsheets/d/15BKVbjmMURWcymxGYk4vsVf5FgA4PihL7ragnXcN7tA/edit#gid=1399149024&range=A13:A33"
		* Categories: [UNDEFINED]
			* Log.Step($"Log in as a market {market} user, create an insured and a WC RFQ");
			* Log.Step($"Select {carrier} on Markets Selector");
			* Log.Step("Open Forms tab");
			* Log.ExpectedResult($"Check the 'access Acord forms' message and {expectedSupplemental} form presence");
			* Log.Step("Activate 'Available forms' checkbox, click 'Email' button and get SendEmail dialog");
			* Log.Step("Check selected forms");
			* Log.ExpectedResult($"Check that only {expectedSupplemental} form is selected and attached");
			* Log.Step("Fill the recipient field and send email");
			* Log.Step($"Go to admin site and enable the 'Allow using ACORD forms' setting for the {market}");
			* Log.Step("Return to forms tab on the main site");
			* Log.ExpectedResult($"Make sure that {expectedAcord} and {expectedSupplemental} are displayed");
			* Log.Step("Activate 'Available forms' checkbox, click 'Email' button and get SendEmail dialog");
			* Log.Step("Selected all forms");
			* Log.ExpectedResult("Check the list of selected and attached documents");
			* Log.Step("Fill the recipient field and send email");
	* Method: MarketHasAccessToAcordFormsOnQaEditor
		* TestCaseLink: "AFL_003: https://docs.google.com/spreadsheets/d/15BKVbjmMURWcymxGYk4vsVf5FgA4PihL7ragnXcN7tA/edit#gid=1399149024&range=A36:A50"
		* Categories: [UNDEFINED]
			* Log.Step($"Log in as a market {market} user, create an insured and a WC RFQ");
			* Log.Step($"Select {carrier} on Markets Selector");
			* Log.Step("Open Forms tab");
			* Log.ExpectedResult($"Check the 'access Acord forms' message and {expectedSupplemental} form presence");
			* Log.Step("Activate 'Available forms' checkbox and click 'Edit' button");
			* Log.ExpectedResult($"Check that only {expectedSupplemental} is selected");
			* Log.Step("Click 'Download Selected Supplementals'");
			* Log.ExpectedResult("Check that supplementals are downloaded");
			* Log.Step($"Go to admin site and enable the 'Allow using ACORD forms' setting for the {market}");
			* Log.Step("Return to forms tab on the main site");
			* Log.ExpectedResult($"Make sure that {expectedAcord} and {expectedSupplemental} are displayed");
			* Log.Step("Activate 'Available forms' checkbox and click 'Edit' button");
			* Log.ExpectedResult($"Check that {expectedSupplemental} and {expectedAcord} are selected");
			* Log.Step("Click 'Download Selected Supplementals'");
			* Log.ExpectedResult("Check that supplementals are downloaded as one pdf file");
	* Method: RestrictionCompanyUsersToAcordForms
		* TestCaseLink: "AFL_004: https://docs.google.com/spreadsheets/d/15BKVbjmMURWcymxGYk4vsVf5FgA4PihL7ragnXcN7tA/edit#gid=1399149024&range=51:52"
		* Categories: [UNDEFINED]
			* Log.Step($"Log in as a market user, select {submarket} market with Email submission type and click Submit");
			* Log.ExpectedResult($"'{accessMessage}' message is displayed on Add Existing panel on email dialog");
			* Log.Step("Click Contact our sales link");
			* Log.ExpectedResult("Type of request is set to 'Sales Inquiry' on Contact Us page");
	* Method: RestrictionToAccessAcordFormsFromQuoteDocsTabOnActivePolicyInterface
		* TestCaseLink: "AFL_005: https://docs.google.com/spreadsheets/d/15BKVbjmMURWcymxGYk4vsVf5FgA4PihL7ragnXcN7tA/edit#gid=1399149024&range=55:57"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as a market user, create a Workers Compensation RFQ, upload a quote, mark as bound");
			* Log.Step("Click on Quote Docs tab on the left side bar and open Forms collection");
			* Log.ExpectedResult($"There is an information string under Forms collection: '{expectedAccessMessage}'");
			* Log.Step("Click Contact our sales link");
			* Log.ExpectedResult("Type of request is set to 'Sales Inquiry' on Contact Us page");
* File: AcordsSupplementalFormsStateDetermination.cs
	* Method: CheckAcord133DisplayDependencyOnAssignedRiskControl
		* TestCaseLink: "Case SDA_06: https://docs.google.com/spreadsheets/d/1jHMgFNygv6ykhnRZDtTiszBYIQBMGI1y-iwOJPkEfYw/edit#gid=0&range=A30:A35"
		* Categories: [UNDEFINED]
			* Log.Step("Creating WC RFQ and opening it");
			* Log.Step("Opening Forms tab");
			* Log.ExpectedResult("ACORD is displayed on Forms tab");
			* Log.ExpectedResult("ACORD is checked in Forms filter");
			* Log.Step("Opening Policy--> Policy info subsection on QA tab and setting \"Assigned Risk?\" control as yes");
			* Log.Step("Opening Forms tab");
			* Log.ExpectedResult("ACORDs are displayed on Forms tab ");
			* Log.ExpectedResult("ACORDs are checked in Forms filter");
			* Log.Step("Opening Policy--> Policy info subsection on QA tab and setting \"Assigned Risk?\" control as no");
			* Log.Step("Opening Forms tab");
			* Log.ExpectedResult("ACORD is displayed on Forms tab");
			* Log.ExpectedResult("ACORD is checked in Forms filter");
	* Method: CheckingSupplementalFormsWhenYouChangeTheState
		* TestCaseLink: "SDA_05 - https://docs.google.com/spreadsheets/d/1jHMgFNygv6ykhnRZDtTiszBYIQBMGI1y-iwOJPkEfYw/edit#gid=0&range=27:29"
		* Categories: [UNDEFINED]
			* Log.Step("Log In to Appulate and Create RFQ");
			* Log.Step("Choose market on Markets Selector");
			* Log.ExpectedResult("Go to Forms tab and check Available forms list");
			* Log.Step("Go to Q&A tab, Section Policy -> Insured, Enter State 1 to Insured's Mailing Address");
			* Log.ExpectedResult("Go to Forms tab and check Available forms list");
			* Log.Step("Go to Q&A tab, Section Policy -> Insured, Delete State 1 to Insured's Mailing Address");
			* Log.Step("Go to Insured Summary and enter State 2 to State");
			* Log.ExpectedResult("Open RFQ -> Go to Forms tab and check Available forms list");
* File: ActivityLogTests.cs
	* Method: CheckQuestionnaireUpdatesInActivityLog
		* TestCaseLink: "QUA_1: https://docs.google.com/spreadsheets/d/1hHZsRjSo-W5NPhqACTbvNWkMYCMtP3uoBiiJ8-2cbTY/edit#gid=945515799&range=A2:A7"
		* Categories: [UNDEFINED]
			* Log.Step("Create RFQ and open QA page");
			* Log.Step("Fill out questions on Subject section");
			* Log.Step("Go to Activity tab");
			* Log.ExpectedResult($"{ActivityTypeEnum.QuestionnaireUpdated} is displayed in Activity tab");
			* Log.ExpectedResult("All questionnaire updates are present in list");
	* Method: CheckUsernameInLogAfterLossRunRequestSent
		* TestCaseLink: "ALLR-01 : https://docs.google.com/spreadsheets/d/1huPWR_Nl-vI456m_edXP95cfSRH7aWhuj4FPksnWYlg/edit#gid=0&range=2:4"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites
			* Log.Step("Go to Loss Runs tab, add loss run history for a market");
			* Log.Step("Open 'Send request to a market' dialog by clicking on Send Request button");
			* Log.ExpectedResult("'Letter of Authorization' is a request type by default");
			* Log.Step("Fill required fields with test data, send Letter of Authorization by clicking Send");
			* Log.ExpectedResult("Loss runs years and active buttons are displayed on the market name level");
			* Log.ExpectedResult("Status, destination, active buttons, details of email sent are displayed below the market name");
			* Log.Step("Go to Activity tab");
			* Log.ExpectedResult($"An event with the expected timestamp, '{ActivityTypeEnum.LossRunRequestSentToSign.GetDescription()}' activity type, user, comment is displayed on Activity tab");
			* Log.Step("Go to Insured Contact mailbox and Sign the document");
			* Log.Step("Refresh the Activity tab");
			* Log.ExpectedResult($"An event with the expected timestamp, '{ActivityTypeEnum.LossRunRequestSentSuccessfully.GetDescription()}' activity type, user, comment is displayed on Activity tab");
	* Method: FilterWorksOnActivityLogOnAdminSite
		* TestCaseLink: "1 : https://docs.google.com/spreadsheets/d/1WVt8BCTBiwBrYD06DVoZEggW0IOVUBiy7VBjwBK-7k4/edit#gid=0&range=A2:A4"
		* Categories: [UNDEFINED]
	* Method: FilterWorksOnAllFormsGrid
		* TestCaseLink: "7 : https://docs.google.com/spreadsheets/d/1WVt8BCTBiwBrYD06DVoZEggW0IOVUBiy7VBjwBK-7k4/edit#gid=0&range=A20:A22"
		* Categories: [UNDEFINED]
	* Method: FilterWorksOnCompanyActivityLogOnMainSite
		* TestCaseLink: "2 : https://docs.google.com/spreadsheets/d/1WVt8BCTBiwBrYD06DVoZEggW0IOVUBiy7VBjwBK-7k4/edit#gid=0&range=A5:A7"
		* Categories: [UNDEFINED]
	* Method: FilterWorksOnPolicyActivityTab
		* TestCaseLink: "4 : https://docs.google.com/spreadsheets/d/1WVt8BCTBiwBrYD06DVoZEggW0IOVUBiy7VBjwBK-7k4/edit#gid=0&range=A11:A13"
		* Categories: [UNDEFINED]
	* Method: FilterWorksOnRfqActivityTab
		* TestCaseLink: "3 : https://docs.google.com/spreadsheets/d/1WVt8BCTBiwBrYD06DVoZEggW0IOVUBiy7VBjwBK-7k4/edit#gid=0&range=A8:A10"
		* Categories: [UNDEFINED]
	* Method: FilterWorksOnSelectedAgenciesSubmissionsTab
		* TestCaseLink: "5 : https://docs.google.com/spreadsheets/d/1WVt8BCTBiwBrYD06DVoZEggW0IOVUBiy7VBjwBK-7k4/edit#gid=0&range=A14:A16"
		* Categories: [UNDEFINED]
	* Method: FilterWorksOnSubmissionLogGrid
		* TestCaseLink: "6 : https://docs.google.com/spreadsheets/d/1WVt8BCTBiwBrYD06DVoZEggW0IOVUBiy7VBjwBK-7k4/edit#gid=0&range=A17:A19"
		* Categories: [UNDEFINED]
* File: AdminSitePagesOpeningTests.cs
	* Method: CheckAdminSiteMainMenuForUnknownItems
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
			* Log.Step("Log in to admin site");
			* Log.ExpectedResult("Check all main menu items for unknown ones");
	* Method: OpenCrmContactsPage
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: AdmissionIndicatorHint.cs
	* Method: DIndicatorWithReasons
		* TestCaseLink: "DRSN1 : https://docs.google.com/spreadsheets/d/1mLb6bOyL11Vxt1GScfYEkJMxinpTIRtQG36bUZGRtWU/edit#gid=0&range=A10:I13"
		* Categories: [UNDEFINED]
			* Log.Step($"Log into admin site and check that Allow Declined Submissions property is enabled for {_.Mga}");
			* Log.Step($"Create RFQ, select {_.Mga} market");
			* Log.ExpectedResult($"Check that indicator became {expectedOrangeIndicator}");
			* Log.Step("Fill in questionnaire, fill random fein and set number of full-time employees to 1");
			* Log.ExpectedResult($"Check that indicator for market is {expectedRedIndicator} and message for declined question is shown");
			* Log.Step($"Submit to {_.Mga.Name}");
			* Log.ExpectedResult($"Check that indicator for submarket is {expectedRedIndicator} and message for declined question is shown after the submit");
	* Method: UIndicatorUnconditional
		* TestCaseLink: "UWORSN1: https://docs.google.com/spreadsheets/d/1mLb6bOyL11Vxt1GScfYEkJMxinpTIRtQG36bUZGRtWU/edit#gid=0&range=A6:I9"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites
			* Log.Step($"Create RFQ, select {_.Mga} market");
			* Log.ExpectedResult($"Check that indicator became {expectedIndicatorOrange}");
			* Log.Step("Fill in questionnaire");
			* Log.Step("Select limits");
			* Log.ExpectedResult($"Check that Admission indicator changed to {expectedIndicatorGreen} before submission and contains unconditional underwriting message");
			* Log.ExpectedResult($"Submit and check from {_.Mga}'s user side that indicator remains {expectedIndicatorGreen} and contains contains unconditional underwriting message");
	* Method: UIndicatorWithReasons
		* TestCaseLink: "UWRSN1 : https://docs.google.com/spreadsheets/d/1mLb6bOyL11Vxt1GScfYEkJMxinpTIRtQG36bUZGRtWU/edit#gid=0&range=A2:I5"
		* Categories: [UNDEFINED]
			* Log.Step($"Create RFQ, select {_.CarrierN(1)} market and fill in questions until {questionLabel} question");
			* Log.ExpectedResult($"Check that admission indicator is equal to {expectedIndicatorOrange}");
			* Log.Step($"Set {questionLabel} as yes and fill the child question");
			* Log.ExpectedResult($"Check that Admission indicator changed to {expectedIndicatorGreen} before submission and contains link for {questionLabel}");
			* Log.ExpectedResult($"Submit and check from {_.CarrierN(1)}'s user side that indicator remains {expectedIndicatorGreen} and contains link for {questionLabel}");
* File: AdvertisingEngineTests.cs
	* Method: AppearanceOfAdvertisingEngineForNonWC
		* TestCaseLink: "AE-4: https://docs.google.com/spreadsheets/d/1t4OJr03usGcE-Nzgbq1JuqQu57ZIOBYQnP0KZmH9VPk/edit#gid=0&range=A10:A12"
		* Categories: Categories.Forms
			* Log.Step("Log in to Appulate -> Create new insured and Rfq");
			* Log.Step("Select market");
			* Log.Step("Fill out questionnaire till indicator gets green A");
			* Log.Step("Click 'Submit' button");
	* Method: CheckAdvertisingEngineVisibilityAfterRefreshingPage
		* TestCaseLink: "AE-14: https://docs.google.com/spreadsheets/d/1t4OJr03usGcE-Nzgbq1JuqQu57ZIOBYQnP0KZmH9VPk/edit#gid=0&range=B23:B24"
		* Categories: Categories.Forms
			* Log.Step("Select market");
			* Log.Step("Fill out questionnaire till indicator gets green A");
			* Log.Step("Click 'Submit' button");
			* Log.ExpectedResult("Advertising Engine is displayed");
			* Log.Step("Refresh the page");
			* Log.ExpectedResult("Advertising Engine isn't displayed");
	* Method: CheckingAbsenceOfAdvertisingEngineForNonSuitableClassCode
		* TestCaseLink: "AE-5: https://docs.google.com/spreadsheets/d/1t4OJr03usGcE-Nzgbq1JuqQu57ZIOBYQnP0KZmH9VPk/edit#gid=0&range=A13:A14"
		* Categories: Categories.Forms
			* Log.Step("Log in to Appulate -> Create new insured and Rfq");
			* Log.Step("Select market");
			* Log.Step("Fill out questionnaire till indicator gets green A");
			* Log.Step("Click 'Submit' button");
	* Method: CheckingAbsenceOfAdvertisingEngineWhileThereIsAlreadyAnActivePlRfq
		* TestCaseLink: "AE-10: https://docs.google.com/spreadsheets/d/1t4OJr03usGcE-Nzgbq1JuqQu57ZIOBYQnP0KZmH9VPk/edit#gid=668104191&range=A5:A7"
		* Categories: Categories.Forms
			* Log.Step("Select market and submarket");
			* Log.Step("Create New Rqf");
			* Log.Step("Select market");
			* Log.Step("Open GL RFQ");
			* Log.Step("Click 'Submit' button");
	* Method: CheckingAdvertisingEngineInProgramsTab
		* TestCaseLink: "AE-8: https://docs.google.com/spreadsheets/d/1dOZPiPcxnNooPE0uiHqWsDWEkcXg_hvo5eLSzR5JYjo/edit#gid=0&range=A3:A8"
		* Categories: [UNDEFINED]
			* Log.Step("Check 'Enable automatic advertising' checkbox, leave 'External web resource' empty and click 'Save' button");
			* Log.Step("Fill out 'External web resource' textbox with data and Click 'Save' button");
			* Log.Step("Uncheck 'Enable automatic advertising' checkbox");
	* Method: CloseAdvertisingEngine
		* TestCaseLink: "AE-3: https://docs.google.com/spreadsheets/d/1t4OJr03usGcE-Nzgbq1JuqQu57ZIOBYQnP0KZmH9VPk/edit#gid=0&range=A7:A9"
		* Categories: Categories.Forms
			* Log.Step("Select market");
			* Log.Step("Fill out questionnaire till indicator gets green A");
			* Log.Step("Click 'Submit' button");
			* Log.Step("Click 'Close' button");
			* Log.Step("Refresh the page");
	* Method: CorrectLoggingOfAdvertisingEngineTest
		* TestCaseLink: "AE-13: https://docs.google.com/spreadsheets/d/1t4OJr03usGcE-Nzgbq1JuqQu57ZIOBYQnP0KZmH9VPk/edit#gid=668104191&range=A15:A19"
		* Categories: Categories.ActivityLogCategory, Categories.Forms
			* Log.Step("Select market and submarket");
			* Log.Step("Click 'Submit' button");
			* Log.Step("Click 'Get instant quote' button in appeared pop-up message");
			* Log.Step("Go to Activity side tab");
			* Log.Step("Go to Activity menu");
			* Log.Step("Login to admin site");
			* Log.Step("Go to Logs-->Activity Log menu");
			* Log.Step("Search insured by name");
* File: AgencyCode.cs
	* Method: AgencyCodeFieldAvailableOnSettings
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1faBYKKMsCk4CYCuOOKHlA0t4QruAnxzsZC9hyY1Sef4/edit#gid=247209013&range=A3:A5"
		* Categories: [UNDEFINED]
	* Method: AgencyCodeVisibilityOnAgenciesInfoSettings
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: SettingsTabVisibilityOnMarketsInfo
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: AgencyCodeAskingInSubmit.cs
	* Method: AgencyCodeAskingOnESubmitTest
		* TestCaseLink: "AgCode2 - https://docs.google.com/spreadsheets/d/1faBYKKMsCk4CYCuOOKHlA0t4QruAnxzsZC9hyY1Sef4/edit#gid=247209013&range=A6:A10"
		* Categories: [UNDEFINED]
	* Method: AgencyCodeAskingOnSubmitWeblinkTest
		* TestCaseLink: "AgCode3 - https://docs.google.com/spreadsheets/d/1faBYKKMsCk4CYCuOOKHlA0t4QruAnxzsZC9hyY1Sef4/edit#gid=247209013&range=A11:A13"
		* Categories: [UNDEFINED]
* File: AgencyProducerCodesTests.cs
	* Method: AgencyCodesForDifferentLocations
		* TestCaseLink: "APC_2: https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=1694687923&range=A7"
		* Categories: Categories.Forms
	* Method: EmployersProducerAndAgencyCodesAreRequiredAndMayImputedByDialogWindow
		* TestCaseLink: "EmplWC-PC-01: https://docs.google.com/spreadsheets/d/1HVgn0_neywJu6he_KTe6v6xbpYkKARle26XwTZXMU-k/edit#gid=0&range=A26:A32"
		* Categories: [UNDEFINED]
			* Log.Step("Create an insured and a WC RFQ");
			* Log.Step("Set Producer in Options tab");
			* Log.Step("Select market and fill questionnaire, limits");
			* Log.ExpectedResult($"Indicator as an expected for market {market}");
			* Log.ExpectedResult("Tooltip for market's indicator as an expected");
			* Log.Step($"Click to '{agencyCodeLinkText}' link on Indicator and fill code in dialog");
			* Log.ExpectedResult("Indicator displayed as an expected after filled Agency code");
			* Log.Step($"Click to '{producerCodeLinkText}' link on Indicator and fill code in dialog");
			* Log.ExpectedResult("Indicator displayed as an expected after filled Agency and Producer codes");
			* Log.ExpectedResult("Agency and Producer codes displayed as an expected on Employers market settings page");
	* Method: ESubmissionFromMarketsSelectorEnteringProducerCodeInOptionsDialog
		* TestCaseLink: "PC_01: https://docs.google.com/spreadsheets/d/1faBYKKMsCk4CYCuOOKHlA0t4QruAnxzsZC9hyY1Sef4/edit#gid=422060571&range=A2:A21"
		* Categories: [UNDEFINED]
			* Log.Step("Create an insured and a WC RFQ");
			* Log.Step("Select market and fill questionnaire");
			* Log.Step("Fill in options for eSubmission");
			* Log.Step($"Perform submit to the {market.Name}");
			* Log.ExpectedResult($"'{market.Name}' market's status is {MarketStatus.SubmissionInitiated.GetDescription()}'");
			* Log.Step("Refresh the page");
			* Log.ExpectedResult($"{MarketsSelectorAction.Resubmit.GetDescription()} action is available for the {market.Name}");
			* Log.Step($"Click {MarketsSelectorAction.ViewRequestXml.GetDescription()} action and try to find the producer code in the XML");
	* Method: SubmissionOptionsVerificationForEsubmission
		* TestCaseLink: "MSR_15: https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A16 and" +
		                                  "MSR_40: https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A45 and" +
		                                  "MSR_41: https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A46 and" +
		                                  "MSR_42: https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A47"
		* Categories: [UNDEFINED]
	* Method: UseOnlyPersonalLoginsForOutgoingSubmissions
		* TestCaseLink: "APC_1: https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=1694687923&range=A2"
		* Categories: Categories.Forms
* File: AgencyRegistrationTests.cs
	* Method: AgencyCodeIsHiddenWhileResigteringAgency
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1faBYKKMsCk4CYCuOOKHlA0t4QruAnxzsZC9hyY1Sef4/edit#gid=247209013&range=A36:A37"
		* Categories: [UNDEFINED]
	* Method: BackNavigationFromUserInformationToCompanyInformation
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1ldCkNdi0iC1-aBwioTNrO0hOvwNtNJGcmux4CUFTX3E/edit#gid=34483309&range=A2"
		* Categories: [UNDEFINED]
	* Method: CheckValidationWithDifferentNamesLength
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: CorrectPasswordCasesForTwoCharactersNamesLenth
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: DuplicateEmailTest
		* TestCaseLink: "SU_17 - SU_18 https://docs.google.com/spreadsheets/d/1ldCkNdi0iC1-aBwioTNrO0hOvwNtNJGcmux4CUFTX3E/edit#gid=34483309&range=A45:J46"
		* Categories: [UNDEFINED]
	* Method: IncorrectPasswordCases
		* TestCaseLink: "SU_08 - https://docs.google.com/spreadsheets/d/1ldCkNdi0iC1-aBwioTNrO0hOvwNtNJGcmux4CUFTX3E/edit#gid=34483309&range=A9"
		* Categories: [UNDEFINED]
	* Method: MissedValuesOnCompanyInformation
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1ldCkNdi0iC1-aBwioTNrO0hOvwNtNJGcmux4CUFTX3E/edit#gid=34483309&range=A6"
		* Categories: [UNDEFINED]
	* Method: MissedValuesOnUserInformation
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1ldCkNdi0iC1-aBwioTNrO0hOvwNtNJGcmux4CUFTX3E/edit#gid=34483309&range=A7"
		* Categories: [UNDEFINED]
	* Method: NavigationBetweenUserInformationAndCompanyInformation
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1ldCkNdi0iC1-aBwioTNrO0hOvwNtNJGcmux4CUFTX3E/edit#gid=34483309&range=A3"
		* Categories: [UNDEFINED]
	* Method: OverflowingValuesOnCompanyInformation
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1ldCkNdi0iC1-aBwioTNrO0hOvwNtNJGcmux4CUFTX3E/edit#gid=34483309&range=A4"
		* Categories: [UNDEFINED]
	* Method: OverflowingValuesOnUserInformation
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1ldCkNdi0iC1-aBwioTNrO0hOvwNtNJGcmux4CUFTX3E/edit#gid=34483309&range=A5"
		* Categories: [UNDEFINED]
	* Method: RegisterNewAgencyAndCheckDefaultSettingsExceptTestingOnAdminSite
		* TestCaseLink: "LR_01: https://docs.google.com/spreadsheets/d/1BATID_VFwXQuahPDUg-FHE9Ej1fkGCYqjEHe2OZnsSc/edit#gid=0&range=A36:A47 and" +
		                                  "LR_02: https://docs.google.com/spreadsheets/d/1BATID_VFwXQuahPDUg-FHE9Ej1fkGCYqjEHe2OZnsSc/edit#gid=0&range=A48:A60 and" +
		                                  "AE-14: https://docs.google.com/spreadsheets/d/1BATID_VFwXQuahPDUg-FHE9Ej1fkGCYqjEHe2OZnsSc/edit#gid=0&range=A70:A71 and " +
		                                  "QB_2: https://docs.google.com/spreadsheets/d/1oIxk84Wm-s_4t8JX2VeYac2g2CP5DiV6MSN6Wddp4UQ/edit#gid=1239226475&range=A5:A7" +
		                                  "AE-15: https://docs.google.com/spreadsheets/d/1BATID_VFwXQuahPDUg-FHE9Ej1fkGCYqjEHe2OZnsSc/edit#gid=0&range=A73:A75"
		* Categories: [UNDEFINED]
			* Log.Step("Uncheck 'Show advertisement' setting");
			* Log.Step("Check 'Show advertisement' setting");
	* Method: RegisterNewAgencyAndCheckTesting
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1ldCkNdi0iC1-aBwioTNrO0hOvwNtNJGcmux4CUFTX3E/edit#gid=34483309&range=A11:AA11"
		* Categories: Categories.ExcludingCategoryOnlyProductionSite, Categories.SmokeTestsCategory
	* Method: WrongEmail
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1ldCkNdi0iC1-aBwioTNrO0hOvwNtNJGcmux4CUFTX3E/edit#gid=34483309&range=A8"
		* Categories: [UNDEFINED]
* File: AgencyToMarketTests.cs
	* Method: ConvertNewAgencyToMarket
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: Aim.cs
	* Method: CreateNewRfqOnAimSide
		* TestCaseLink: "A_1 - https://docs.google.com/spreadsheets/d/1Z8x6rCZ8Ghl3j1xmWR_rrQAIHkSiHK0Zm7n56-6qrZQ/edit#gid=0&range=C2:C7, \n" +
		                                  "A_8 - https://docs.google.com/spreadsheets/d/1Z8x6rCZ8Ghl3j1xmWR_rrQAIHkSiHK0Zm7n56-6qrZQ/edit#gid=0&range=C25:C26"
		* Categories: [UNDEFINED]
	* Method: CreateNewRfqOnAimSideByUser
		* TestCaseLink: "A_2 - https://docs.google.com/spreadsheets/d/1Z8x6rCZ8Ghl3j1xmWR_rrQAIHkSiHK0Zm7n56-6qrZQ/edit#gid=0&range=C8:C13"
		* Categories: [UNDEFINED]
	* Method: DisabledExportWhenAssignedAgencyNotLinked
		* TestCaseLink: "A_9 - https://docs.google.com/spreadsheets/d/1Z8x6rCZ8Ghl3j1xmWR_rrQAIHkSiHK0Zm7n56-6qrZQ/edit#gid=0&range=C27:C28"
		* Categories: [UNDEFINED]
	* Method: DisabledExportWhenCredentialsIncorrect
		* TestCaseLink: "A_7 - https://docs.google.com/spreadsheets/d/1Z8x6rCZ8Ghl3j1xmWR_rrQAIHkSiHK0Zm7n56-6qrZQ/edit#gid=0&range=C22:C24"
		* Categories: [UNDEFINED]
	* Method: DisabledExportWhenIntegrationUrlIncorrect
		* TestCaseLink: "A_5 - https://docs.google.com/spreadsheets/d/1Z8x6rCZ8Ghl3j1xmWR_rrQAIHkSiHK0Zm7n56-6qrZQ/edit#gid=0&range=C20"
		* Categories: [UNDEFINED]
	* Method: DisabledExportWhenIntegrationUrlIncorrectByUser
		* TestCaseLink: "A_6 - https://docs.google.com/spreadsheets/d/1Z8x6rCZ8Ghl3j1xmWR_rrQAIHkSiHK0Zm7n56-6qrZQ/edit#gid=0&range=C21"
		* Categories: [UNDEFINED]
	* Method: IncorrectIntegrationUrlAim
		* TestCaseLink: "A_3 - https://docs.google.com/spreadsheets/d/1Z8x6rCZ8Ghl3j1xmWR_rrQAIHkSiHK0Zm7n56-6qrZQ/edit#gid=0&range=C14:C16"
		* Categories: [UNDEFINED]
	* Method: IncorrectIntegrationUrlAimUser
		* TestCaseLink: "A_4 - https://docs.google.com/spreadsheets/d/1Z8x6rCZ8Ghl3j1xmWR_rrQAIHkSiHK0Zm7n56-6qrZQ/edit#gid=0&range=C17:C19"
		* Categories: [UNDEFINED]
	* Method: LinkToExistingInsured
		* TestCaseLink: "A_10 - https://docs.google.com/spreadsheets/d/1Z8x6rCZ8Ghl3j1xmWR_rrQAIHkSiHK0Zm7n56-6qrZQ/edit#gid=0&range=C29"
		* Categories: [UNDEFINED]
	* Method: LinkToExistingPolicyOnAimSide
		* TestCaseLink: "A_11 : https://docs.google.com/spreadsheets/d/1Z8x6rCZ8Ghl3j1xmWR_rrQAIHkSiHK0Zm7n56-6qrZQ/edit#gid=0&range=A34:A42"
		* Categories: [UNDEFINED]
	* Method: LinkUnlinkFromAimAgenciesGrid
		* TestCaseLink: "LU_AAG_1: https://docs.google.com/spreadsheets/d/1RPdO0OugyC0fAXG8zBJAquQ5dX4P9LllpNZ-g61fgCQ/edit#gid=0&range=A2"
		* Categories: [UNDEFINED]
			* Log.Step("Open Agencies > AIM");
			* Log.Step("Perform Link from Aim Agencies grid");
			* Log.Step("Perform Unlink from Aim Agencies grid");
	* Method: RedirectToAimAgenciesAfterEnteringCorrectCredentials
		* TestCaseLink: "A_17: https://docs.google.com/spreadsheets/d/1Z8x6rCZ8Ghl3j1xmWR_rrQAIHkSiHK0Zm7n56-6qrZQ/edit#gid=0&range=A69:A71"
		* Categories: [UNDEFINED]
			* Log.Step("Open Agencies > AIM page ");
			* Log.ExpectedResult("Error message is appeared");
			* Log.Step("Follow 'here' link from error message");
			* Log.Step("Enter correct AIM credentials");
			* Log.Step("Save entered credentials. Redirection to 'AIM Agencies' page has been completed");
			* Log.ExpectedResult("No errors message are presented on UI");
	* Method: SearchInsuredToLinkToById
		* TestCaseLink: "A_16: https://docs.google.com/spreadsheets/d/1Z8x6rCZ8Ghl3j1xmWR_rrQAIHkSiHK0Zm7n56-6qrZQ/edit#gid=0&range=A64:68"
		* Categories: [UNDEFINED]
	* Method: ThereIsErrorMessageWhenAimIntegrationServiceUrlIsChangedToIncorrectWhileAdminIsDoingPaging
		* TestCaseLink: "A_13: https://docs.google.com/spreadsheets/d/1Z8x6rCZ8Ghl3j1xmWR_rrQAIHkSiHK0Zm7n56-6qrZQ/edit#gid=0&range=A49:A54"
		* Categories: [UNDEFINED]
	* Method: ThereIsErrorMessageWhenAimIntegrationServiceUrlIsChangedToIncorrectWhileUserIsDoingSearchByInsuredName
		* TestCaseLink: "A_12: https://docs.google.com/spreadsheets/d/1Z8x6rCZ8Ghl3j1xmWR_rrQAIHkSiHK0Zm7n56-6qrZQ/edit#gid=0&range=A44:A46"
		* Categories: [UNDEFINED]
	* Method: ThereIsErrorMessageWhenAimIntegrationServiceUrlIsChangedToIncorrectWhileUserIsLinkingAgencies
		* TestCaseLink: "A_15: https://docs.google.com/spreadsheets/d/1Z8x6rCZ8Ghl3j1xmWR_rrQAIHkSiHK0Zm7n56-6qrZQ/edit#gid=0&range=A61:A63"
		* Categories: [UNDEFINED]
	* Method: ThereIsErrorMessageWhenUsersAimCredentialsAreChangedToIncorrectWhileUserIsDoingSearchInsuredByFein
		* TestCaseLink: "A_14: https://docs.google.com/spreadsheets/d/1Z8x6rCZ8Ghl3j1xmWR_rrQAIHkSiHK0Zm7n56-6qrZQ/edit#gid=0&range=A55:A60"
		* Categories: [UNDEFINED]
* File: AimSetup.cs
	* Method: CheckAimDownloadLink
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: CheckAimInstallationInstructionsLink
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: AllPoliciesGridTests.cs
	* Method: RecordAdditionToAllPoliciesGridLogicTest
		* TestCaseLink: "AP_1 - https://docs.google.com/spreadsheets/d/1TNc8VONemJNIS6H2tJ-5CpgPZk4XZRPJWEtEVxCQFTM/edit#gid=384960878&range=A2:A6"
		* Categories: [UNDEFINED]
			* Log.Step("Create RFQ and Open QA page");
			* Log.ExpectedResult("Record is displayed on \"Quotes->All Requests for Quote\" on agency side");
			* Log.Step($"Reopen QA page, select {_market.Name}, fill out questionnaire and submit");
			* Log.Step($"Opening RFQ's QA tab as '{_market.Name}' user");
			* Log.ExpectedResult($"Record is displayed on \"Quotes->All Requests for Quote\" on {_market.Name}'s side");
			* Log.Step($"Reopen QA page and click '{MarketsSelectorAction.MarkAsBound.GetDescription()}'");
			* Log.ExpectedResult($"Record is displayed on \"Policies->All Policies\" on {_market.Name}'s side");
			* Log.ExpectedResult($"Record is not displayed on \"Quotes->All Requests for Quote\" on {_market.Name}'s side");
	* Method: RecordDisplayedInInForceAndToRenewGridsAfterCreatingPolicy
		* TestCaseLink: "PM-1 PM-2 PM-3: https://docs.google.com/spreadsheets/d/1TNc8VONemJNIS6H2tJ-5CpgPZk4XZRPJWEtEVxCQFTM/edit#gid=384960878&range=A10:A14"
		* Categories: [UNDEFINED]
			* Log.Step("Creating WC Policy");
			* Log.ExpectedResult("Record is displayed in Policies->In Force grid");
			* Log.ExpectedResult("Record is displayed in Policies->To Renew grid");
			* Log.Step("Reopen policy, open Options tab, click cancel button in Actions section");
			* Log.ExpectedResult("Record is displayed in Polcies->Terminated Policies grid");
			* Log.ExpectedResult("Record is not displayed in Policies->In Force and Policies->To Renew grids");
	* Method: RecordsAdditionToInForceAndAllPoliciesGridsLogicTest
		* TestCaseLink: "AP_2 - https://docs.google.com/spreadsheets/d/1TNc8VONemJNIS6H2tJ-5CpgPZk4XZRPJWEtEVxCQFTM/edit#gid=384960878&range=A7:A9"
		* Categories: [UNDEFINED]
			* Log.Step("Create Policy record with Effective date = today and Open QA page");
			* Log.ExpectedResult($"Record with Effective date = {policyApplication.Records[0].EffectiveDate} is displayed on \"Policies->All Policies\"");
			* Log.Step("Adding another Policy record with Effective date = today + 10 days");
			* Log.ExpectedResult("Both records are displayed on \"Policies->In Force\"");
			* Log.ExpectedResult("Only last added record is displayed on \"Policies->All Policies\"");
* File: AmFamLicenseValidation.cs
	* Method: ValidationAgencySideNoId
		* TestCaseLink: "ALVNOID1 : https://docs.google.com/spreadsheets/d/1Bw2Ro-O3-og36TgGC3NOsC_Skvb2Q4ILTId0bzB1EV4/edit#gid=0&range=A15:H17"
		* Categories: [UNDEFINED]
			* Log.Step("Fill State field in the Locations collection to trigger license check");
			* Log.Step($"Select {market.Name} and check market's hit for Producer requirement");
			* Log.Step("Assign Producer to RFQ");
			* Log.Step("Check that RFQ is declined and error message is shown");
	* Method: ValidationAtMarketSideNoId
		* TestCaseLink: "ALVNOID2 : https://docs.google.com/spreadsheets/d/1Bw2Ro-O3-og36TgGC3NOsC_Skvb2Q4ILTId0bzB1EV4/edit#gid=0&range=A18:H21"
		* Categories: [UNDEFINED]
			* Log.Step("Assert that created RFQ requires agency assignment");
			* Log.Step("Assign agency and check that producer assignment is required after");
			* Log.Step("Assign producer from agency and check that message is gone");
			* Log.Step("Fill State control, check that userId validation message is shown");
* File: AnonymousPagesOpeningByLoggedUserTests.cs
	* Method: CheckHomePageIsNotOpenedForLoggedInUser
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: AnswersPoolSiteTests.cs
	* Method: CopyingProperPoolFromExistingRfq
		* TestCaseLink: "APS-3: https://docs.google.com/spreadsheets/d/1EUEA6Dn-Wn1cNpKyIQqNHuAaiVAfFcy3h4Td5vFFkmg/edit#gid=1606841229&range=A7:A8"
		* Categories: [UNDEFINED]
			* Log.Step($"Create another {bopRecord.Line.GetDescription()} RFQ");
			* Log.ExpectedResult($"{question} is filled with {questionData}");
			* Log.Step($"Fill out {question} in newly created RFQ and opening Options tab");
			* Log.Step($"Open Q&A tab of created {wcRecord.Line.GetDescription()} RFQ");
			* Log.ExpectedResult($"{question} is filled with {questionData}");
	* Method: CopyingProperPoolFromExistingRfqAndRenewForSameLine
		* TestCaseLink: "APS-1: https://docs.google.com/spreadsheets/d/1EUEA6Dn-Wn1cNpKyIQqNHuAaiVAfFcy3h4Td5vFFkmg/edit#gid=1606841229&range=A2:A4"
		* Categories: [UNDEFINED]
			* Log.Step($"Create another {wcRecord2.Line.GetDescription()} RFQ");
			* Log.ExpectedResult($"{question} is filled with {questionData}");
			* Log.Step($"Fill out {question} in newly created RFQ and opening Options tab");
			* Log.ExpectedResult("Newly created RFQ is Renewal");
			* Log.Step($"Open Q&A tab of first created {wcRecord1.Line.GetDescription()} RFQ");
			* Log.ExpectedResult($"{question} is filled with {questionData}");
	* Method: CreatingNewRfqOnProperCurrentPoolOfExistingRfq
		* TestCaseLink: "APS-2: https://docs.google.com/spreadsheets/d/1EUEA6Dn-Wn1cNpKyIQqNHuAaiVAfFcy3h4Td5vFFkmg/edit#gid=1606841229&range=A5:A6"
		* Categories: [UNDEFINED]
			* Log.Step("Set new Dates for previously created RFQs");
			* Log.Step($"Fill out {question} in both RFQs");
			* Log.Step($"Create {glRecord.Line.GetDescription()} RFQ");
			* Log.ExpectedResult($"{question} is filled with {questionData}");
			* Log.Step($"Fill out {question} in newly created RFQ");
			* Log.Step($"Open previously created {cpkgRecord.Line.GetDescription()} + {cpkgRecord.CoverageLines.GetValue(0).GetDescription()} RFQ");
			* Log.ExpectedResult($"{question} is filled with {newQuestionData}");
	* Method: CreatingNewRfqOnProperCurrentPoolOfExistingRfqWhileRfqForAnotherILExists
		* TestCaseLink: "APS-4: https://docs.google.com/spreadsheets/d/1EUEA6Dn-Wn1cNpKyIQqNHuAaiVAfFcy3h4Td5vFFkmg/edit#gid=1606841229&range=A9:A10"
		* Categories: [UNDEFINED]
			* Log.Step($"Create another {wcRecord2.Line.GetDescription()} RFQ");
			* Log.ExpectedResult($"{question} is filled with {questionData}");
			* Log.Step($"Fill out {question} in newly created RFQ");
			* Log.Step($"Open Q&A tab of created {autobRecord.Line.GetDescription()} RFQ");
			* Log.ExpectedResult($"{question} is filled with {newQuestionData}");
* File: AnswersPoolTests.cs
	* Method: RenewExistingRfqForTheSameInsuranceLineAfterUplink
		* TestCaseLink: "AP-05 : https://docs.google.com/spreadsheets/d/1EUEA6Dn-Wn1cNpKyIQqNHuAaiVAfFcy3h4Td5vFFkmg/edit#gid=0&range=28:31"
		* Categories: [UNDEFINED]
			* Log.Step("Uplink Document as user of Agency, choose Insurance Line if asked");
			* Log.Step("Choose destination 'Appulate UI' and option 'Update existing'");
			* Log.ExpectedResult("Pool records are displayed on Insured Admin page");
			* Log.ExpectedResult($"Check that {question} is answered with 'Yes' in Arrowhead supplemental");
			* Log.ExpectedResult("Option 'Renewal' is checked on Options tab");
* File: ApplicationManagement.cs
	* Method: CopyInsuredWithActivePolicyAndCheckCopyContainsRfq
		* TestCaseLink: "IA-Copy-2: https://docs.google.com/spreadsheets/d/1jBKfNWh5ya8hvcqt1W6kbOz7bbMUg8RNixHnRhhlInI/edit#gid=0&range=A35:A37"
		* Categories: [UNDEFINED]
			* Log.Step("Creating WC Policy");
			* Log.Step("Policy with Active Policy record status is created");
			* Log.Step("Go to All Insured page and copy previously created Policy");
			* Log.ExpectedResult("Insured copied");
			* Log.Step("Open copied Insured");
			* Log.ExpectedResult("RFQ with New Request for Quote record status is present");
* File: AppointmentNotWorkflowTests.cs
	* Method: Cancel_Appointment_Agency_After_Set_Appointment_Agency
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Cancel_Appointment_Agency_After_Set_Appointment_Market
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Cancel_Appointment_Market_After_Set_Appointment_Agency
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Cancel_Appointment_Market_After_Set_Appointment_Market
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Default_Status
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Set_Appointment_Agency
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Set_Appointment_Agency_After_Cancel_Appointment_Agency_After_Set_Appointment_Agency
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Set_Appointment_Agency_After_Cancel_Appointment_Agency_After_Set_Appointment_Market
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Set_Appointment_Agency_After_Cancel_Appointment_Market_After_Set_Appointment_Agency
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Set_Appointment_Agency_After_Cancel_Appointment_Market_After_Set_Appointment_Market
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Set_Appointment_Market
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Set_Appointment_Market_After_Cancel_Appointment_Agency_After_Set_Appointment_Agency
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Set_Appointment_Market_After_Cancel_Appointment_Agency_After_Set_Appointment_Market
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Set_Appointment_Market_After_Cancel_Appointment_Market_After_Set_Appointment_Agency
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Set_Appointment_Market_After_Cancel_Appointment_Market_After_Set_Appointment_Market
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: AppointmentPageTests.cs
	* Method: OpenAgencyInfoAppointmentFromVerticalMenu
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: UploadDocumentsFromAgencyAndMarketSide
		* TestCaseLink: "AW-23: https://docs.google.com/spreadsheets/d/1KyrphlexNyU717kcus7DC64oZSKY68nVVqkblQZYIVQ/edit#gid=1945062409&range=A67"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency user, open market info appointment page and upload random amount of documents (1-3)");
			* Log.ExpectedResult("Check documents uploaded by a certain user on an agency side");
			* Log.Step("Log in as a market user, open agency info appointment page and upload random amount of documents (1-3)");
			* Log.ExpectedResult("Check documents uploaded by a certain user on a market side");
			* Log.ExpectedResult("Check all uploaded documents and their names on the agency");
* File: AppointmentRegressionTests.cs
	* Method: CounterChangedAfterSendOrRejectRequestToMarket
		* TestCaseLink: "Case AW-12: https://docs.google.com/spreadsheets/d/1KyrphlexNyU717kcus7DC64oZSKY68nVVqkblQZYIVQ/edit#gid=801478441&range=A2:A6" +
		                                  "Case AW-13: https://docs.google.com/spreadsheets/d/1KyrphlexNyU717kcus7DC64oZSKY68nVVqkblQZYIVQ/edit#gid=801478441&range=A7:A16"
		* Categories: [UNDEFINED]
	* Method: CounterChangedWhenAgencyBecomesUnselected
		* TestCaseLink: "Case AW-14: https://docs.google.com/spreadsheets/d/1KyrphlexNyU717kcus7DC64oZSKY68nVVqkblQZYIVQ/edit#gid=801478441&range=A17:A25"
		* Categories: [UNDEFINED]
	* Method: CounterChangedWhenMarketBecomesUnselected
		* TestCaseLink: "Case AW-15: https://docs.google.com/spreadsheets/d/1KyrphlexNyU717kcus7DC64oZSKY68nVVqkblQZYIVQ/edit#gid=801478441&range=A26:A34"
		* Categories: [UNDEFINED]
* File: AppointmentWorkflowTests.cs
	* Method: Accept_Request_After_Request_Appointment
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Cancel_Appointment_Agency_After_Accept_Request
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Cancel_Appointment_Agency_After_Set_Appointment_Market
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Cancel_Appointment_Market_After_Accept_Request
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Cancel_Appointment_Market_After_Set_Appointment_Market
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Cancel_Request_After_Request_Appointment
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Default_Status
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Reject_Request_After_Request_Appointment
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Request_Appointment
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Request_Appointment_After_Cancel_Appointment
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Request_Appointment_After_Cancel_Appointment_Agency_After_Accept_Request
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Request_Appointment_After_Cancel_Appointment_Market
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Request_Appointment_After_Cancel_Appointment_Market_After_Accept_Request
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Request_Appointment_After_Cancel_Request
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Request_Appointment_After_Reject_Request
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Set_Appointment_After_Cancel_Appointment
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Set_Appointment_Market
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Set_Appointment_Market_After_Cancel_Appointment_Agency_After_Accept_Request
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Set_Appointment_Market_After_Cancel_Appointment_Market
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Set_Appointment_Market_After_Cancel_Appointment_Market_After_Accept_Request
		* TestCaseLink: [UNDEFINED]
		* Categories: Categories.SmokeTestsCategory
	* Method: Set_Appointment_Market_After_Cancel_Request
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Set_Appointment_Market_After_Reject_Request
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: AppulateElearningTests.cs
	* Method: OpenElearningPageFromTrainingAndCheckCourseIdCorrect
		* TestCaseLink: "eL_2: https://docs.google.com/spreadsheets/d/1-U3Bz6g4Ra7RX5aHrJ3r1jZFGu0xMmUvLpA5o0SK0fs/edit#gid=0&range=A4:A7"
		* Categories: [UNDEFINED]
	* Method: TrainingPageCheck
		* TestCaseLink: "eL_1: https://docs.google.com/spreadsheets/d/1-U3Bz6g4Ra7RX5aHrJ3r1jZFGu0xMmUvLpA5o0SK0fs/edit#gid=0&range=A2:A3"
		* Categories: [UNDEFINED]
* File: AppulateMarketDirectoryTestingSitesTests.cs
	* Method: EnablingAndDisablingEstimatedPremiumLabel
		* TestCaseLink: "SMD-3: https://docs.google.com/spreadsheets/d/1_1v2aa5qC4PGu2Lxw2wkVl7hvuGgh73WNFhi4WR0QEw/edit#gid=1907528421&range=A21"
		* Categories: Categories.AdminSiteTestsCategory, Categories.MarketProgramsCategory
			* Log.Step($"Open the 'Market directory' page and find the '{market.Name}' market");
			* Log.ExpectedResult("There is the following label under the market name: Estimated Premium");
			* Log.Step($"Return to the market's program settings page and change 'Rating Type' setting to '{RatingTypeSettingOption.Disabled.GetDescription()}'");
			* Log.Step($"Open the 'Market directory' page and find the '{market.Name}' market");
			* Log.ExpectedResult("There is no the following label under the market name: Estimated Premium");
			* Log.Step($"Return to the market's program settings page and change 'Rating Type' setting to '{RatingTypeSettingOption.External.GetDescription()}'");
			* Log.Step($"Open the 'Market directory' page and find the '{market.Name}' market");
			* Log.ExpectedResult("There is the following label under the market name: Estimated Premium");
			* Log.Step($"Return to the market's program settings page and change 'Est. Premium' setting to '{EstimatedPremiumSettingOption.NotVisibleToSubmitters.GetDescription()}'");
			* Log.Step($"Open the 'Market directory' page and find the '{market.Name}' market");
			* Log.ExpectedResult("There is no the following label under the market name: Estimated Premium");
	* Method: EnablingAndDisablingOpenBrokerageLabel
		* TestCaseLink: "SMD-1: https://docs.google.com/spreadsheets/d/1_1v2aa5qC4PGu2Lxw2wkVl7hvuGgh73WNFhi4WR0QEw/edit#gid=1907528421&range=A2" +
		                                  "SMD-2: https://docs.google.com/spreadsheets/d/1_1v2aa5qC4PGu2Lxw2wkVl7hvuGgh73WNFhi4WR0QEw/edit#gid=1907528421&range=A15"
		* Categories: Categories.AdminSiteTestsCategory, Categories.MarketProgramsCategory
			* Log.Step($"Log in as an admin and open '{_market.Name}' market's settings page");
			* Log.ExpectedResult(
				$"Check that '{MarketSettings.AppulateMarketsListing.GetDescription()}', '{MarketSettings.OpenBrokerageLabel.GetDescription()}' and 'Instant Quote label' settings are checked");
			* Log.Step($"Open the 'Market directory' page and find the '{_market.Name}' market");
			* Log.ExpectedResult("There are the following labels under the market name: Open Brokerage, Instant Quote");
			* Log.Step($"Return to the market's settings page and disable '{MarketSettings.OpenBrokerageLabel.GetDescription()}' and 'Instant Quote label' settings");
			* Log.Step($"Open the 'Market directory' page and find the '{_market.Name}' market");
			* Log.ExpectedResult("There are no the following labels under the market name: Open Brokerage, Instant Quote");
* File: AppulateMarketDirectoryTests.cs
	* Method: MarketDirectorySearchNotSupportedAndNotExistedLinesTest
		* TestCaseLink: "MD-2: https://docs.google.com/spreadsheets/d/1_1v2aa5qC4PGu2Lxw2wkVl7hvuGgh73WNFhi4WR0QEw/edit#gid=0&range=A14:A17"
		* Categories: [UNDEFINED]
			* Log.Step("Open Appulate Market Directory page");
			* Log.Step("In Search field fill nonexistent insurance line");
			* Log.ExpectedResult("Correct message in search field is displayed");
			* Log.Step("Refresh page and select currently not supported line in placeholder");
			* Log.ExpectedResult("Correct message in search field and message on the page is displayed");
	* Method: MarketDirectorySearchTest
		* TestCaseLink: "MD-1: https://docs.google.com/spreadsheets/d/1_1v2aa5qC4PGu2Lxw2wkVl7hvuGgh73WNFhi4WR0QEw/edit#gid=0&range=A2:A13"
		* Categories: [UNDEFINED]
			* Log.Step("Open Appulate Market Directory page");
			* Log.ExpectedResult("Correct Insurance line picker placeholder is displayed");
			* Log.ExpectedResult("All Submission Types description displayed on 'Did You Know' popup");
			* Log.ExpectedResult("Correct Overview section displayed on 'Did You Know' popup");
			* Log.ExpectedResult("All Insurance lines available in search field");
			* Log.Step($"Select line '{line}' in disclaimer");
			* Log.ExpectedResult("Correct counts of market in search placeholder for current line");
			* Log.ExpectedResult("Correct available buttons on, market line depends on submission type is displayed");
			* Log.Step("Click on 'For example' line link");
			* Log.ExpectedResult("Correct counts of market in search placeholder for current line is displayed");
* File: AppulateOpenBrokeragePageTests.cs
	* Method: OpenBrokerageMarketListPageCheck
		* TestCaseLink: "OB-1: https://docs.google.com/spreadsheets/d/1-79w0U1pYfQ4MSn6moJzl-1beW4yJDMpto6xxxHrsso/edit#gid=458048708&range=A2"
		* Categories: Categories.AnonymousSite
			* Log.Step($"Open {UrlBuilder.GenerateUrl<OpenBrokeragePage>()} page");
			* Log.ExpectedResult("Check table's columns' headers");
			* Log.ExpectedResult("Check the link in the first table's row");
* File: AppulateWizardTests.cs
	* Method: CloseAppulateWizard
		* TestCaseLink: "GS-02: https://docs.google.com/spreadsheets/d/1NT4N5qQwK1HuMT4UJaKqb4i7lDHHLcS5qcKjQ7yyWGk/edit#gid=0&range=A11:A14"
		* Categories: Categories.AgencySignUp, Categories.InteractiveTutorialCategory
			* Log.Step("Registration of new company");
			* Log.Step("Close wizard");
			* Log.Step("Relogin to company");
	* Method: ViewAppulateWizard
		* TestCaseLink: "GS-01: https://docs.google.com/spreadsheets/d/1NT4N5qQwK1HuMT4UJaKqb4i7lDHHLcS5qcKjQ7yyWGk/edit#gid=0&range=A2:A10"
		* Categories: Categories.AgencySignUp, Categories.InteractiveTutorialCategory
			* Log.Step("Registration of new company");
			* Log.Step("View wizard");
			* Log.Step("Relogin to company");
* File: Articles.cs
	* Method: CheckLoadImagesInstallationInstructions
		* TestCaseLink: "https://www.wrike.com/open.htm?id=213578085"
		* Categories: Categories.ExcludingCategoryOnlyProductionSite, Categories.ArticlesCategory
* File: AssumeTests.cs
* File: AttachDocumentTests.cs
	* Method: AttachAcordPage
		* TestCaseLink: "Test case ID: AI-001 - https://docs.google.com/spreadsheets/d/1JaRs6EgNBftLh5rvSnNJijWmGUAS-8RVWMQvYgXK7so/edit#gid=212087228&range=2:5"
		* Categories: [UNDEFINED]
* File: AutoExpirationTests.cs
	* Method: AutoExpirationTest
		* TestCaseLink: "SP-EXP-13, SP-EXP-14 - https://docs.google.com/spreadsheets/d/1lOWuH2CnLtkYA067HcQ3ZKUjO_zdpUxU7lpVgct7rK0/edit#gid=928625084&range=29:35"
		* Categories: Categories.PolicyCategory
			* Log.Step("Log in as an agency user, create a WC RFQ and submit to a market");
			* Log.ExpectedResult("Check RFQ statuses on the agency and market sides");
			* Log.Step("Initiate an RFQ AutoExpiration process");
			* Log.ExpectedResult("Check RFQ statuses after AutoExpiration on the agency and market sides");
	* Method: Check_Auto_Expiration_Settings_Labels_Text
		* TestCaseLink: "SP-EXP-01, SP-EXP-02, SP-EXP-03 - https://docs.google.com/spreadsheets/d/1lOWuH2CnLtkYA067HcQ3ZKUjO_zdpUxU7lpVgct7rK0/edit#gid=928625084&range=2:7"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency user and open company's settings page");
			* Log.ExpectedResult("Check AutoExpiration setting's name, tooltip and absence of opportunity to disable it");
	* Method: Check_Save_Auto_Expiration_Settings
		* TestCaseLink: "SP-EXP-04 - https://docs.google.com/spreadsheets/d/1lOWuH2CnLtkYA067HcQ3ZKUjO_zdpUxU7lpVgct7rK0/edit#gid=928625084&range=8:10"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency user and set an initial value for the AutoExpiration setting");
			* Log.ExpectedResult("Check previously specified AutoExpiration setting's value");
			* Log.Step("Fill the AutoExpiration setting's value with random number");
			* Log.ExpectedResult("Check recently changed AutoExpiration setting's value");
* File: AutoRenewCheckboxTests.cs
	* Method: AutoRenewCheckboxCorrectVisible
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: CheckSaveAutoRenewSettings
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1f2iaDmDNuLIgQV0oqTT0k-HJvngsImds7py-vnJghjg/edit#gid=49592401&range=A2:G5"
		* Categories: [UNDEFINED]
* File: BillingIsSet.cs
	* Method: TrialIsNotStartedWhenAgencySubmittedToEmailMarketDateOfBillingIsToday
		* TestCaseLink: "FBS_004 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=1456290469&range=A25:A34"
		* Categories: [UNDEFINED]
	* Method: TrialIsNotStartedWhenAgencySubmittedToEmailMarketDateOfBillingLessThenToday
		* TestCaseLink: "FBS_003 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=1456290469&range=A18:A23"
		* Categories: [UNDEFINED]
	* Method: TrialIsNotStartedWhenAgentTryingToSendAcordFormsViaPressingOnEmailButtonOnFormsTab
		* TestCaseLink: "FBS_010 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=1456290469&range=A79:A85"
		* Categories: [UNDEFINED]
			* Log.Step("Create insured with rfq");
			* Log.Step("Go to Forms tab");
			* Log.Step("Press [Click here] button (if it is present)");
			* Log.Step("Select all forms");
			* Log.Step("Press on  [Email] button");
			* Log.ExpectedResult("There is 'Send email' modal window");
	* Method: TrialIsNotStartedWhenSubmittedToWeblinkMarket
		* TestCaseLink: "FBS_001 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=1456290469&range=A2:A6"
		* Categories: [UNDEFINED]
	* Method: TrialIsNotStartedWhenSubmittedToWeblinkMarketAndBillingDateIsToday
		* TestCaseLink: "FBS_002 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=1456290469&range=A8:A16"
		* Categories: [UNDEFINED]
	* Method: TrialWillBeStoppedWhenAgencyAddBillingForEmailMarketDateOfBillingLessThanToday
		* TestCaseLink: "FBS_006 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=1456290469&range=A46:A54"
		* Categories: [UNDEFINED]
	* Method: TrialWillBeStoppedWhenAgencyAddBillingForWeblinkMarketDateOfBillingIsToday
		* TestCaseLink: "FBS_005 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=1456290469&range=A36:A44"
		* Categories: [UNDEFINED]
* File: BlankFormsTests.cs
	* Method: BlankMasterFormIsAbleToDownloadTest
		* TestCaseLink: "Blank1: https://docs.google.com/spreadsheets/d/1c-n85yM4eX0FTdhkAoQDqgZzItawEBh_CXpyGeth2is/edit#gid=1863913192&range=A2:A4"
		* Categories: [UNDEFINED]
			* Log.Step("Log In to Appulate as Admin");
			* Log.Step("Hover mouse to TOOLS button and click on Blank Master Form");
			* Log.Step($"Choose {InsuranceLine.Gl.GetDescription()} into select Insurance Line");
			* Log.Step("Mark checkbox near ACORD");
	* Method: BlankSupplementalFormIsAbleToDownloadTest
		* TestCaseLink: "Blank2: https://docs.google.com/spreadsheets/d/1c-n85yM4eX0FTdhkAoQDqgZzItawEBh_CXpyGeth2is/edit#gid=1863913192&range=A5:A6"
		* Categories: [UNDEFINED]
			* Log.Step("Log In to Appulate as Admin");
			* Log.Step("Hover mouse to TOOLS button and click on Blank Master Form");
			* Log.Step($"Choose {InsuranceLine.Wc.GetDescription()} into select Insurance Line");
			* Log.Step("Mark checkbox near ACORD");
* File: BlockUnblockMarket.cs
	* Method: BlockMarket
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: BlockSelectedMarketImpossibleForUsers
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: UnblockMarket
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: BlogTests.cs
	* Method: CheckEventsPageOpening
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1-79w0U1pYfQ4MSn6moJzl-1beW4yJDMpto6xxxHrsso/edit#gid=0&range=A15:A16"
		* Categories: [UNDEFINED]
	* Method: CheckNewFeaturesPageOpening
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1-79w0U1pYfQ4MSn6moJzl-1beW4yJDMpto6xxxHrsso/edit#gid=0&range=A13:A14"
		* Categories: [UNDEFINED]
	* Method: CheckPressReleasesPageOpening
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1-79w0U1pYfQ4MSn6moJzl-1beW4yJDMpto6xxxHrsso/edit#gid=0&range=A11:A12"
		* Categories: [UNDEFINED]
* File: CarrierDirectTests.cs
	* Method: CheckErrorOnCarrierDirect
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: CheckMarketsWithErrorCouldNotBeSelected
		* TestCaseLink: "UplSelComp-03 : https://docs.google.com/spreadsheets/d/1WguLlLbsaRgWLybFqvSYfRrtn401x4c9gPg3_wp0GYI/edit#gid=803879324&range=A5 "
		* Categories: [UNDEFINED]
	* Method: SelectMarketsOneByOne
		* TestCaseLink: "UplSelComp-02 : https://docs.google.com/spreadsheets/d/1WguLlLbsaRgWLybFqvSYfRrtn401x4c9gPg3_wp0GYI/edit#gid=803879324&range=A4 "
		* Categories: [UNDEFINED]
* File: CarrierMatrix.cs
	* Method: RatingCarriersList
		* TestCaseLink: [UNDEFINED]
		* Categories: Categories.SmokeTestsCategory
			* Log.ExpectedResult($"No carrier at expected list: {market.MarketName}");
* File: CAutoRatingTests.cs
	* Method: RatingAndQuoteCavtoSutterAutoLiabilityAndMtc
		* TestCaseLink: "Bro-5 - https://docs.google.com/spreadsheets/d/1jBGIks6RAdLiDkkpQuthKhhCCvZu5KjPoSfyISvvWas/edit#gid=1884073390&range=A31:A36"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites, Categories.BrooksideGeneral
			* Log.Step("Create RFQ under MGA user and select carriers on Markets Selector");
			* Log.Step("Fill general questionnaire");
			* Log.Step("Select coverage and fill Limits & Deductibles Tab");
			* Log.Step("Fill additional questions");
			* Log.ExpectedResult("Premium is calculated, limits and deductibles are displayed");
			* Log.Step($"Open rating dialog for {sutterCarrier.Name} market");
			* Log.Step("Fill rating parameters");
			* Log.Step("Close rating dialog");
			* Log.ExpectedResult("Premium is calculated after rating tab modifications");
			* Log.Step("Upload Motor Vehicle Record to Docs tab");
			* Log.Step("Assign an agency and a producer");
			* Log.Step("Generate quote");
			* Log.ExpectedResult("Pdf file has same values as questionnaire");
	* Method: RatingAndQuoteCavtoSutterAutoLiabilityAndNonTrucking
		* TestCaseLink: "Bro-6 - https://docs.google.com/spreadsheets/d/1jBGIks6RAdLiDkkpQuthKhhCCvZu5KjPoSfyISvvWas/edit#gid=1884073390&range=A37:A41"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites, Categories.BrooksideGeneral
			* Log.Step("Create RFQ under MGA user and select carriers on Markets Selector");
			* Log.Step("Fill general questionnaire");
			* Log.Step("Select coverage and fill Limits & Deductibles Tab");
			* Log.Step("Fill additional questions");
			* Log.ExpectedResult("Premium is calculated, limits and deductibles are displayed");
			* Log.Step("Upload Motor Vehicle Record to Docs tab");
			* Log.Step("Assign an agency and a producer");
			* Log.Step("Generate quote");
			* Log.ExpectedResult("Pdf file has same values as questionnaire");
	* Method: RatingTabAffectOnlyCurrentCalculationBaseTest
		* TestCaseLink: "Bro-4 - https://docs.google.com/spreadsheets/d/1jBGIks6RAdLiDkkpQuthKhhCCvZu5KjPoSfyISvvWas/edit#gid=1884073390&range=A20:A29"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites, Categories.BrooksideGeneral
			* Log.Step("Create RFQ under MGA user and select carriers on Markets Selector");
			* Log.ExpectedResult("The premium warning indicators are displayed");
			* Log.Step("Fill questionnaire");
			* Log.Step("Fill coverage and deductible for markets");
			* Log.Step($"Open rating dialog for '{lloydsCarrier.Name}' market");
			* Log.Step("Fill rating parameters");
			* Log.ExpectedResult("Premium is calculated");
			* Log.Step("Close rating dialog");
			* Log.ExpectedResult("Premium is calculated");
			* Log.Step($"Open rating dialog for {sutterCarrier.Name} market");
			* Log.Step("Fill rating parameters");
			* Log.ExpectedResult("Premium is calculated");
			* Log.Step("Close rating dialog");
			* Log.ExpectedResult("Premium is calculated");
			* Log.Step("Create RFQ under MGA user and select carriers on Markets Selector");
			* Log.Step("Fill questionnaire");
			* Log.Step("Fill coverage and deductible for markets");
* File: ChangeFormTitle.cs
	* Method: ChangeFormTitleOnAdminSiteAndCheckOnMain
		* TestCaseLink: [UNDEFINED]
		* Categories: Categories.ExcludingCategoryOnlyTestingSites
* File: CheckMailSettingsDialog.cs
	* Method: Save_Settings_And_Check_On_Mail_Server_Dialog
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Validation_Is_Triggered_On_Mail_Server_Dialog
		* TestCaseLink: "SP-GEN-29 - https://docs.google.com/spreadsheets/d/1lOWuH2CnLtkYA067HcQ3ZKUjO_zdpUxU7lpVgct7rK0/edit#gid=0&range=52:52"
		* Categories: [UNDEFINED]
* File: ClassCodesTests.cs
	* Method: NcciClassCodesAutocompleteSelectionTest
		* TestCaseLink: "NCCI 02: https://docs.google.com/spreadsheets/d/1WuC1xwu4jhTlNHmZoXAxIV0ZW9R04Q22oVMg_0NXVHY/edit#gid=2052116066&range=A8:A13"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency user, create an insured and a WC RFQ");
			* Log.Step("Expand 'Payroll and Rating' collection");
			* Log.ExpectedResult("Check placeholder and list of autocomplete items");
			* Log.Step("Enter a class code and check a message from dropdown");
			* Log.Step("Enter another class code");
			* Log.ExpectedResult("Check that class code is filled correctly");
	* Method: SicClassCodesAutocompleteWorksAndInfotipDisplayed
		* TestCaseLink: "SA-1 SA-2 SA-3: https://docs.google.com/spreadsheets/d/1WuC1xwu4jhTlNHmZoXAxIV0ZW9R04Q22oVMg_0NXVHY/edit#gid=278611069&range=C2:C8"
		* Categories: [UNDEFINED]
			* Log.ExpectedResult("Check placeholder and list of autocomplete items");
			* Log.ExpectedResult("Check autocomplete items matching filled value");
			* Log.Step("Selecting code from dropwdown list");
			* Log.ExpectedResult("Check that classcode is filled correctly");
			* Log.ExpectedResult("Check field's color");
			* Log.ExpectedResult("Check infotip's description");
			* Log.ExpectedResult("Check infotip's closing");
	* Method: SicClassCodesLookUpAndItsInternalsDisplayAndWork
		* TestCaseLink: "SA-4 SA-5 SA-6: https://docs.google.com/spreadsheets/d/1WuC1xwu4jhTlNHmZoXAxIV0ZW9R04Q22oVMg_0NXVHY/edit#gid=278611069&range=C9:C17"
		* Categories: [UNDEFINED]
			* Log.Step("Open Class Code look up dialog");
			* Log.ExpectedResult("Check lookup internals");
			* Log.Step("Click filter button in lookup");
			* Log.ExpectedResult("Check Additional Filter dropdowns' state");
			* Log.ExpectedResult("Check Division's dropdown list");
			* Log.Step("Select Division");
			* Log.ExpectedResult("Check amount of class codes pages and filters after selecting division");
			* Log.Step("Select major group");
			* Log.ExpectedResult("Check amount of class codes pages and filters after selecting major group");
			* Log.Step("Select industry group");
			* Log.ExpectedResult("Check amount of displayed codes and filters after selecting industry group");
			* Log.Step("Click filter button in lookup");
			* Log.ExpectedResult("Check applied filters are dropped");
			* Log.Step("Fill out search field");
			* Log.ExpectedResult("Check filtered list of codes");
			* Log.Step("Select code");
			* Log.ExpectedResult("Check that classcode is filled correctly");
			* Log.ExpectedResult("Check field's color");
* File: ClientSideStatistics.cs
	* Method: CheckPeriodTransformation
		* TestCaseLink: "AdmPgs2 - https://docs.google.com/spreadsheets/d/1imd2RMJVeeJcOfCsHTDJPoUIg2NrcSLQpa-3xjsMA58/edit#gid=0&range=B3:B7"
		* Categories: Categories.AdminSiteTestsCategory
* File: CommissionTrackerTests.cs
	* Method: CheckCommissionTabInPolicyNonExistentMarket
		* TestCaseLink: "CT_02 - https://docs.google.com/spreadsheets/d/1oIxk84Wm-s_4t8JX2VeYac2g2CP5DiV6MSN6Wddp4UQ/edit#gid=0&range=A14:I16"
		* Categories: [UNDEFINED]
	* Method: CheckCommissionTabIsHiddenForViewerRole
		* TestCaseLink: "CT_09 - https://docs.google.com/spreadsheets/d/1oIxk84Wm-s_4t8JX2VeYac2g2CP5DiV6MSN6Wddp4UQ/edit#gid=0&range=A50:A51"
		* Categories: [UNDEFINED]
	* Method: CheckDefaultCommissionAndFeeForPolicyWithoutSourceAgency
		* TestCaseLink: "AS-02 - https://docs.google.com/spreadsheets/d/1oIxk84Wm-s_4t8JX2VeYac2g2CP5DiV6MSN6Wddp4UQ/edit#gid=94251396&range=A7:A9"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an MGA user and create an RFQ");
			* Log.ExpectedResult("Make sure that the 'Source agency' control is empty");
			* Log.Step("Submit to a carrier and bind policy on the carrier side");
			* Log.Step("Open the 'Commission' tab");
			* Log.Step("Log in as an MGA user and open Policy");
	* Method: CheckDefaultCommissionAndFeeSetForSelectedAgency
		* TestCaseLink: "AS-01 - https://docs.google.com/spreadsheets/d/1oIxk84Wm-s_4t8JX2VeYac2g2CP5DiV6MSN6Wddp4UQ/edit#gid=94251396&range=A2:A6"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an MGA user and open 'Programs' tab of an Agency Info page");
			* Log.ExpectedResult("Check that actual commission and fee values are equal to default");
			* Log.Step("Change default commission and fee values");
			* Log.ExpectedResult("Make sure that new values are saved correctly");
			* Log.Step("Log in as an agency user, create an RFQ, submit to a carrier through an MGA and bind policy");
			* Log.Step("Open the 'Commission' tab");
			* Log.Step("Log in as an MGA user and open Policy");
	* Method: CheckPremiumSynchronizationInCommissionAndOptionsTabs
		* TestCaseLink: "CT_08 - https://docs.google.com/spreadsheets/d/1oIxk84Wm-s_4t8JX2VeYac2g2CP5DiV6MSN6Wddp4UQ/edit#gid=0&range=A40:A48"
		* Categories: [UNDEFINED]
	* Method: CheckProgramsTabIsHiddenForUsers
		* TestCaseLink: "AS-03.1 - https://docs.google.com/spreadsheets/d/1oIxk84Wm-s_4t8JX2VeYac2g2CP5DiV6MSN6Wddp4UQ/edit#gid=94251396&range=A10:A11"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an MGA user and open Agency info page");
			* Log.ExpectedResult("Make sure that the 'Programs' tab is hidden for a users with 'User' role");
* File: ConfirmationOnDeletionDocumentsTests.cs
	* Method: DeleteUploadedQuoteDocumentByAgencyUser
		* TestCaseLink: "QD-2: https://docs.google.com/spreadsheets/d/1oqbYdT3X3x_Pixt-pzS1H7H_eNxX8ZrLZ3oWTVeHbJU/edit#gid=315219895&range=A4:A6"
		* Categories: [UNDEFINED]
			* Log.ExpectedResult("Submit on market is successful. Market's status is 'Submitted'");
			* Log.Step("Upload quote");
			* Log.ExpectedResult("'Delete quote' action is available for the uploaded quote");
			* Log.Step("Log in as market user. Upload and Release quote for currently received RFQ");
			* Log.ExpectedResult("For the appeared quote 'Delete Action' is available. For the agency quote there is no 'Delete Quote' button");
			* Log.Step("Return to agency side. Find recently submitted RFQ and delete uploaded quote");
			* Log.ExpectedResult("Agency quote is removed. Kebab-menu for the uploaded quote from the market side doesn't contain 'Delete quote' button");
	* Method: DeleteUploadedQuoteDocumentTest
		* TestCaseLink: "QD-1: https://docs.google.com/spreadsheets/d/1oqbYdT3X3x_Pixt-pzS1H7H_eNxX8ZrLZ3oWTVeHbJU/edit#gid=315219895&range=A2:A3"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as a market user and create an RFQ with random insurance line");
			* Log.Step("Upload a quote document under self-market and assign a source agency");
			* Log.Step("Delete recently uploaded quote document");
* File: ContactRolesContactEditorTests.cs
	* Method: CopyInsuredContactTest
		* TestCaseLink: "Case IU_3: https://docs.google.com/spreadsheets/d/1R7LgID9Ek0FylTu8FyT-m4P8Ex8puUJyNGITJg_hbOU/edit#gid=0&range=A17:A19"
		* Categories: [UNDEFINED]
	* Method: NewInsuredContactOnSendLossRunRequest
		* TestCaseLink: [UNDEFINED]
		* Categories: Categories.SentDocumentForSignCategory, Categories.LossRunsCategory, Categories.ExcludingCategoryOnlyTestingSites
	* Method: NewMainInsuredContact
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: NewMainInsuredContactExistsOnContactsGrid
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: ContactsTests.cs
	* Method: SendAutoquoteToSignProcess
		* TestCaseLink: "TC ID: C_1 - https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=1446024199&range=A2"
		* Categories: Categories.SentDocumentForSignCategory, Categories.ExcludingCategoryOnlyTestingSites
			* Log.Step("Create RfQ, check markets and fill out questionnaire");
			* Log.Step("Submit RfQ to the root-market");
* File: ContrEquipRatingTests.cs
	* Method: CheckGridIronPremium
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: Controls.cs
	* Method: CheckPhoneNumberFieldFormattingAndErrorMessageOnInsuredSummaryPage
		* TestCaseLink: "ISPN-1: https://docs.google.com/spreadsheets/d/1JaRs6EgNBftLh5rvSnNJijWmGUAS-8RVWMQvYgXK7so/edit#gid=1557511151&range=5:7"
		* Categories: [UNDEFINED]
			* Log.Step("Log in and go to insured's summary page");
			* Log.ExpectedResult("Placeholder of 'Phone' field has expected value");
			* Log.Step("Set invalid value to 'Phone' field");
			* Log.ExpectedResult("There is exception message of 'Phone' field");
			* Log.Step("Set valid value to 'Phone' field");
			* Log.ExpectedResult("There is expected 'Phone' field formatting AND there is NO error message");
* File: CraneRatingTests.cs
	* Method: DcsEditingOnMarketSide
		* TestCaseLink: "ASR-1: https://docs.google.com/spreadsheets/d/1GItP9ddL4AQ_v_bcTj5_PTbMrhMVLsUq5uMfRot8GwE/edit#gid=0&range=A2:A29"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites
	* Method: EstPremiumVisibilityGeneratedQd
		* TestCaseLink: "ASR-3: https://docs.google.com/spreadsheets/d/1GItP9ddL4AQ_v_bcTj5_PTbMrhMVLsUq5uMfRot8GwE/edit#gid=0&range=A44:A65"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites, Categories.SentDocumentForSignCategory
	* Method: EstPremiumVisibilityUploadedQd
		* TestCaseLink: "ASR-2: https://docs.google.com/spreadsheets/d/1GItP9ddL4AQ_v_bcTj5_PTbMrhMVLsUq5uMfRot8GwE/edit#gid=0&range=A30:A43"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites
* File: CreateApplication.cs
	* Method: CreateInsuredAndPolicyUsingMoveDocumentButtonTest
		* TestCaseLink: "CIMD_3 - https://docs.google.com/spreadsheets/d/1xhGkC98ZzODL-REa63wVl7qsxEO2o5HliNsaiR9tG4c/edit#gid=0&range=A8"
		* Categories: [UNDEFINED]
	* Method: CreateInsuredAndRfqUsingMoveDocumentButtonTest
		* TestCaseLink: "CIMD_2 - https://docs.google.com/spreadsheets/d/1xhGkC98ZzODL-REa63wVl7qsxEO2o5HliNsaiR9tG4c/edit#gid=0&range=A5" +
		                                  "ILD-3 - https://docs.google.com/spreadsheets/d/1ewcCF2bHQJF89ghEVM0Cnkq3vRhAx2QhM-KDbV7wYCs/edit#gid=929743611&range=A10:A13"
		* Categories: [UNDEFINED]
	* Method: CreateInsuredUsingMoveDocumentButtonTest
		* TestCaseLink: "CIMD_1 - https://docs.google.com/spreadsheets/d/1xhGkC98ZzODL-REa63wVl7qsxEO2o5HliNsaiR9tG4c/edit#gid=0&range=A2"
		* Categories: [UNDEFINED]
	* Method: CreateNewPolicyForExistingInsuredUsingMoveButtonTest
		* TestCaseLink: "CIMD_6 - https://docs.google.com/spreadsheets/d/1xhGkC98ZzODL-REa63wVl7qsxEO2o5HliNsaiR9tG4c/edit#gid=0&range=A18"
		* Categories: [UNDEFINED]
	* Method: CreateNewRfqForExistingInsuredUsingMoveButtonTest
		* TestCaseLink: "CIMD_5 - https://docs.google.com/spreadsheets/d/1xhGkC98ZzODL-REa63wVl7qsxEO2o5HliNsaiR9tG4c/edit#gid=0&range=A15"
		* Categories: [UNDEFINED]
	* Method: DuplicateInsuranceLineAndDatesCreateNewTest
		* TestCaseLink: "EM_1 - https://docs.google.com/spreadsheets/d/18ucFDX8Fqq8Vpt6IM-AhfMlKe9_yXI--dJKRw2DlDH8/edit#gid=0&range=A2:A3"
		* Categories: [UNDEFINED]
	* Method: DuplicateInsuranceLineAndDatesUploadDocTest
		* TestCaseLink: "EM_2 - https://docs.google.com/spreadsheets/d/18ucFDX8Fqq8Vpt6IM-AhfMlKe9_yXI--dJKRw2DlDH8/edit#gid=0&range=A4:A6"
		* Categories: [UNDEFINED]
	* Method: MoveDocumentFromRfqToAnotherExistingRfqUsingMoveButtonTest
		* TestCaseLink: "CIMD_7 - https://docs.google.com/spreadsheets/d/1xhGkC98ZzODL-REa63wVl7qsxEO2o5HliNsaiR9tG4c/edit#gid=0&range=A22"
		* Categories: [UNDEFINED]
	* Method: MoveDocumentFromRfqToAnotherInsuredUsingMoveDocumentButtonTest
		* TestCaseLink: "CIMD_4 - https://docs.google.com/spreadsheets/d/1xhGkC98ZzODL-REa63wVl7qsxEO2o5HliNsaiR9tG4c/edit#gid=0&range=A12"
		* Categories: [UNDEFINED]
* File: CreateMarketUserTests.cs
	* Method: AddingNewUserForCompanyOnAdminSite
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
			* Log.Step("Log in to Admin site as root user");
			* Log.Step("Open All Companies grid and open Users tab of any test company");
			* Log.Step("For opening Edit User dialog window click [Add User] button");
			* Log.Step("Fill fields with Test Data and click [Save] button");
			* Log.Step("Open 'Appulate: Your Login Information' notification and click 'here' link");
			* Log.Step("Enter any valid password to CHANGE PASSWORD field and click [Submit] button");
			* Log.Step("Enter Email and Password for added user and click [Sign In] button");
			* Log.Step("Go to All Companies grid - Users tab and click to Edit user icon for added user");
			* Log.Step("Uncheck Root checkbox and click [Save] button");
			* Log.Step("Logout -> enter Email and Password -> click [Sign In] button");
	* Method: CreateNewMarketUser
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: TryCreateUserWithNotUniqueEmail
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: DefaultMarketSelectionLogicTests.cs
	* Method: SubmarketVisible
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: DeletingOfMArketsOnMarketsSelector.cs
	* Method: ImpossibleToRemoveMarketFromMarketsSelectorAfterSubmission
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
			* Log.Step("Open qa page if it is not opened");
			* Log.Step($"Select the '{market.Name}' and submit to it");
			* Log.ExpectedResult("It is impossible to remove market from MS. There is no 'Remove market' action ");
	* Method: MarketNotSelectedOnMarketsSelectorNotPresentedOnGridIfItIsDeselectedOnSelectedMarketsPage
		* TestCaseLink: [UNDEFINED]
		* Categories: Categories.SmokeTestsCategory
			* Log.Step("Open qa page if it is not opened");
			* Log.Step($"Deselect the '{market.Name}' on Markets Selector");
			* Log.Step($"Open Selected Markets page and deselect '{market.Name}'");
			* Log.Step("Return to the qa page");
			* Log.ExpectedResult($"The '{market.Name}' market is not available for selection on Markets Selector");
	* Method: MarketSelectedOnMarketsSelectorRemainsOnGridIfItIsDeselectedOnSelectedMarketsPage
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
			* Log.Step("Open qa page if it is not opened");
			* Log.Step($"Select the '{market.Name}'");
			* Log.ExpectedResult($"The '{market.Name}' market is selected and visible on Markets selector");
			* Log.Step($"Open Selected Markets page and deselect '{market.Name}'");
			* Log.Step("Return to the qa page");
			* Log.ExpectedResult($"The '{market.Name}' market is presented on Markets Selector grid after it is removed on the Selected Markets page");
* File: DocumentsListInEmailEditorTests.cs
	* Method: VisibleDocumentsInEmailEditor
		* TestCaseLink: "AE-1 - AE-4 https://docs.google.com/spreadsheets/d/1c-n85yM4eX0FTdhkAoQDqgZzItawEBh_CXpyGeth2is/edit#gid=1475209817&range=A2:A12"
		* Categories: [UNDEFINED]
			* Log.Step("Click 'Send email to:' in Main contact section. Click 'Add Existing' button");
			* Log.Step("Open Forms tab. Click 'Send by Email' for documents");
			* Log.Step("Open Loss Runs tab. Click 'Send by Email' for attached doc");
			* Log.Step("Open Docs tab. Click 'Send by Email' for any doc");
* File: DownloadDocuments.cs
	* Method: DownloadDocs
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: DownloadForm
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: DownloadLossRun
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: DownloadPolicyDocument
		* TestCaseLink: [UNDEFINED]
		* Categories: Categories.PolicyCategory
	* Method: DownloadQuoteDocument
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: DownloadDocumentsTests.cs
	* Method: CheckDownloadingExcelFileByExportToExcelButtonInAllCompaniesGrid
		* TestCaseLink: "ExpExc-1: https://docs.google.com/spreadsheets/d/1y5Nsw1F6Ioo4Bvf45w56jY2FmJQnvYPAFkXlZIvvk-E/edit#gid=0&range=A6"
		* Categories: Categories.AdminSiteTestsCategory
			* Log.Step("Go to all companies page of admin side AND download list of companies");
			* Log.ExpectedResult("An excel file has downloaded");
	* Method: DownloadFromQaSectionOfFormsTab
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
			* Log.Step($"Create insured with state '{app.Insured.State}' and create '{InsuranceLine.Gl.GetDescription()}' rfq");
			* Log.Step("Open forms page");
			* Log.Step("Select document(s)");
			* Log.Step("Go to edit form page");
			* Log.ExpectedResult("There is(are) selected supplemental document(s)");
			* Log.Step("Download document");
			* Log.ExpectedResult("Document is downloaded");
	* Method: PolicyDocumentIsDownloadedFromDocumentsGridOnPolicyDocsPage
		* TestCaseLink: "PolGener-004: https://docs.google.com/spreadsheets/d/1mHHonW3ITyfeY-mnTeKq9P-gcw-Jyv52L90zX1HpSkw/edit#gid=110187460&range=15:16"
		* Categories: [UNDEFINED]
			* Log.ExpectedResult("Generated policy is appeared on the grid with policy docs");
			* Log.Step("Click on the policy doc");
	* Method: PolicyDocumentIsDownloadedFromMarketRowOnPolicyPage
		* TestCaseLink: "PolGener-003: https://docs.google.com/spreadsheets/d/1mHHonW3ITyfeY-mnTeKq9P-gcw-Jyv52L90zX1HpSkw/edit#gid=110187460&range=13:14"
		* Categories: [UNDEFINED]
			* Log.ExpectedResult("Generated policy is appeared on the grid in the POLICY column");
			* Log.Step("Click on the Policy doc");
	* Method: PolicyDocumentIsDownloadedFromPolicyDocumentStructurePage
		* TestCaseLink: "PolGener-006: https://docs.google.com/spreadsheets/d/1mHHonW3ITyfeY-mnTeKq9P-gcw-Jyv52L90zX1HpSkw/edit#gid=110187460&range=21:24"
		* Categories: [UNDEFINED]
			* Log.Step("Click on Send by Email button and click policy name link in attachment");
	* Method: PolicyDocumentIsDownloadedFromSendEmailModalWindowOnPolicyDocsPage
		* TestCaseLink: "PolGener-005: https://docs.google.com/spreadsheets/d/1mHHonW3ITyfeY-mnTeKq9P-gcw-Jyv52L90zX1HpSkw/edit#gid=110187460&range=17:20"
		* Categories: [UNDEFINED]
			* Log.Step("Click on Send by Email button and click policy name link in attachment");
* File: DownloadingOfDocsAsInsuredTests.cs
	* Method: DownloadPolicyDoc
		* TestCaseLink: [UNDEFINED]
		* Categories: Categories.PolicyCategory
* File: DuplicateAgencyRegistrationTests.cs
	* Method: RegisterAgencyWithPublicServiceEmailDomain
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1ldCkNdi0iC1-aBwioTNrO0hOvwNtNJGcmux4CUFTX3E/edit#gid=0&range=A21"
		* Categories: [UNDEFINED]
	* Method: RegisterAgencyWithValidInfo
		* TestCaseLink: "001REG - https://docs.google.com/spreadsheets/d/1ldCkNdi0iC1-aBwioTNrO0hOvwNtNJGcmux4CUFTX3E/edit#gid=276363832&range=2:6"
		* Categories: [UNDEFINED]
* File: EditUserDetails.cs
	* Method: EditMarketsCredentialsOnMyDetails
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: EmailNotificationsUnsubscriptionTests.cs
	* Method: CheckEmailNotificationsUnsubscriptionProcessUsingEmailLink
		* TestCaseLink: "1 - https://docs.google.com/spreadsheets/d/1R036TRBe699GvShzVZIy0F0lX79VrN4VtP-8HsdBzeg/edit#gid=0&range=A2:A18"
		* Categories: [UNDEFINED]
	* Method: CheckEmailNotificationsUnsubscriptionProcessUsingProfileSettings
		* TestCaseLink: "2 - https://docs.google.com/spreadsheets/d/1R036TRBe699GvShzVZIy0F0lX79VrN4VtP-8HsdBzeg/edit#gid=0&range=A19:A38"
		* Categories: [UNDEFINED]
* File: EmailTemplates.cs
	* Method: CheckDefaultTemplatesAvailable
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: CreateTemplate
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
			* Log.Step($"Template name: {templateName}");
	* Method: EditDefaultSubmitTemplate
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: SendPreselectedTemplate
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: EncinoInvitationPageUrl.cs
	* Method: CheckMarketInvitationPageContent
		* TestCaseLink: "LP-3 https://docs.google.com/spreadsheets/d/1-79w0U1pYfQ4MSn6moJzl-1beW4yJDMpto6xxxHrsso/edit#gid=1906949596&range=A12"
		* Categories: [UNDEFINED]
			* Log.Step("Open market's 'Join on appulate page' and click 'Sign In & Download Uplink™'");
			* Log.Step("Click 'Sign Up'");
			* Log.Step("Click 'Video play button'");
	* Method: LandingPageSettingIsVisible
		* TestCaseLink: "LP-2 https://docs.google.com/spreadsheets/d/1-79w0U1pYfQ4MSn6moJzl-1beW4yJDMpto6xxxHrsso/edit#gid=1906949596&range=A7," +
		                                  "SP-GEN-34 https://docs.google.com/spreadsheets/d/1lOWuH2CnLtkYA067HcQ3ZKUjO_zdpUxU7lpVgct7rK0/edit#gid=0&range=A61:A63"
		* Categories: [UNDEFINED]
* File: Excelntegration.cs
	* Method: GetInsuredInExcel
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: GetPoliciesInExcel
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: GetQuotesInExcel
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: GetRecordActivityLogInExcel
		* TestCaseLink: "ALTETE_001: https://docs.google.com/spreadsheets/d/1hHZsRjSo-W5NPhqACTbvNWkMYCMtP3uoBiiJ8-2cbTY/edit#gid=781661021&range=A2:A6"
		* Categories: [UNDEFINED]
* File: ExternalRequestContentTest.cs
	* Method: AmTrustWcExternalQuoteGenerationClassCodesMapping
		* TestCaseLink: "AmTrust-WC-ClassCodes-API-Call-01: https://docs.google.com/spreadsheets/d/1Fxh5RiDMOWikMOCB_TC9bI5ysTVVUwfciVu5OkrBFLM/edit#gid=0&range=A8:A13"
		* Categories: Categories.Clients.External.AmTrustWc
			* Log.Step($"Log in as an '{_.Mga}' user and create a WC RFQ");
			* Log.Step("Select market on Markets Selector");
			* Log.Step("Fill in questionnaire");
			* Log.Step("Select limits using QP dialog");
			* Log.ExpectedResult($"Primary button for the {_.CarrierN(1)} is {MarketsSelectorAction.Submit}");
			* Log.Step("Perform submit");
			* Log.Step("Open Activity log and check quote request tech data");
	* Method: EmployersWcAcordXmlSecondRequest
		* TestCaseLink: "Empl-WC-Xml-01: https://docs.google.com/spreadsheets/d/1x3w1Xsui2tInaWrykTyzriynK5RUdS2dPiK_Hi6QBJk/edit#gid=0&range=A4"
		* Categories: Categories.Clients.External.EmployersWc
			* Log.Step("Create RFQ WC-line on Agency side");
			* Log.Step($"Select '{_.CarrierN(1).Name}' market on Markets Selector");
			* Log.Step("Fill in questionnaire to A-indicator");
			* Log.Step("Assign current Agent as producer on Rfq");
			* Log.Step("Select limits");
			* Log.Step("Perform Submit -> Request quote from external service");
			* Log.ExpectedResult("Check quote document count ");
			* Log.Step("Extract part of XML Quote request after first attempt");
			* Log.Step("Delete quote on Markets Selector");
			* Log.Step("Request quote from external service");
			* Log.Step("Extract part of XML Quote request after second attempt");
			* Log.ExpectedResult("Compare first and second Xml Requests");
			* Log.Step("Return to QA page and open QP dialog");
			* Log.Step("Open Payment Plan tab and select a value");
			* Log.Step("Request quote from external service on Market Side");
			* Log.Step($"Extract part of XML Quote request after first attempt from '{_.CarrierN(1)}' side");
			* Log.ExpectedResult("Compare Xml request on Market side and second Xml Requests on Agency side");
	* Method: HullWestchesterAcordXmlTest
		* TestCaseLink: "HW-AcordXml-01 - https://docs.google.com/spreadsheets/d/1x3w1Xsui2tInaWrykTyzriynK5RUdS2dPiK_Hi6QBJk/edit#gid=0&range=A2:A3"
		* Categories: Categories.Clients.External.HullAndCompanyBop
			* Log.Step("Create RFQ BOP-line on Agency side");
			* Log.Step($"Select Mga '{_.Mga.Name}' and carrier '{_.CarrierN(1).Name}' on Markets Selector");
			* Log.Step("Fill in questionnaire to A-indicator");
			* Log.Step("Assign current Agent as producer on Rfq");
			* Log.Step("Perform Submit -> Request quote from external service");
			* Log.ExpectedResult("Check quote document count");
			* Log.ExpectedResult("Check quote document request XML content in Activity log");
* File: ExternalServicesAvailabilityTests.cs
	* Method: InsurityServiceAvailable
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
			* Log.ExpectedResult($"The following url is available {urlToCheck.AbsoluteUri}");
* File: FeinSsnField.cs
	* Method: FeinOnFormIsCopiedFromFeinOnInfo
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: FeinOnInfoIsUpdatedFromFeinOnForm
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: FeinSsnVisibilityField
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: SettingIsDisabledUnderMarketUrl
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: Filling.cs
	* Method: FillForm
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: HiddenQuestionsAreNotMarkedNoAfterUsingMarkAllNo
		* TestCaseLink: "MAN-4 : https://docs.google.com/spreadsheets/d/1JaRs6EgNBftLh5rvSnNJijWmGUAS-8RVWMQvYgXK7so/edit#gid=1864005373&range=A37:A40"
		* Categories: [UNDEFINED]
			* Log.Step("Create RFQ AND select market");
			* Log.ExpectedResult("Market on market's selector AND question is collapsed in section Yes/No");
			* Log.Step("Click 'Mark All Questions No' and Expand parent question");
			* Log.ExpectedResult("Questions answered correct");
			* Log.Step("Switch to another tab AND add collection AND collapse control 'Owner' AND mark all Yes/No questions to no");
			* Log.ExpectedResult("Control is expanded AND answered NO");
			* Log.ExpectedResult("Parent's subquestion expanded and not answered");
* File: FillingRequestSendingTests.cs
	* Method: DisablingQuestionnaireAfterCompleteButton
		* TestCaseLink: "SQTC_04: https://docs.google.com/spreadsheets/d/1fBTtzTZ_54NTwNftC_I4mytw8wfrldMbD6KBwsCDtmw/edit#gid=1232656605&range=A96:A106"
		* Categories: [UNDEFINED]
			* Log.Step("Create RFQ and open QA page");
			* Log.Step("Perform SQTC and open RFQ");
			* Log.ExpectedResult("Questionnaire is enabled");
			* Log.Step("Click complete button");
			* Log.ExpectedResult("Questionnaire is disabled");
	* Method: SendFormToCompleteToMainContactAndCheckFillingRequiredQuestionsByMainContact
		* TestCaseLink: "SRTC_06 : https://docs.google.com/spreadsheets/d/1fBTtzTZ_54NTwNftC_I4mytw8wfrldMbD6KBwsCDtmw/edit#gid=1232656605&range=A119:A123"
		* Categories: [UNDEFINED]
			* Log.Step("Create Insured AND RFQ");
			* Log.Step($"Select '{Markets.EncinoInsuranceCo}' market");
			* Log.Step("Add main contact");
			* Log.Step("Open Forms tab");
			* Log.Step($"Send '{docName}' doc to complete");
			* Log.Step($"Go to '{typeof(RequestToCompletePage)}' page");
			* Log.Step("Fill a question");
* File: FormsAvailabilityTests.cs
	* Method: AcordAndFigDownload
		* TestCaseLink: "AllForms_0016 : https://docs.google.com/spreadsheets/d/1imd2RMJVeeJcOfCsHTDJPoUIg2NrcSLQpa-3xjsMA58/edit#gid=0&range=44:47"
		* Categories: [UNDEFINED]
			* Log.Step("Open and filter grid");
			* Log.ExpectedResult("Actions buttons are expected to be Enabled");
			* Log.ExpectedResult("Buttons should provide documents download");
	* Method: FormPresentsByQaTrigger
		* TestCaseLink: "SDA_07 : https://docs.google.com/spreadsheets/d/1jHMgFNygv6ykhnRZDtTiszBYIQBMGI1y-iwOJPkEfYw/edit#gid=0&range=A36:A38"
		* Categories: [UNDEFINED]
			* Log.Step("Deselect all the markets, if any selected");
			* Log.ExpectedResult("Go to Forms tab, check available forms are not containing Atlas supplemental");
			* Log.Step("Go to Q&A, select market Atlas General Insurance Services Testing, and change contractor's question state to Yes");
			* Log.ExpectedResult("Go to Forms tab, check if Atlas supplemental is shown now");
* File: FormsDownloading.cs
	* Method: DownloadForm
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: FormsProductionTests.cs
	* Method: CheckCreatingForm
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: ForthcomingSubmissionsGridTests.cs
	* Method: RecordDisappearsFromFsGridIfMarketUnselectedTest
		* TestCaseLink: "FS_2 - https://docs.google.com/spreadsheets/d/1TNc8VONemJNIS6H2tJ-5CpgPZk4XZRPJWEtEVxCQFTM/edit#gid=0&range=A7"
		* Categories: [UNDEFINED]
	* Method: RecordDisappearsFromFsGridIfRfqIsBoundByAnotherMarketTest
		* TestCaseLink: "FS_3 - https://docs.google.com/spreadsheets/d/1TNc8VONemJNIS6H2tJ-5CpgPZk4XZRPJWEtEVxCQFTM/edit#gid=0&range=A9"
		* Categories: [UNDEFINED]
	* Method: RecordsAdditionToForthcomingSubmissionsGridLogicTest
		* TestCaseLink: "FS_1 - https://docs.google.com/spreadsheets/d/1TNc8VONemJNIS6H2tJ-5CpgPZk4XZRPJWEtEVxCQFTM/edit#gid=0&range=A3"
		* Categories: [UNDEFINED]
* File: GeneralPrequalificationTests.cs
	* Method: CheckCategorySelectStaysRequiredAfterAnswerOnTypeQuestionInVehicleDescriptionCollection
		* TestCaseLink: "Preq_001 : https://docs.google.com/spreadsheets/d/13Q9CJn7UdV_dOI9UN4_LTlzRmbzhoZTInD1JT7uDnaQ/edit#gid=0&range=A2:K6"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency admin user and create a Automobile RFQ");
			* Log.ExpectedResult("There are sections for Default form of Automobile-Business line");
			* Log.ExpectedResult($"There are '{feinLabel}', '{locationsLabel}', '{vehicleDescriptionLabel}' controls/collections");
			* Log.Step($"Select '{Markets.AmericanFamilyBrokerageIncTest.Name}' market and '{Markets.Progressive.Name}' submarket");
			* Log.Step($"Add collection to '{vehicleDescriptionLabel}'");
			* Log.Step($"'{categoryLabel}' field becomes non-required and has '{trailerAnswer}' value");
			* Log.Step($"In '{vehicleDescriptionLabel}' collection in '{typeLabel}' select option '{nineteenEightyOneOrNewerVehicleAnswer}'");
			* Log.ExpectedResult($"'{categoryQuestion}' field becomes required and set to '{notSelectedAnswer}' value");
			* Log.Step($"In '{categoryLabel}' dropdown choose '{busAnswer}' option");
			* Log.ExpectedResult($"'{categoryLabel}' filed becomes non-required");
	* Method: CheckDefaultFormBindingWithoutSpecificFormAssignChain
		* TestCaseLink: "Preq_013: https://docs.google.com/spreadsheets/d/13Q9CJn7UdV_dOI9UN4_LTlzRmbzhoZTInD1JT7uDnaQ/edit?pli=1#gid=1360715977&range=A17:A19"
		* Categories: [UNDEFINED]
			* Log.Step($"Logging as user of {marketEncino} market, creating GL RFQ and assigning {marketWestlake} as Source Agency");
			* Log.ExpectedResult("Only Subject and Policy sections are displayed");
			* Log.ExpectedResult("Subject section contains 1 required question, Policy - 4 required questions");
			* Log.ExpectedResult($"{marketWestlake} is selected as Source Agency");
			* Log.Step($"Logging as user of {marketWestlake} market, opening assigned RFQ and assigning {marketSpecificForm} as Source Agency");
			* Log.ExpectedResult($"Questionnaire is similar to one on {marketEncino} side");
			* Log.ExpectedResult($"{marketSpecificForm} is selected as Source Agency");
			* Log.Step($"Logging as user of {marketSpecificForm} market, opening assigned RFQ");
			* Log.ExpectedResult($"Questionnaire is similar to one on {marketSpecificForm} side");
	* Method: CheckDefaultFormBindingWithoutSpecificFormSubmissionChain
		* TestCaseLink: "Preq_012: https://docs.google.com/spreadsheets/d/13Q9CJn7UdV_dOI9UN4_LTlzRmbzhoZTInD1JT7uDnaQ/edit?pli=1#gid=1360715977&range=A13:A16"
		* Categories: [UNDEFINED]
			* Log.Step($"Logging as user of {marketSpecificForm} market, deselecting {marketEncino} as root market and selecting it as submarket of {marketWestlake} market");
			* Log.ExpectedResult("Only Subject and Policy sections are displayed");
			* Log.ExpectedResult("Subject section contains 1 required question, Policy - 4 required questions");
			* Log.Step($"Filling out questionnaire and submitting to {marketWestlake} market");
			* Log.Step($"Logging as user of {marketWestlake} market, opening submitted RFQ and submitting to {marketEncino} market");
			* Log.ExpectedResult($"Questionnaire is similar to one on {marketSpecificForm} side");
			* Log.Step($"Logging as user of {marketEncino} market, opening submitted RFQ");
			* Log.ExpectedResult($"Questionnaire is similar to one on {marketWestlake} side");
	* Method: CheckPrequalificationDisplayDependenceOnProgramBindingSetting
		* TestCaseLink: "Preq_007: https://docs.google.com/spreadsheets/d/13Q9CJn7UdV_dOI9UN4_LTlzRmbzhoZTInD1JT7uDnaQ/edit#gid=921652564&range=A2:A6"
		* Categories: [UNDEFINED]
			* Log.Step("Opening market's program, it's binding and enabling prequalification for form");
			* Log.Step("Logging as agency user, creating GL RFQ and selecting market");
			* Log.ExpectedResult("Only Subject and Policy sections are displayed");
			* Log.ExpectedResult("Required question counters are shown");
			* Log.ExpectedResult("Indicator is displayed");
			* Log.Step("Opening market's program, it's binding and disabling prequalification for form");
			* Log.Step("Reopening previously created RFQ");
			* Log.ExpectedResult("Four sections are displayed");
			* Log.ExpectedResult("No required questions are displayed");
			* Log.ExpectedResult("Indicator is not displayed");
	* Method: CheckPrequalificationDisplayDependenceOnProgramBindingSettingForPackageLine
		* TestCaseLink: "Preq_008: https://docs.google.com/spreadsheets/d/13Q9CJn7UdV_dOI9UN4_LTlzRmbzhoZTInD1JT7uDnaQ/edit#gid=921652564&range=A13:A23"
		* Categories: [UNDEFINED]
			* Log.Step("Opening market's program, it's binding and enabling prequalification for form");
			* Log.Step("Logging as agency user, creating CPKGE+WC RFQ and selecting market");
			* Log.ExpectedResult("Four sections are displayed");
			* Log.ExpectedResult("Required question counters are shown");
			* Log.ExpectedResult("Market is not submittable");
			* Log.ExpectedResult("Indicator is displayed");
			* Log.Step("Opening market's program, it's binding and disabling prequalification for form");
			* Log.Step("Reopening previously created RFQ");
			* Log.ExpectedResult("Four sections are displayed");
			* Log.ExpectedResult("No required questions are displayed");
			* Log.ExpectedResult("Indicator is not displayed");
			* Log.ExpectedResult("Market is submittable");
	* Method: CheckRequiredDocumentAdmissionLinkFeatureForDocuments
		* TestCaseLink: "RD-2 : https://docs.google.com/spreadsheets/d/140fXn5Ke6pqYHoYTo2__gded1NYg0XsbQsHY6tGGrOA/edit#gid=1073419638&range=5:7"
		* Categories: [UNDEFINED]
	* Method: CheckRequiredDocumentAdmissionLinkFeatureForLossRuns
		* TestCaseLink: "RD-1 : https://docs.google.com/spreadsheets/d/140fXn5Ke6pqYHoYTo2__gded1NYg0XsbQsHY6tGGrOA/edit#gid=1073419638&range=2:4"
		* Categories: [UNDEFINED]
	* Method: CheckSpecificFormBinding
		* TestCaseLink: "Preq_009: https://docs.google.com/spreadsheets/d/13Q9CJn7UdV_dOI9UN4_LTlzRmbzhoZTInD1JT7uDnaQ/edit?pli=1#gid=1360715977&range=A2:A5"
		* Categories: [UNDEFINED]
			* Log.Step($"Opening Form Binding page on admin site and getting bindings for {marketEncino} market");
			* Log.ExpectedResult("Expected bindings are present");
			* Log.Step("Logging as agency user, creating GL RFQ and selecting market");
			* Log.ExpectedResult("Only Subject and Policy sections are displayed");
			* Log.ExpectedResult("Subject section contains 1 required question, Policy - 4 required questions");
			* Log.Step("Deselecting previously selected market and selecting another market with submarket");
			* Log.ExpectedResult("Only Policy section is displayed");
			* Log.ExpectedResult("Policy section contains 7 required questions");
			* Log.Step($"Logging as user of {marketSpecificForm}, creating GL RFQ");
			* Log.ExpectedResult($"Questionnaire is similar to one on agency side with {marketSpecificForm} as root and {marketEncino} as submarket");
			* Log.Step($"Logging as user of {marketEncino}, creating GL RFQ");
			* Log.ExpectedResult($"Questionnaire is similar to one on agency side with {marketEncino} as root");
	* Method: CheckSpecificFormBindingAssignChain
		* TestCaseLink: "Preq_011: https://docs.google.com/spreadsheets/d/13Q9CJn7UdV_dOI9UN4_LTlzRmbzhoZTInD1JT7uDnaQ/edit?pli=1#gid=1360715977&range=A10:A12"
		* Categories: [UNDEFINED]
			* Log.Step($"Logging as user of {marketEncino} market, creating GL RFQ and assigning {marketSpecificForm} as Source Agency");
			* Log.ExpectedResult("Only Policy section is displayed");
			* Log.ExpectedResult("Policy section contains 7 required questions");
			* Log.ExpectedResult($"{marketSpecificForm} is selected as Source Agency");
			* Log.Step($"Logging as user of {marketSpecificForm} market, opening assigned RFQ and assigning {agency} as Source Agency");
			* Log.ExpectedResult("Questionnaire is similar to one on carrier side");
			* Log.ExpectedResult($"{agency} is selected as Source Agency");
			* Log.Step($"Logging as user of {agency} agency, opening assigned RFQ");
			* Log.ExpectedResult("Questionnaire is similar to one on MGA side");
	* Method: CheckSpecificFormBindingSubmissionChain
		* TestCaseLink: "Preq_010: https://docs.google.com/spreadsheets/d/13Q9CJn7UdV_dOI9UN4_LTlzRmbzhoZTInD1JT7uDnaQ/edit?pli=1#gid=1360715977&range=A6:A9"
		* Categories: [UNDEFINED]
			* Log.Step("Logging as agency user, creating GL RFQ and selecting market and submarket");
			* Log.ExpectedResult("Only Policy section is displayed");
			* Log.ExpectedResult("Policy section contains 7 required questions");
			* Log.Step($"Filling out questionnaire and submitting to {marketSpecificForm} market");
			* Log.Step($"Logging as user of {marketSpecificForm} market, opening submitted RFQ and submitting to {marketEncino} market");
			* Log.ExpectedResult("Questionnaire is similar to one on agency side");
			* Log.Step($"Logging as user of {marketEncino} market, opening submitted RFQ");
			* Log.ExpectedResult("Questionnaire is similar to one on MGA side");
	* Method: CheckSupplementalWithSpecificBusinessType
		* TestCaseLink: "Preq_006 - https://docs.google.com/spreadsheets/d/13Q9CJn7UdV_dOI9UN4_LTlzRmbzhoZTInD1JT7uDnaQ/edit#gid=0&range=20:20"
		* Categories: [UNDEFINED]
	* Method: CheckThatEntityFieldStaysNotRequiredWhenRfqIsReopened
		* TestCaseLink: "Preq_004 - https://docs.google.com/spreadsheets/d/13Q9CJn7UdV_dOI9UN4_LTlzRmbzhoZTInD1JT7uDnaQ/edit#gid=0&range=A12:A18"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency user and create a WC RFQ");
			* Log.Step($"Select {market.Name} market and {submarket.Name} as a submarket on Markets Selector");
			* Log.ExpectedResult($"{market.Name} admission indicators is a question mark as no submarkets are selected");
			* Log.Step($"Select {submarket.Name} as a submarket of {market.Name} on Markets Selector");
			* Log.ExpectedResult($"{market.Name} and {submarket.Name} admission indicators are orange U");
			* Log.ExpectedResult("Check Subject, Underwriting, Coverage History, Policy sections have unanswered questions");
			* Log.Step("Open Policy section and fill 'Entity' field");
			* Log.Step("Go to 'All Insured' page and then reopen the RFQ");
			* Log.ExpectedResult($"{market.Name} and {submarket.Name} admission indicators are orange U");
			* Log.ExpectedResult("Check Subject, Underwriting, Coverage History, Policy sections have unanswered questions");
			* Log.ExpectedResult("Check that 'Entity' question remains not required");
* File: GenerateDocumentTests.cs
	* Method: NewMimeFormatIsUsedInESubmissionWhenUseStandardMimeMessageFormatIsOn
		* TestCaseLink: "eSMimeRq-1 : https://docs.google.com/spreadsheets/d/1Yxiq1BIjr8iC6H4MyVTI-N0PIw5awA9wDRr94VsyuV0/edit#gid=397481940&range=A2:A3"
		* Categories: [UNDEFINED]
			* Log.Step("Create insured with wc rfq");
			* Log.Step("Fill questionnaire");
			* Log.Step($"Upload doc on {typeof(DocsPage).Name}");
			* Log.Step($"Select '{market}' market on markets selector");
			* Log.Step("Submit to market");
			* Log.ExpectedResult("There is popup warning with message about impossibility to process submit");
			* Log.Step("Get raw request");
			* Log.Step("Get 'boundary' value from raw request");
			* Log.ExpectedResult("'Boundary' value doesn't have quotes");
			* Log.ExpectedResult("Letter d in 'Content-Id' name has lower case");
* File: GenericMessageTests.cs
	* Method: GenericMessageDisplayedOnPolicyDocsTab
		* TestCaseLink: "GM-3: https://docs.google.com/spreadsheets/d/1mHHonW3ITyfeY-mnTeKq9P-gcw-Jyv52L90zX1HpSkw/edit#gid=110187460&range=B25"
		* Categories: [UNDEFINED]
			* Log.Step("Create WC Policy and Open Policy Docs tab");
	* Method: GenericMessageDisplayOnFormsAndDocsTabs
		* TestCaseLink: "GM-1: https://docs.google.com/spreadsheets/d/1mHHonW3ITyfeY-mnTeKq9P-gcw-Jyv52L90zX1HpSkw/edit#gid=1414710983&range=B33:B34"
		                                  + "GM-2: https://docs.google.com/spreadsheets/d/1mHHonW3ITyfeY-mnTeKq9P-gcw-Jyv52L90zX1HpSkw/edit#gid=0&range=B56"
		* Categories: [UNDEFINED]
			* Log.Step("Create WC RFQ, open Forms tab");
			* Log.ExpectedResult($"{displayedForm} and file uploader row are displayed");
			* Log.Step($"Deselect {displayedForm} in Available forms");
			* Log.ExpectedResult($"{displayedForm} and file uploader row are not displayed");
			* Log.ExpectedResult("Check generic message on Forms tab");
			* Log.Step("Open Docs tab");
			* Log.ExpectedResult("Check generic message on Docs tab");
* File: GlCalculations.cs
	* Method: EncinoGlTest
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
			* Log.Step("Create rfq");
			* Log.Step("Fill questionnaire");
	* Method: IllinoisGlTest
		* TestCaseLink: "Bro-3: https://docs.google.com/spreadsheets/d/1jBGIks6RAdLiDkkpQuthKhhCCvZu5KjPoSfyISvvWas/edit#gid=1884073390&range=A18:A20"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites, Categories.BrooksideGeneral
			* Log.Step("Create rfq AND select market");
			* Log.Step("Fill location and business type");
			* Log.Step("Fill additional Insureds");
* File: HelpRequestAnonymousTests.cs
	* Method: CheckDefaultGeneralQuestionValue
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: CheckDefaultSalesValue
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: CheckHelpRequestEmailIsReceived
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: HelpRequestAuthorizeAttachFilesTests.cs
	* Method: ChooseAndDeleteApplicationFile
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: ChooseAndDeleteExampleFile
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: HelpRequestAuthorizedTests.cs
	* Method: CheckAgentAmbassadorEmailTest
		* TestCaseLink: "ATS-3: https://docs.google.com/spreadsheets/d/1meb9omTaVQwFSwr_xFhBg-m5-JJ1xKhVLPxis5Va3os/edit#gid=0&range=A21"
		* Categories: Categories.ExcludingCategoryOnlyProductionSite
	* Method: LoggedUserHasPrefilledRequestData
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: HttpTests.cs
	* Method: UrlWithUnavailableMarketId
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1oxBNXT2tpUFBDXedQwxCCJRik-YNb4cDgATovbAdyuQ/edit#gid=0&range=A2:J2"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites
* File: InfoTipTests.cs
	* Method: InfotipDisplaysOnInsuredContactInterface
		* TestCaseLink: "CTT_05: https://docs.google.com/spreadsheets/d/1JaRs6EgNBftLh5rvSnNJijWmGUAS-8RVWMQvYgXK7so/edit#gid=1371491588&range=A17:A22"
		* Categories: [UNDEFINED]
			* Log.Step("Got to Contact tab on the InsuredInfo page, create a contact and send an invite");
			* Log.Step("Set a password on the 'Change password' page using a link from an email and proceed to QuoteEditor page");
			* Log.Step($"Open 'Test' section and get infotip columns' headers text for the '{questionForCheck} question'");
			* Log.ExpectedResult("Check that popup column's headers are: Coverage, Silver, Symbols, Spec Symbols");
	* Method: InfotipDisplaysOnReversePortal
		* TestCaseLink: "CTT_06: https://docs.google.com/spreadsheets/d/1JaRs6EgNBftLh5rvSnNJijWmGUAS-8RVWMQvYgXK7so/edit#gid=1371491588&range=B23:B28"
		* Categories: [UNDEFINED]
			* Log.Step("Send questionnaire to complete and open 'Request to complete' page");
			* Log.Step($"Go to 'Infotip' section and open infotip popup for the '{questionForCheck}' question");
			* Log.ExpectedResult($"Make sure that the '{questionForCheck}' question's infotip contains an image");
	* Method: ManagerDefinedInfoTipShownOnFormsQaTab
		* TestCaseLink: "CTT_03: https://docs.google.com/spreadsheets/d/1JaRs6EgNBftLh5rvSnNJijWmGUAS-8RVWMQvYgXK7so/edit#gid=1371491588&range=A11:A14"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency user, create an insured and an RFQ");
			* Log.Step($"Select the '{market.Name}' market on Markets Selector, open Forms tab and open the '{formForEditing}' form for editing");
			* Log.Step($"Get infotip text for the '{questionForCheck}' question");
			* Log.ExpectedResult("Check infotip popup message");
	* Method: ManagerDefinedInfoTipShownOnQaTab
		* TestCaseLink: "CTT_02: https://docs.google.com/spreadsheets/d/1JaRs6EgNBftLh5rvSnNJijWmGUAS-8RVWMQvYgXK7so/edit#gid=1371491588&range=A7:A10"
		* Categories: [UNDEFINED]
			* Log.Step($"Get infotip text for the '{questionForCheck}' question");
			* Log.ExpectedResult("Check infotip popup message");
	* Method: XamlDefinedInfoTipDisplayedOnQuestionnaire
		* TestCaseLink: "CTT_01: https://docs.google.com/spreadsheets/d/1JaRs6EgNBftLh5rvSnNJijWmGUAS-8RVWMQvYgXK7so/edit#gid=1371491588&range=A2:A6"
		* Categories: [UNDEFINED]
			* Log.ExpectedResult($"Check that '{questionForCheck}' is required");
			* Log.Step($"Highlight the '{questionForCheck}' question clicking it in the admission tooltip");
			* Log.ExpectedResult($"Check that '{questionForCheck}' question is highlighted");
			* Log.Step($"Open infotip popup clicking question mark icon next to the '{questionForCheck}' question");
			* Log.ExpectedResult("Check that popup column's headers are: Coverage, Silver, Gold, Platinum, Coverage Description");
	* Method: XamlOverridenInfoTipIsShownOnQa
		* TestCaseLink: "CTT_04: https://docs.google.com/spreadsheets/d/1JaRs6EgNBftLh5rvSnNJijWmGUAS-8RVWMQvYgXK7so/edit#gid=1371491588&range=A15:A16"
		* Categories: [UNDEFINED]
			* Log.Step($"Open 'Infotip' section and get infotip for the '{collectionQuestionForCheck}' question");
			* Log.ExpectedResult("Check infotip popup message");
			* Log.Step("Expand collection question and get infotip message for a child question");
			* Log.ExpectedResult("Check infotip popup message for a child question");
* File: InsuranceLinesManagementInAgency.cs
	* Method: LinesInAgencyDependsOnMarkets
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: InsuredMerge.cs
	* Method: MergeInsured
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: InsuredUserBaseTests.cs
	* Method: CheckAvailabilityOfDocumentsByInsuredUser
		* TestCaseLink: "IU_4 - https://docs.google.com/spreadsheets/d/1R7LgID9Ek0FylTu8FyT-m4P8Ex8puUJyNGITJg_hbOU/edit#gid=0&range=20:24"
		* Categories: [UNDEFINED]
			* Log.Step("Add documents to Rfq");
			* Log.ExpectedResult("All documents on DOCS Page");
			* Log.ExpectedResult("All documents on Forms Page");
			* Log.Step($"'{MarketsSelectorAction.MarkAsBound.GetDescription()}' Rfq");
			* Log.Step("Add new contact to Policy");
			* Log.Step("Invite contact via Email");
			* Log.ExpectedResult("Invite email was sent");
			* Log.Step("Open Policy as Insured User");
	* Method: CheckNoReportsMenuOnInsuredUserSite
		* TestCaseLink: "RM_1 - https://docs.google.com/spreadsheets/d/1eZLAaRJ0gHXqH1HHY32QrOhP3TxXsy-2ujHeXcmOY3Q/edit#gid=616857322&range=A2"
		* Categories: [UNDEFINED]
	* Method: InsuredUserChangesProfileData
		* TestCaseLink: "IU_2 - https://docs.google.com/spreadsheets/d/1R7LgID9Ek0FylTu8FyT-m4P8Ex8puUJyNGITJg_hbOU/edit#gid=0&range=A13:A16"
		* Categories: [UNDEFINED]
	* Method: InsuredUserGetsAccessToRfqAndPolicyCreatedByDifferentAgencies
		* TestCaseLink: "IU_1 - https://docs.google.com/spreadsheets/d/1R7LgID9Ek0FylTu8FyT-m4P8Ex8puUJyNGITJg_hbOU/edit#gid=0&range=A2:A11"
		* Categories: [UNDEFINED]
* File: InterlocationIsolationLevelTests.cs
	* Method: AssignationCsrAndProducerOnInterlocationIsolationLevel
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: InviteInsured.cs
	* Method: InviteInsuredTest
		* TestCaseLink: [UNDEFINED]
		* Categories: Categories.MailSendCheckCategory, Categories.SmokeTestsCategory
* File: IpRestrictionTests.cs
	* Method: DeniedAccessAccordingWhiteListIpSettings
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
			* Log.Step($"Login as SA and set settings. IP address type - '{addressType}'");
			* Log.ExpectedResult("Check error message on the 'Access is denied' page");
* File: LimitsAndDeductibleMarketsTest.cs
	* Method: CheckEncinoLimitsWhenFillingQuestionnaireTest
		* TestCaseLink: "LDGL001 - https://docs.google.com/spreadsheets/d/1pV13jp7eLCgU2pkXEdBS6DnGrH_BC6fuoaOhsM0y6Ms/edit#gid=0&range=A3:A13"
		* Categories: Categories.LimitsAndDeductiblesCategory
* File: LimitsAndDeductibleQuoteTests.cs
	* Method: CheckLimitsAndDeductibleForGeneratedQuote
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency user, create an insured and a GL RFQ");
			* Log.Step($"Select the '{encinoMarket.Name}' market and fill questionnaire");
			* Log.Step($"Submit to the '{encinoMarket.Name}' market");
			* Log.ExpectedResult($"Check admission indicator, premium, limits and deductibles for the '{encinoMarket.Name}' market");
			* Log.ExpectedResult($"Check premium, limits and deductibles for a generated under the '{encinoMarket.Name}' market quote document");
	* Method: LimitsDeductiblePremiumEditingForUploadedQuoteDocument
		* TestCaseLink: "QUE-0: https://docs.google.com/spreadsheets/d/1pV13jp7eLCgU2pkXEdBS6DnGrH_BC6fuoaOhsM0y6Ms/edit#gid=1033612120&range=A2"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency user, create an insured and a GL RFQ");
			* Log.Step($"Select the '{market.Name}' market and submit to it");
			* Log.Step($"Log in as the '{market.Name}' market's user and upload a quote document");
			* Log.ExpectedResult("Check that 'Enter' is displayed inside the limits, deductible and premium cells");
			* Log.Step("Fill a premium for the uploaded quote document");
			* Log.ExpectedResult("Check that manually filled premium is saved successfully");
			* Log.Step("Open Quote parameters dialog, fill out limits fields");
			* Log.ExpectedResult("Check that shorten versions of filled values are displayed in the Limits and Deductibles dialog");
			* Log.Step("Close 'Limits and deductibles' dialog");
			* Log.ExpectedResult("Check displayed limits and deductibles values and their tooltips");
			* Log.Step("Market user releases the quote document");
			* Log.Step("Open Activity tab of the RFQ");
			* Log.ExpectedResult("Check that 'Quote Parameters Updated' event is logged");
			* Log.Step("Log in as an agency user and open RFQ");
			* Log.ExpectedResult("Check limits and deductibles cells values and editability");
	* Method: QuoteParametersEditable
		* TestCaseLink: "QUE-2: https://docs.google.com/spreadsheets/d/1pV13jp7eLCgU2pkXEdBS6DnGrH_BC6fuoaOhsM0y6Ms/edit#gid=1033612120&range=A36"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency user, create an insured and a GL RFQ");
			* Log.Step($"Select the '{mga.Name}' market and submit to it");
			* Log.Step($"Upload a quote document under the '{mga.Name}' market");
			* Log.Step("Check default limits, deductibles and premium values");
			* Log.Step("Fill and check limits, deductibles and premium");
			* Log.Step($"Log in as a '{mga.Name}' market user and open the RFQ");
			* Log.Step("Check current limits, deductibles and premium values");
			* Log.Step("Edit and check limits, deductibles and premium");
			* Log.Step($"Select the '{carrier.Name}' market and submit to it");
			* Log.Step("Log in as a carrier user and open RFQ");
			* Log.Step("Check default limits, deductibles and premium values");
			* Log.Step("Fill and check limits, deductibles and premium");
			* Log.Step("Carrier releases the quote document");
			* Log.Step($"Log in as a '{mga.Name}' market user and open the RFQ");
			* Log.Step("Check current limits, deductibles and premium values");
			* Log.Step("Edit and check limits, deductibles and premium");
			* Log.Step("Mga user releases the quote document to the agent");
			* Log.Step("Log in as the agency user again and open the RFQ");
			* Log.ExpectedResult("Check that manually filled premium is saved successfully");
			* Log.ExpectedResult("Check displayed limits and deductibles values");
			* Log.ExpectedResult($"Check limits, deductibles and premium cells values are not editable for the {secondQuoteDocumentName}");
	* Method: QuoteParametersUpdatedEventOnRecordActivityTab
		* TestCaseLink: "QUE-1: https://docs.google.com/spreadsheets/d/1pV13jp7eLCgU2pkXEdBS6DnGrH_BC6fuoaOhsM0y6Ms/edit#gid=1033612120&range=A21"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency user, create an insured and a GL RFQ");
			* Log.Step($"Select the '{mga.Name}' market and submit to it");
			* Log.Step($"Upload a quote document under the '{mga.Name}' market");
			* Log.Step("Check default limits, deductibles and premium values");
			* Log.Step("Fill and check limits, deductibles and premium");
			* Log.Step("Open Activity tab of the RFQ");
			* Log.ExpectedResult("Check that 'Quote Parameters Updated' event is logged on agency side");
			* Log.Step("Log in as an mga user and open activity tab of RFQ");
			* Log.ExpectedResult("Check that 'Quote Parameters Updated' event is logged on mga side");
			* Log.Step($"Return to the QA page and submit to the '{carrier.Name}' carrier");
			* Log.Step("Log in as a carrier user and open RFQ");
			* Log.Step("Check default limits, deductibles and premium values");
			* Log.Step("Fill and check limits, deductibles and premium");
			* Log.Step("Open Activity tab of the RFQ");
			* Log.ExpectedResult("Check that 'Quote Parameters Updated' event is logged on carrier side");
			* Log.Step("Return to the QA page and release quote document");
			* Log.Step("Log in as mga user and open activity tab of the RFQ");
			* Log.ExpectedResult("Check that 'Quote Parameters Updated' event is not logged on mga side");
			* Log.Step("Log in as a carrier user again and open RFQ");
			* Log.Step("Open Quote parameters dialog, fill out limits fields and close dialog");
			* Log.Step("Log in as an mga user and open activity tab of RFQ");
			* Log.ExpectedResult("Check that 'Quote Parameters Updated' event is logged on carrier side");
* File: LimitsAndDeductibleRequiredCounterTests.cs
	* Method: ChangingLimitsAndDedAfterSubmissionTest
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
			* Log.Step("Create insured with rfq AND select market");
			* Log.ExpectedResult($"Tooltip of QPD call icon for '{market}' market has correct message");
			* Log.Step("Select submarket");
			* Log.ExpectedResult($"Required questions counter of QPD call icon for '{submarket}' submarket has value one");
			* Log.Step("Submit by Appulate");
			* Log.ExpectedResult($"Market's status has value '{MarketStatus.Submitted}'");
			* Log.Step("Open 'Limits & Deductibles' dialog");
			* Log.ExpectedResult("Number of required text fields in 'Limits & Deductibles' tab is 3");
			* Log.Step("Set first limit value");
			* Log.ExpectedResult("Counter of required questions of 'Limits & Deductibles' tab has value 2");
			* Log.Step("Set second limit value");
			* Log.ExpectedResult("Counter of required questions of 'Limits & Deductibles' tab has value 1");
			* Log.Step("Set deductible value");
			* Log.ExpectedResult("Counter of required questions of 'Limits & Deductibles' tab is absence");
			* Log.Step("Save & Close 'Limits & Deductibles' dialog");
			* Log.ExpectedResult("Limits and deductible values have correct values");
			* Log.ExpectedResult("QPD call is absence");
* File: LimitsAndDeductibleTests.cs
	* Method: CheckSubstitutionOfLimitsForPrintPdfFromFormsQaFunctionality
		* TestCaseLink: "SLSQ_001: https://docs.google.com/spreadsheets/d/1pV13jp7eLCgU2pkXEdBS6DnGrH_BC6fuoaOhsM0y6Ms/edit#gid=521493722&range=2:6"
		* Categories: [UNDEFINED]
			* Log.Step($"Log in as an agent. Create insured with '{insuranceLine}' RfQ. Select the '{market}' market on Markets Selector");
			* Log.ExpectedResult("There are expected limit values");
			* Log.Step($"Go to {typeof(RecordForms).Name}");
			* Log.Step($"Open '{supplementalDocName}' supplemental for editing");
			* Log.Step($"Open '{sectionName}' section");
			* Log.Step("Extract questions from questionnaire");
			* Log.ExpectedResult($"Extracted questions have answers '{notSelectedAnswer}'");
			* Log.Step($"Download '{supplementalDocName}' supplemental");
			* Log.Step("Convert downloaded file to string");
			* Log.ExpectedResult($"Downloaded '{supplementalDocName}' supplemental has expected string");
	* Method: LimitsAndDeductiblesAreSetInProfessionalLiabilityRfqDependingCustomProgramConfiguration
		* TestCaseLink: "PL-2 - https://docs.google.com/spreadsheets/d/1pV13jp7eLCgU2pkXEdBS6DnGrH_BC6fuoaOhsM0y6Ms/edit#gid=974107485&range=11:21"
		* Categories: [UNDEFINED]
			* Log.Step($"Log in as an agent. Create Business insured with Professional Liability RfQ. Select the '{market.Name}' on Markets Selector");
			* Log.Step("Hover over limits in Limits cell next to the market");
			* Log.ExpectedResult("Default limits are displayed. The tooltip with limits name and default values is displayed");
			* Log.ExpectedResult("Default deductible is displayed");
			* Log.ExpectedResult("Required questions counter placed on Quote Parameters Dialog button is equal to 1");
			* Log.Step("Click on limits in Limits cell next to the market");
			* Log.ExpectedResult("Quote parameters dialog is opened and contains expected controls with default values");
			* Log.ExpectedResult("Limits dropdown contains expected values");
			* Log.ExpectedResult("Deductible dropdown contains expected values");
			* Log.Step("Choose new limits and deductible");
			* Log.ExpectedResult("New limits and deductible are displayed as selected");
			* Log.Step("Click 'Save & Close'");
			* Log.Step("Hover over limits in Limits cell next to the market");
			* Log.ExpectedResult("New limits are displayed. The tooltip with limits names and new values is displayed");
			* Log.Step("Hover over the deductible in the Ded. cell next to the market");
			* Log.ExpectedResult("New deductible is displayed. The tooltip with deductible name and new value is displayed");
	* Method: LimitsAndDeductiblesAreSetInProfessionalLiabilityRfqDependingDefaultProgramConfiguration
		* TestCaseLink: "PL-1 - https://docs.google.com/spreadsheets/d/1pV13jp7eLCgU2pkXEdBS6DnGrH_BC6fuoaOhsM0y6Ms/edit#gid=974107485&range=2:10"
		* Categories: [UNDEFINED]
			* Log.Step($"Log in as an agent. Create Business insured with Professional Liability RfQ. Select the '{market.Name}' on Markets Selector");
			* Log.Step("Hover over limits in Limits cell next to the market");
			* Log.ExpectedResult("Default limits are displayed in cell, the tooltip with limits names and default values is displayed");
			* Log.ExpectedResult("Default deductible is displayed");
			* Log.Step("Click on limits in the Limits cell next to the market");
			* Log.ExpectedResult("Quote parameters dialog is opened and contains expected controls");
			* Log.ExpectedResult("Limits dropdown contains expected possible values");
			* Log.ExpectedResult("Deductible dropdown contains expected possible values");
			* Log.Step("Choose new limits and deductible");
			* Log.ExpectedResult("New limits and deductible are displayed as selected");
			* Log.Step("Click 'Save & Close'");
			* Log.Step("Hover over limits in Limits cell next to the market");
			* Log.ExpectedResult($"New limits '{newLimits}' are displayed in the cell. The tooltip with limits names and new values is displayed");
			* Log.Step("Hover over the deductible in the Deds. cell next to market");
			* Log.ExpectedResult($"New deductible '{newDeductible}' is displayed in the cell. The tooltip with deductible name and new value is displayed");
	* Method: PdfVersionsOfAcordsContainLimitsFromMsWhenSubmittedByEmailTest
		* TestCaseLink: "LPID_002 - https://docs.google.com/spreadsheets/d/1pV13jp7eLCgU2pkXEdBS6DnGrH_BC6fuoaOhsM0y6Ms/edit#gid=2006941964&range=A8:A12"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency user, create an insured and a GL RFQ, check default limits on MS");
			* Log.Step("Set limits' values and check changes on UI");
			* Log.Step("Open 'Send Email' dialog by clicking on'submit' button, download ACORD 126 and check limits' values in a PDF-file");
			* Log.Step("Submit to a market by Email, check that it has been delivered and email contains attachments + check UI");
	* Method: PdfVersionsOfAcordsSentByEmailContainLimitsFromMsTest
		* TestCaseLink: "LPID_001: https://docs.google.com/spreadsheets/d/1pV13jp7eLCgU2pkXEdBS6DnGrH_BC6fuoaOhsM0y6Ms/edit#gid=2006941964&range=A2:A6"
		* Categories: Categories.Forms
			* Log.Step("Log in as an agency user, create an insured and a Flood - Personal RFQ, check default limits on MS");
			* Log.Step("Set limits' values and check changes on UI");
			* Log.Step("Fill in 'Location' section and submit to a market");
			* Log.Step("Open 'Send Email' dialog, download ACORD 80 and check limits' values in a PDF-file");
			* Log.Step("Send an email, check that it has been delivered and email contains attachments");
* File: LoginTests.cs
	* Method: AccountBlockDuringLogin
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: AccurateLoginTimeTest
		* TestCaseLink: "User_2: https://docs.google.com/spreadsheets/d/1imd2RMJVeeJcOfCsHTDJPoUIg2NrcSLQpa-3xjsMA58/edit#gid=689765879&range=11:12"
		* Categories: [UNDEFINED]
			* Log.Step("Login in site");
			* Log.Step("Get information from Admin");
	* Method: AttemptOfLoginWithoutWaitingOfBlockTime
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: CheckSignInPageForDuplicateEmailTest
		* TestCaseLink: "SU_16 https://docs.google.com/spreadsheets/d/1ldCkNdi0iC1-aBwioTNrO0hOvwNtNJGcmux4CUFTX3E/edit#gid=34483309&range=A44:J44"
		* Categories: [UNDEFINED]
	* Method: LoginThroughTwoFactorAuthentication
		* TestCaseLink: "2FA - 1: https://docs.google.com/spreadsheets/d/1iVsKWV1rREeZnrhWIxI7BOwlNapLZ_ITf6H3H7w9HO8/edit#gid=0&range=A2:A5"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites
	* Method: SkippingTwoFactorAuthDuringLogin
		* TestCaseLink: "2FA - 2: https://docs.google.com/spreadsheets/d/1iVsKWV1rREeZnrhWIxI7BOwlNapLZ_ITf6H3H7w9HO8/edit#gid=0&range=A6:A9"
		* Categories: Categories.SmokeTestsCategory
	* Method: SuccessfulLoginAfterFail
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: SuspendingUserWithIncorrectVerificationCode
		* TestCaseLink: "2FA - 3: https://docs.google.com/spreadsheets/d/1iVsKWV1rREeZnrhWIxI7BOwlNapLZ_ITf6H3H7w9HO8/edit#gid=0&range=A10:A14"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites
* File: LookupRecipientsNumberLimitationTests.cs
	* Method: LookupRecipientsNumberLimitation
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: LossHistoryCollectionTests.cs
	* Method: InsuranceHistoryMixedOrderAndTwoRowsForOneYear
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
			* Log.Step("Go to Forms tab and make ACORD 125 available for edit");
			* Log.Step("Proceed to Prior Carrier Information section, Workers Compensation subsection and fill the WC Insurance History collection with initial data for Mixed Order case");
			* Log.Step($"Change eff date of record with Year = 2016 of {collectionName} collection from 02/07/2016 to {mixedOrderEffectiveDate}");
			* Log.ExpectedResult("Compare answers in WC Insurance History rows with expected answers");
			* Log.Step("Clear and fill the WC Insurance History collection with initial data for Two Rows For One Year case");
			* Log.Step($"Change eff date of 2nd row with Year = 2015 of {collectionName} collection from 02/07/2016 to {twoRowsOneYearEffectiveDate}");
			* Log.ExpectedResult("Compare answers in WC Insurance History rows with expected answers");
* File: MackinawUnderwritersSignRtbDocsTest.cs
	* Method: MackinawUnderwritersRequestToBindProcessTest
		* TestCaseLink: "MU_001: https://docs.google.com/spreadsheets/d/1VgPWPR3VMZ4bujoDsCNcyepiNpSfDGF8JXVkJvvhWKo/edit#gid=0&range=A2:A11"
		* Categories: [UNDEFINED]
			* Log.Step("Login as agency user");
			* Log.Step("Open the RFQ");
			* Log.Step($"Click 'Yes' radiobutton for the question '{questionTitle}'");
			* Log.Step("Do 'Request to bind' process");
			* Log.ExpectedResult($"Market and quote document status is '{RecordStatus.RequestedToBind.GetDescription()}'");
			* Log.ExpectedResult("'Cancel Binding' button for the quote document is available");
* File: MainSitePagesOpeningTests.cs
	* Method: CheckMainSiteMainMenuForUnknownItems
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
			* Log.Step("Log in to main site");
			* Log.ExpectedResult("Check all main menu items for unknown ones");
* File: MandatoryQuestion.cs
	* Method: AsterisksAppearsOnQuestionsIfChainedQuestionIsAnswered
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: AsterisksDisappearsIfIndicatorD
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: AsterisksDisppearsOnQuestionsIfChainedQuestionIsAnswered
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: MarketCreation.cs
	* Method: CreateNewMarketWithUserAndApplication
		* TestCaseLink: "mc-1: https://docs.google.com/spreadsheets/d/11BRy_srtHlIIee6AQ6cURlcW0Uoa36YTdOWCw-z8KBA/edit#gid=0&range=C2:C8 and " +
		                                  "QB_1: https://docs.google.com/spreadsheets/d/1oIxk84Wm-s_4t8JX2VeYac2g2CP5DiV6MSN6Wddp4UQ/edit#gid=1239226475&range=A2:A4"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites, Categories.AdminSiteTestsCategory, Categories.MarketProgramsCategory
			* Log.Step("Create new testing market");
			* Log.Step($"Market name: {market.Name}");
			* Log.ExpectedResult($"Verify '{MarketSettings.QuickBooksIntegration.GetDescription()}' setting");
			* Log.Step("Fill settings");
			* Log.Step("REOPEN settings page and create new user");
			* Log.Step($"User role: {newUser.Role}");
			* Log.ExpectedResult("Check that market settings saved correct");
			* Log.Step("Create new program");
			* Log.ExpectedResult("Check possible login and create application");
* File: MarketInfoCommentSettings.cs
	* Method: MarketInfoSetComment
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: MarketInvitationPageUrl.cs
	* Method: ChangingMarketHostNameForLandingPage
		* TestCaseLink: "LP-1 https://docs.google.com/spreadsheets/d/1-79w0U1pYfQ4MSn6moJzl-1beW4yJDMpto6xxxHrsso/edit#gid=1906949596&range=A2"
		* Categories: [UNDEFINED]
			* Log.Step("On market's side open Setup page and get Invitation URL.");
			* Log.Step("Fill in Host name for market.");
			* Log.Step("Re-open Setup page and click on the URL 'Invitation page URL'.");
			* Log.ExpectedResult("The page with URL https://[market host].appulate[branch].com/join-on-appulate is opened in a new tab");
* File: MarketLineTabTests.cs
	* Method: MarketInfoLinesTabIsSavedCorrectlyWithoutAnyChanges
		* TestCaseLink: "S-L15 https://docs.google.com/spreadsheets/d/1YdChWYkmrq4EssLPdLMv3YBDoUW75P19e3IKpwbVlMI/edit#gid=0&range=A30"
		* Categories: Categories.InsuranceLines
			* Log.Step("Login as market user and open available markets page");
			* Log.Step("Select test market from available markets");
			* Log.Step("Open Lines tab of added market and check presence of Lines");
			* Log.Step("Click Save button and check wording of tooltip");
			* Log.ExpectedResult("Lines tab is saved properly. 'Saved' tooltip message appears");
* File: MarketProgramsTests.cs
	* Method: ChangeDefaultSubmissionTypeToAgencyAndSubmitToIt
		* TestCaseLink: "DST-2: https://docs.google.com/spreadsheets/d/1dOZPiPcxnNooPE0uiHqWsDWEkcXg_hvo5eLSzR5JYjo/edit#gid=0&range=A24:A27"
		* Categories: [UNDEFINED]
			* Log.Step($"Create insured with rfq AND select '{market}' market");
			* Log.ExpectedResult($"'{market}' market has '{SubmissionType.Email.GetDescription()}' submission type");
			* Log.Step($"Open '{agency}' agency info programs page on markets side");
			* Log.Step($"Change submission type to '{SubmissionType.Appulate.GetDescription()}' for '{InsuranceLine.Wc.GetDescription()}' program");
			* Log.ExpectedResult($"'{InsuranceLine.Wc}' program has '{SubmissionType.Appulate.GetDescription()}' submission type");
			* Log.Step("Open qa page on agency side");
			* Log.ExpectedResult($"{market}' has '{SubmissionType.Appulate.GetDescription()}' submission type");
			* Log.Step($"Make Appulate submit to '{market}' market");
			* Log.ExpectedResult($"Status of '{market}' market is '{MarketStatus.Submitted.GetDescription()}'");
	* Method: CreationOfDefaultProgramAndUsingItForSubmission
		* TestCaseLink: "DP-1: https://docs.google.com/spreadsheets/d/1dOZPiPcxnNooPE0uiHqWsDWEkcXg_hvo5eLSzR5JYjo/edit#gid=0&range=A9:A12"
		* Categories: [UNDEFINED]
			* Log.Step("Add program to the market");
			* Log.ExpectedResult("The new program has given name, insurance line - all, submission type - email");
			* Log.Step($"Create insured with rfq AND select '{market}' market");
			* Log.ExpectedResult($"'{market}' market has submission type - email");
			* Log.Step("Perform submit");
			* Log.ExpectedResult("Submit is successful");
	* Method: CreationOfProgramsFromMarketsInsuranceLinePage
		* TestCaseLink: "ILP-1: https://docs.google.com/spreadsheets/d/1dOZPiPcxnNooPE0uiHqWsDWEkcXg_hvo5eLSzR5JYjo/edit#gid=0&range=A28:A38"
		* Categories: [UNDEFINED]
			* Log.Step($"Go to insurance lines page of '{market}' market");
			* Log.ExpectedResult("All lines are NOT checked");
			* Log.Step($"Set '{InsuranceLine.Wc.GetDescription()}' insurance line to true");
			* Log.Step($"Open programs page for '{market}' market on admin site");
			* Log.ExpectedResult("Program line is created");
			* Log.ExpectedResult($"Program has '{SubmissionType.Email.GetDescription()}' submission type");
			* Log.Step($"Go to insurance lines page of '{market}' market");
			* Log.Step($"Set '{InsuranceLine.Wc.GetDescription()}' insurance line to false");
			* Log.ExpectedResult("There was expected message after saving");
			* Log.Step($"Set '{InsuranceLine.Crane.GetDescription()}' insurance line to true");
			* Log.Step($"Select coverage for '{InsuranceLine.Crane.GetDescription()}' insurance line");
			* Log.ExpectedResult("There was expected message after saving");
			* Log.Step($"Open programs page for '{market}' market on admin site");
			* Log.ExpectedResult("Package line is created. Mono line is absent");
			* Log.ExpectedResult($"Program has '{SubmissionType.Email.GetDescription()}' submission type");
			* Log.ExpectedResult("Program has expected coverage");
			* Log.Step($"Add '{InsuranceLine.Wind.GetDescription()}' program");
			* Log.Step($"Go to insurance lines page of '{market}' market");
			* Log.ExpectedResult("Line of created program is checked. Package line is still checked");
	* Method: FormBindingAdminMarketSettings
		* TestCaseLink: "MPFB_001 : https://docs.google.com/spreadsheets/d/1imd2RMJVeeJcOfCsHTDJPoUIg2NrcSLQpa-3xjsMA58/edit#gid=965764435&range=A2:A8"
		* Categories: [UNDEFINED]
			* Log.Step("Add new program with binding form");
			* Log.Step("Delete created program (bindings not deleted specially)");
			* Log.Step("Add program again (binding added automatically)");
			* Log.Step("Delete binding from program");
	* Method: SetUpDefaultSubmissionTypeToAnAgencyAndSubmitToIt
		* TestCaseLink: "DST-1: https://docs.google.com/spreadsheets/d/1dOZPiPcxnNooPE0uiHqWsDWEkcXg_hvo5eLSzR5JYjo/edit#gid=0&range=A18:A23"
		* Categories: [UNDEFINED]
			* Log.Step($"Open '{Agencies.AgencyForCheckPrograms}' agency info programs page on markets side");
			* Log.ExpectedResult($"'{InsuranceLine.Wc.GetDescription()}' program has default submission type as on Admin site program settings");
			* Log.Step($"Change submission type to Appulate for '{InsuranceLine.Wc.GetDescription()}' program");
			* Log.ExpectedResult($"'{InsuranceLine.Autob}' program has default submission type as on Admin site program settings");
			* Log.ExpectedResult($"Submission type cell of '{InsuranceLine.Autob}' program is NOT clickable");
			* Log.Step($"Create insured with rfq AND select '{Markets.MultiprogramMarketTwoLinesTwoSubmissionTypes}' market");
			* Log.Step($"Make Appulate submit to '{Markets.MultiprogramMarketTwoLinesTwoSubmissionTypes}' market");
			* Log.ExpectedResult($"Status of '{Markets.MultiprogramMarketTwoLinesTwoSubmissionTypes}' market is '{MarketStatus.Submitted.GetDescription()}'");
			* Log.ExpectedResult($"Button '{MarketsSelectorAction.Submit.GetDescription()}' is disappeared for market '{Markets.MultiprogramMarketTwoLinesTwoSubmissionTypes}'");
	* Method: TheMessageAboutNecessityToSelectMarketThatWorkWithInsuredType
		* TestCaseLink: "IM-1 - https://docs.google.com/spreadsheets/d/13svJHvE9AvOrqI0EXGtYZqPcWrgw0R31FLp4qUkozX4/edit#gid=0&range=2:2"
		* Categories: [UNDEFINED]
* File: MarketRowFocusFunctionalityTests.cs
	* Method: CheckFocusForMarketAndSubmarketRows
		* TestCaseLink: "F-1: https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=985408717&range=A2"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency user, create an insured and an Automobile Business RFQ");
			* Log.Step($"Select '{_mga.Name}' market and check the '{_carrierLloyds.Name}' and '{_carrierSutter.Name}' submarkets under it");
			* Log.ExpectedResult("Admission indicators are presented next to each market with logic (root or submarket)");
			* Log.Step($"Click the '{_carrierLloyds.Name}' market's name to set focus on the submarket's row");
			* Log.Step("Close overlay by clicking on Markets Selector's header");
			* Log.Step("Open Forms tab");
			* Log.Step($"Click the '{_carrierSutter.Name}' market's name to set focus on the submarket's row");
			* Log.Step("Close overlay by clicking on Markets Selector's header");
			* Log.Step($"Select {_carrierLloyds.Name} and {_carrierSutter} markets as roots on Markets Selector");
			* Log.ExpectedResult("Admission indicators are presented next to each market with logic (root or submarket)");
			* Log.Step($"Click the root '{_carrierLloyds.Name}' market's name to set focus on the market's row");
			* Log.Step($"Click the root '{_carrierLloyds.Name}' market's name to remove focus from the market's row");
			* Log.Step($"Click the root '{_carrierSutter.Name}' market's name to set focus on the market's row");
			* Log.Step("Open insured main information page (insured tab) and return to QA page");
	* Method: CheckFocusForMarketWithPctMergeSettingInDifferentStates
		* TestCaseLink: "F-2: https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=985408717&range=A13:A15"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites
			* Log.Step("Log in as an agency user, create an insured and an Automobile Business RFQ");
			* Log.Step($"Select '{_mga}' market and check the '{_carrierLloyds}' and '{_carrierMidAtlantic}' submarkets under it");
			* Log.Step($"Click the '{_carrierLloyds}' market's name to set focus on the submarket's row");
			* Log.Step($"Click the '{_carrierLloyds}' market's name to remove focus from the submarket's row");
			* Log.Step($"Click the '{_carrierMidAtlantic}' market's name to set focus on the submarket's row");
* File: MarketsAutoselectionLogic.cs
	* Method: AgencyUnderMarketUrlUnableToSelectMarketsTest
		* TestCaseLink: "ASL_5 - https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=1949228673&range=A13"
		* Categories: [UNDEFINED]
	* Method: BehaviorSingleLocationAndCollectionLocations
		* TestCaseLink: "SLM01, SLM02 - https://docs.google.com/spreadsheets/d/1JaRs6EgNBftLh5rvSnNJijWmGUAS-8RVWMQvYgXK7so/edit#gid=719629698&range=A2:A7"
		* Categories: Categories.Forms
			* Log.Step("Create RfQ with auto-selected markets");
			* Log.Step("Fill location question");
			* Log.Step("Clear location question and deselect one of markets");
	* Method: CheckAddMarketButtonBehaviourTest
		* TestCaseLink: "ASL_6 - https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=1949228673&range=A14"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency user and create an insured and a WC RFQ");
			* Log.Step("Check 'Add market' control's text and placeholder");
			* Log.Step("Add a market to Markets Selector and check 'Add market' control's behaviour");
	* Method: MarketsAutoselectedOnAgencySideTest
		* TestCaseLink: "ASL_2 - https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=1949228673&range=A5"
		* Categories: [UNDEFINED]
	* Method: MarketsAutoselectedOnMarketSideTest
		* TestCaseLink: "ASL_4 - https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=1949228673&range=A10"
		* Categories: [UNDEFINED]
	* Method: MarketsExceptSelfmarketNotAutoselectedOnMarketSideTest
		* TestCaseLink: "ASL_3 - https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=1949228673&range=A8"
		* Categories: [UNDEFINED]
	* Method: MarketsNotAutoselectedOnAgencySideTest
		* TestCaseLink: "ASL_1 - https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=1949228673&range=A3"
		* Categories: [UNDEFINED]
* File: MarketSettingsAdminPageTests.cs
	* Method: CheckHeaderStyleSettingTest
		* TestCaseLink: "CH-1 - https://docs.google.com/spreadsheets/d/1iDZMG2c8jIvK1lPUSON7gL75avoxTDIl4tdnonwJqG8/edit#gid=0&range=A2:A6"
		* Categories: [UNDEFINED]
			* Log.Step("Log in to the admin site and set the header style value to 'Default'");
			* Log.Step("Log in to the main site and check color of the header");
			* Log.Step("Return to the admin site and change the header's style to 'White'");
			* Log.Step("Reopen the main site and check color of the header");
* File: MarketsSelectorActionsTests.cs
	* Method: MarketsSelectorActionsForEmailMarketWithAgencyAndProducerCodesRequired
		* TestCaseLink: "MS_AB_4: https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=483545278&range=A21"
		* Categories: Categories.MarketsSelector, Categories.WorkflowRegressionTestsCategory
			* Log.Step("Create an insured and a WC RFQ");
			* Log.ExpectedResult("Check statuses and available actions");
			* Log.Step("Click Options action in order to open Options dialog");
			* Log.ExpectedResult("Agency and Producer codes aren't filled");
			* Log.Step("Perform email submit");
			* Log.ExpectedResult("Check statuses and available actions");
			* Log.Step("Upload a quote");
			* Log.ExpectedResult("Check statuses and available actions");
			* Log.Step("Open Options dialog using Options action and fill Agency and Producer codes");
			* Log.ExpectedResult("Check statuses and available actions");
			* Log.Step("Click Options action in order to open Options dialog");
			* Log.ExpectedResult("Make sure that previously entered Producer code is saved successfully");
	* Method: MarketsSelectorActionsIncludingCoverPageLogic
		* TestCaseLink: "MS_AB_3: https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=483545278&range=A18"
		* Categories: Categories.MarketsSelector, Categories.WorkflowRegressionTestsCategory, Categories.ExcludingCategoryOnlyTestingSites
			* Log.Step("Log in as a market user, create an insured and a GL RfQ");
			* Log.Step("Upload a quote");
			* Log.ExpectedResult("Check statuses and available actions");
			* Log.Step("Open Add cover page dialog and fill premium");
			* Log.ExpectedResult("Check statuses and available actions");
			* Log.Step("Open Replace cover page dialog and change premium");
			* Log.ExpectedResult("Check statuses and available actions");
* File: MarketsSelectorRefactoring.cs
	* Method: EmailViaScheduledSubmission
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A3 and " +
		                                  "https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A10 and" +
		                                  "https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A49:J49 and " +
		                                  "https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A51:J51"
		* Categories: [UNDEFINED]
	* Method: GenerateQuoteButtonNotAvailabilityAfterRfqCreation
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A23"
		* Categories: [UNDEFINED]
	* Method: MarketSelectedAfterAddMarket
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A4 and " +
		                                  "https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A5 and " +
		                                  "https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A54:J54"
		* Categories: [UNDEFINED]
	* Method: NameAndZipReservationLogic
		* TestCaseLink: "MSR_43 - https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A48"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites
	* Method: SelectedSubmarketsNotChangedAfterSubmitOnMarket
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A56:J56 and " +
		                                  "https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A55:J55"
		* Categories: [UNDEFINED]
	* Method: SubmitByEmailViaScheduledSubmission
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A3"
		* Categories: [UNDEFINED]
	* Method: SubmitOnAssurance4You
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A31:J31"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites
	* Method: UploadQuoteDocumentTwice
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A2"
		* Categories: [UNDEFINED]
* File: MarketsSelectorRefactoringPart2.cs
	* Method: BindThroughSubmarket
		* TestCaseLink: "MSR_33 - https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A38"
		* Categories: Categories.MarketsSelector
	* Method: GenerateQuoteButtonForSubmarketsOnMarketSide
		* TestCaseLink: "MSR_18: https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A19"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites
			* Log.Step("Log in as market user and Create RfQ WC line");
			* Log.Step("Select market");
			* Log.Step("Fill questionnaire to green A");
			* Log.ExpectedResult("Check set of available actions for submarket");
			* Log.ExpectedResult("Premium calculated for submarket");
	* Method: HideSubmitButtonForYourOwnMarket
		* TestCaseLink: "MSR_24.2 - https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A29"
		* Categories: [UNDEFINED]
	* Method: HideSubmitButtonForYourOwnMarketWithLogic
		* TestCaseLink: "MSR_24.1 - https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=C28"
		* Categories: [UNDEFINED]
	* Method: NewContactEmailAddressFilledInFieldTo
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A34 and" +
		                                  "https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A50"
		* Categories: [UNDEFINED]
	* Method: SendEmailAfterSubmission
		* TestCaseLink: "MSR_13: https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A14"
		* Categories: [UNDEFINED]
	* Method: SetOfButtonsNextToAutogeneratedQDsOnMarketSide
		* TestCaseLink: "MSR_16: https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A17 and" +
		                                  "MSR_17: https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A18"
		* Categories: [UNDEFINED]
	* Method: SpecifyLimitsAndDeductibleByAssignedAgency
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A27"
		* Categories: [UNDEFINED]
	* Method: SubmitByPassingFeinReservationLogic
		* TestCaseLink: "MSR_12: https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A13"
		* Categories: [UNDEFINED]
	* Method: SubmitLimitsAndDeductibleForArtisanLine
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A24"
		* Categories: [UNDEFINED]
	* Method: SubmitLimitsAndDeductibleIfThereIsOneLimit
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A21 and" +
		                                  "https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A25 and" +
		                                  "https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A53"
		* Categories: [UNDEFINED]
	* Method: UploadQuoteButtonIsMissing
		* TestCaseLink: "MSR_10 - https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A11"
		* Categories: Categories.MarketsSelector
* File: MarketsWithHidePremiumLogicOwnSide.cs
	* Method: CheckPremiumIsVisibleOnPartners
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: MergeDocumentsTests.cs
	* Method: MergeDocumentsWithDifferentAttributes
		* TestCaseLink: "DT_MD_0002: https://docs.google.com/spreadsheets/d/1c-n85yM4eX0FTdhkAoQDqgZzItawEBh_CXpyGeth2is/edit#gid=140324046&range=A4:A5"
		* Categories: [UNDEFINED]
			* Log.Step("Select both documents. Press 'Merge PDF' button");
			* Log.Step("Rename document and save file");
			* Log.ExpectedResult("Only merged document is shown. It has private attribute");
	* Method: MergeDocumentsWithPrivateAttributes
		* TestCaseLink: "DT_MD_0003: https://docs.google.com/spreadsheets/d/1c-n85yM4eX0FTdhkAoQDqgZzItawEBh_CXpyGeth2is/edit#gid=140324046&range=A6:A7"
		* Categories: [UNDEFINED]
			* Log.Step("Select both documents. Press 'Merge PDF' button");
			* Log.Step("Rename document and save file");
			* Log.ExpectedResult("Only merged document is shown. It has private attribute");
	* Method: MergeDocumentsWithSharedAttributes
		* TestCaseLink: "DT_MD_0001: https://docs.google.com/spreadsheets/d/1c-n85yM4eX0FTdhkAoQDqgZzItawEBh_CXpyGeth2is/edit#gid=140324046&range=A2:A3"
		* Categories: [UNDEFINED]
			* Log.Step("Select both documents. Press 'Merge PDF' button");
			* Log.Step("Rename document and save file");
			* Log.ExpectedResult("Only merged document is shown. It has shared attribute");
* File: ModelTests.cs
	* Method: Period_ExceptionOnCreateDateTime
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: MotorTruckCargoRatingTests.cs
	* Method: RatingCalculationForMtcWithNonAvailableCommodities
		* TestCaseLink: "Bro-7: https://docs.google.com/spreadsheets/d/1jBGIks6RAdLiDkkpQuthKhhCCvZu5KjPoSfyISvvWas/edit#gid=1884073390&range=A46:A50"
		* Categories: [UNDEFINED]
			* Log.Step("Log in AND create RFQ");
			* Log.Step("Select market");
			* Log.Step("Fill questionnaire, select limit's and deductible's values");
			* Log.Step("Edit questionnaire by adding non-available commodity for TX");
			* Log.Step("Edit questionnaire by changing zip code to AZ");
* File: MultipleFormsForSign.cs
	* Method: RequestToBind
		* TestCaseLink: "SF-1 - https://docs.google.com/spreadsheets/d/18w2P9JQRw8DEXCHFbv541hdtVGiFdRReZ2CNb4NEZuM/edit#gid=0&range=C2:C8"
		* Categories: [UNDEFINED]
* File: NaicsCodesTests.cs
	* Method: CheckClassCodesDialogAdditionalFiltersOnFormsEditingPage
		* TestCaseLink: "CC_02.2 https://docs.google.com/spreadsheets/d/1WuC1xwu4jhTlNHmZoXAxIV0ZW9R04Q22oVMg_0NXVHY/edit#gid=1050697731&range=A6:A7"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency user, create an insured and a WC RFQ");
			* Log.Step($"Open Forms tab and click 'Edit' for {FormForEditing}");
			* Log.Step("Open Class Codes lookup dialog by clicking on magnifier icon next to NAICS question and check filters");
	* Method: CheckClassCodesDialogAdditionalFiltersOnInsuredMainInformationPage
		* TestCaseLink: "CC_02.1 https://docs.google.com/spreadsheets/d/1WuC1xwu4jhTlNHmZoXAxIV0ZW9R04Q22oVMg_0NXVHY/edit#gid=1050697731&range=A4:A5"
		* Categories: [UNDEFINED]
			* Log.Step("Set 'Use NAICS Code instead of Business Type' setting to enabled");
			* Log.Step("Log in as an agency user, create an insured");
			* Log.Step("Open 'Class Codes lookup dialog' and check filters' work");
	* Method: CheckClassCodesLookupTextSearchOnFormsEditingPage
		* TestCaseLink: "CC_03.2 https://docs.google.com/spreadsheets/d/1WuC1xwu4jhTlNHmZoXAxIV0ZW9R04Q22oVMg_0NXVHY/edit#gid=1050697731&range=A9"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency user, create an insured and a WC RFQ");
			* Log.Step($"Open Forms tab and click 'Edit' for {FormForEditing}");
			* Log.Step("Open Class Codes lookup dialog by clicking on magnifier icon next to NAICS question and check search field");
	* Method: CheckClassCodesLookupTextSearchOnInsuredMainInformationPage
		* TestCaseLink: "CC_03.1 https://docs.google.com/spreadsheets/d/1WuC1xwu4jhTlNHmZoXAxIV0ZW9R04Q22oVMg_0NXVHY/edit#gid=1050697731&range=A8"
		* Categories: [UNDEFINED]
			* Log.Step("Set 'Use NAICS Code instead of Business Type' setting to enabled");
			* Log.Step("Log in as an agency user, create an insured");
			* Log.Step("Open 'ClassCodes lookup dialog' and check search field's work");
	* Method: CheckClassCodesOnFormEditor
		* TestCaseLink: "CC_04: https://docs.google.com/spreadsheets/d/1WuC1xwu4jhTlNHmZoXAxIV0ZW9R04Q22oVMg_0NXVHY/edit#gid=1050697731&range=A10:A13"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency user, open previously created RFQ, go to Forms tab and open ACORD 130 for editing");
			* Log.Step("Open Class Codes lookup dialog and check some internals");
			* Log.Step("Filter data using a class code");
			* Log.ExpectedResult("Check an infotip internals");
			* Log.Step("Click the code to fill answer");
	* Method: ClassCodesLookupCanBeOpenedIfQuestionFilled
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
			* Log.Step("Create WC RfQ");
			* Log.Step("Find and expand 'Subject' -> 'Payroll and Rating' collection");
			* Log.Step("Fill Class Code questions one of possible values");
			* Log.Step("Open lookup container for correct filled class code question");
	* Method: NaicsClassCodesFullTextSearchByPartWord
		* TestCaseLink: "CC_05.1: https://docs.google.com/spreadsheets/d/1WuC1xwu4jhTlNHmZoXAxIV0ZW9R04Q22oVMg_0NXVHY/edit#gid=1050697731&range=A14"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency user, create an insured");
			* Log.Step("Open 'Class Codes lookup dialog' and check text search");
	* Method: NaicsClassCodesFullTextSearchPositiveTest
		* TestCaseLink: "CC_05.2: https://docs.google.com/spreadsheets/d/1WuC1xwu4jhTlNHmZoXAxIV0ZW9R04Q22oVMg_0NXVHY/edit#gid=1050697731&range=A15"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency user, create an insured and a WC RFQ");
			* Log.Step($"Open Forms tab and click 'Edit' for {FormForEditing}");
			* Log.Step("Open Class Codes lookup dialog by clicking on magnifier icon next to NAICS question and check text search");
* File: NaicsCodesToBusinessTypesConversionTests.cs
	* Method: CheckBusinessTypeToNaicsCodesConversion
		* TestCaseLink: "BTNC-2 - https://docs.google.com/spreadsheets/d/1WuC1xwu4jhTlNHmZoXAxIV0ZW9R04Q22oVMg_0NXVHY/edit#gid=1974144190&range=A7:I9"
		* Categories: [UNDEFINED]
			* Log.Step("Set Use NAICS Code instead of Business Type setting to enabled");
			* Log.Step("Generate an application with insured");
			* Log.Step("Set Use NAICS Code instead of Business Type setting to disabled");
			* Log.Step("Open insured and check business types");
			* Log.Step("Set Use NAICS Code instead of Business Type setting to enabled");
	* Method: CheckNaicsCodesToBusinessTypeConversions
		* TestCaseLink: "BTNC-1 - https://docs.google.com/spreadsheets/d/1WuC1xwu4jhTlNHmZoXAxIV0ZW9R04Q22oVMg_0NXVHY/edit#gid=1974144190&range=A3:J6"
		* Categories: [UNDEFINED]
			* Log.Step("Set Use NAICS Code instead of Business Type setting to disabled");
			* Log.Step("Create insured");
			* Log.Step("Set Use NAICS Code instead of Business Type setting to enabled");
			* Log.Step("Open insured and check codes");
			* Log.Step("Set Use NAICS Code instead of Business Type setting to disabled");
* File: Nexsure.cs
	* Method: NexsureValidationAssignedAgencyNotLinked
		* TestCaseLink: "N_8: https://docs.google.com/spreadsheets/d/1Z8x6rCZ8Ghl3j1xmWR_rrQAIHkSiHK0Zm7n56-6qrZQ/edit#gid=1829011479&range=C21:C22"
		* Categories: [UNDEFINED]
	* Method: NexsureValidationContactNotCreated
		* TestCaseLink: "N_9: https://docs.google.com/spreadsheets/d/1Z8x6rCZ8Ghl3j1xmWR_rrQAIHkSiHK0Zm7n56-6qrZQ/edit#gid=1829011479&range=A21:A22"
		* Categories: [UNDEFINED]
	* Method: NexsureValidationLongInsuredName
		* TestCaseLink: "N_10: https://docs.google.com/spreadsheets/d/1Z8x6rCZ8Ghl3j1xmWR_rrQAIHkSiHK0Zm7n56-6qrZQ/edit#gid=1829011479&range=A23:A24"
		* Categories: [UNDEFINED]
	* Method: NexsureValidationNotFullInsuredInfo
		* TestCaseLink: "N_11 - https://docs.google.com/spreadsheets/d/1Z8x6rCZ8Ghl3j1xmWR_rrQAIHkSiHK0Zm7n56-6qrZQ/edit#gid=1829011479&range=A25"
		* Categories: [UNDEFINED]
* File: NotesForSelectedAgencyTests.cs
	* Method: CreateNoteForSelectedAgencyAndCheckItsVisibility
		* TestCaseLink: "AgN-1: https://docs.google.com/spreadsheets/d/1R4n1ccXJiZP4vn228Hrhww5AHq_dVHdJeur6aZpraJ8/edit#gid=139240487&range=2:9"
		* Categories: [UNDEFINED]
			* Log.Step("Reopen 'Notes' tab for Agency");
			* Log.ExpectedResult("'Notes' tab is opened, has an empty multiline text field and disabled 'Save' button");
			* Log.Step("Enter text to the text field");
			* Log.ExpectedResult("Height of text field is increased in proportion to the text");
			* Log.ExpectedResult("Width of text field is not increased");
			* Log.ExpectedResult("'Save' button became active");
			* Log.Step("Click 'Save' button");
			* Log.ExpectedResult("'Successfully saved.' tooltip is displayed");
			* Log.ExpectedResult("'Save' button became inactive");
			* Log.Step("Refresh the page");
			* Log.ExpectedResult("Saved text is displayed after refresh");
			* Log.Step("Log in as a market user, go to Agencies -> Selected, open 'Notes' tab for Agency");
			* Log.ExpectedResult("'Notes' tab is opened, has multiline text field and 'Save' button");
			* Log.ExpectedResult("Text saved by the market admin user is displayed");
* File: ParametersReservationOnQuestionnaire.cs
	* Method: CheckThatFeinIsSuccessfullyReservedAndReleasedByMarketUser
		* TestCaseLink: "FE04M - FE05M - https://docs.google.com/spreadsheets/d/1D_GWRgPb6d68zUfhSnJXCysGhUpUDmy4v7naSxxUxPQ/edit#gid=819256561&range=22:25"
		* Categories: [UNDEFINED]
			* Log.Step("Create new Insured on the Market Side");
			* Log.Step("Create RfQ on the agency side and check Fein Reservation om Agency side");
			* Log.Step("Delete Insured in the Market side ti release Fein");
			* Log.Step("Check that Fein was released");
* File: PartnerAgencyManagement.cs
	* Method: ChangeEnabledSendSubmissionsState
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: CheckPartnerAgencySubmissionInfo
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: CreateAgencyUserFromMarket
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: EnableSendingSubmissions
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: PolicyDecisionsTests.cs
	* Method: CredentialsInProgramHavePriorityOverUserCredentialsFromClientSite
		* TestCaseLink: "PDeS_11 : https://docs.google.com/spreadsheets/d/1Z8x6rCZ8Ghl3j1xmWR_rrQAIHkSiHK0Zm7n56-6qrZQ/edit#gid=522732504&range=36:38"
		* Categories: [UNDEFINED]
			* Log.Step("Uplink PDF as an agency user");
			* Log.Step($"Unselect 'Check All' checkbox, select checkbox for {market} only and make submission by clicking Send");
			* Log.ExpectedResult($"'{successfulSubmissionMessage}' message is displayed");
			* Log.Step("Clear submission options for market and open Q&A page");
			* Log.ExpectedResult("Submission initiated");
			* Log.Step("Resubmit to market");
			* Log.ExpectedResult("There are two activity record about submission in activity log");
* File: PolicyManagementTests.cs
	* Method: CoverageLinesSelectionUsingRecordTabDialogTest
		* TestCaseLink: "CL-1: https://docs.google.com/spreadsheets/d/1dPYJDkikzE8-19h_zZySUpqk81fFoUJJkOkpcjf30g0/edit#gid=0&range=A2:A7"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency user and create a 'Commercial Package' RFQ with 'Cyber liability' coverage selected");
			* Log.ExpectedResult($"Check set of sections on questionnaire and set of subsections on the '{_coverageHistorySectionTitle}' section");
			* Log.Step("Click on insurance line name in record tab");
			* Log.ExpectedResult("Check 'Coverage lines' dialog elements and values");
			* Log.Step("Add a coverage line");
			* Log.ExpectedResult("Check the set of sections and subsections after a new coverage line is added, but not saved");
			* Log.Step("Save coverage lines changes");
			* Log.ExpectedResult("Check the set of sections and subsections after a new coverage line is added and saved");
			* Log.Step("Open Options tab");
			* Log.ExpectedResult("Check selected coverages on Options tab");
* File: PolicySharedOverSubmissionChainPolicyDocumentsVisibilityTests.cs
	* Method: DocumentsAreVisibleInSubmissionChain
		* TestCaseLink: "AR-2: https://docs.google.com/spreadsheets/d/1mHHonW3ITyfeY-mnTeKq9P-gcw-Jyv52L90zX1HpSkw/edit#gid=1550464163&range=8:16"
		* Categories: [UNDEFINED]
			* Log.Step($"Agent creates Rfq, adds '{MarketWithSubmarket.Name}' Mga and uploads a document");
			* Log.Step("Agent submits to Mga");
			* Log.Step("Mga underwriter logs in and uploads a document");
			* Log.ExpectedResult("Uploaded by the agent document is visible for Mga underwriter");
			* Log.Step($"Mga underwriter submits it to '{Submarket.Name}' carrier");
			* Log.ExpectedResult("Carrier underwriter logs in and uploads a document");
			* Log.ExpectedResult("Uploaded by the agent and the mga user documents are visible for a carrier underwriter");
			* Log.ExpectedResult("Uploaded by the mga and the carrier users documents are visible for the agent");
* File: PolicyUnbindLogic.cs
	* Method: AgencyUserCannotUnbindPolicyBoundByAppulateSubmissionTypeMarket
		* TestCaseLink: "Unb-1: https://docs.google.com/spreadsheets/d/1_t9MLTsQsW8kwo9s3tY9xxvWko95sbfUvsYnFGVJ1dw/edit#gid=1189027623&range=A2"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency user and create a WC RFQ");
			* Log.Step($"Select the {market.Name} and submit to it");
			* Log.Step($"Log in as the '{market.Name}' market's user, upload a quote document and bind RFQ");
			* Log.Step("Log in as an agency user and find bound policy");
			* Log.ExpectedResult("Check that market status is 'Bound' and 'Unbind' button is disabled");
	* Method: AgencyUserCannotUnbindPolicyBoundByMarkAsSubmittedAction
		* TestCaseLink: "Unb-5: https://docs.google.com/spreadsheets/d/1_t9MLTsQsW8kwo9s3tY9xxvWko95sbfUvsYnFGVJ1dw/edit#gid=1189027623&range=A10"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency user and create a WC RFQ");
			* Log.Step($"Select the {market.Name} and mark it as submitted");
			* Log.Step("Upload a quote document and bind the RFQ");
			* Log.ExpectedResult("Check that market status is 'Bound' and 'Unbind' button is disabled");
* File: PopupTooltipTests.cs
	* Method: CheckLinksToQpdUnansweredQuestionsInTooltip
		* TestCaseLink: "QPD-L3 - https://docs.google.com/spreadsheets/d/1pV13jp7eLCgU2pkXEdBS6DnGrH_BC6fuoaOhsM0y6Ms/edit#gid=1990270110&range=27:38"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites, Categories.BrooksideGeneral
			* Log.Step("Fill state. D indicator is expected");
			* Log.Step("Clear Garage sate answer");
			* Log.ExpectedResult("Expect orange A Indicator with tooltip that contains links");
			* Log.ExpectedResult("Expect orange A Indicator with tooltip that contains links");
			* Log.ExpectedResult("Expect orange A Indicator with tooltip that contains links");
	* Method: CheckLinksToQpdUnansweredQuestionsInTooltipNonGreenIndicator
		* TestCaseLink: "QPD-L2 - https://docs.google.com/spreadsheets/d/1pV13jp7eLCgU2pkXEdBS6DnGrH_BC6fuoaOhsM0y6Ms/edit#gid=1990270110&range=16:26"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites, Categories.BrooksideGeneral
	* Method: CheckMessageAndClosableAdmissionTooltip
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: CheckSuccessTooltipMessageAndCloseOnProfile
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: LinksFromAdmissionTooltipLeadToQpdRequiredItems
		* TestCaseLink: "QPD-L1: https://docs.google.com/spreadsheets/d/1pV13jp7eLCgU2pkXEdBS6DnGrH_BC6fuoaOhsM0y6Ms/edit#gid=1990270110&range=A2:A15"
		* Categories: Categories.BrooksideGeneral
			* Log.Step("Log in as an agency user, create an insured and an Automobile - Business RFQ");
			* Log.Step($"Select the {mga.Name} market and check the following submarkets under it: {carrierLloyds.Name} and {carrierSutter.Name}");
			* Log.ExpectedResult($"{carrierLloyds.Name} and {carrierSutter.Name} submarkets have admission indicators");
			* Log.Step($"Hover over the admission indicator next to the {mga.Name} mga");
			* Log.ExpectedResult($"Admission tooltip contains information about required  coverage for each submarket: {carrierLloyds.Name} and {carrierSutter.Name}");
			* Log.Step($"Hover over the admission indicator next to the {mga.Name} mga");
			* Log.ExpectedResult($"Admission tooltip contains information about required '{deductibleRequirement}' deductible for {carrierLloyds.Name} and" +
			                   $" required '{coverageRequirementSutter}' coverage for {carrierSutter.Name}");
			* Log.Step($"Hover over the admission indicator next to the {carrierLloyds.Name} submarket");
			* Log.ExpectedResult($"Admission tooltip contains information about required '{deductibleRequirement}' deductible for {carrierLloyds.Name}");
			* Log.Step($"Hover over the admission indicator next to the {carrierSutter.Name} submarket");
			* Log.ExpectedResult($"Admission tooltip contains information about required '{coverageRequirementSutter}' coverage for {carrierSutter.Name}");
			* Log.Step($"Hover over the admission indicator next to the {carrierSutter.Name} submarket");
			* Log.ExpectedResult($"Admission tooltip contains information about required '{deductibleRequirement}' deductible for {carrierSutter.Name}");
* File: Propagation.cs
	* Method: CheckMarketGuide
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: InsuredIndicatorNotChangingFromGreenUtoOrangeU
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A12"
		* Categories: [UNDEFINED]
* File: ProspectsCrmTests.cs
	* Method: CrmCompanyCreate
		* TestCaseLink: "CRM-1 - CRM-5 : https://docs.google.com/spreadsheets/d/1imd2RMJVeeJcOfCsHTDJPoUIg2NrcSLQpa-3xjsMA58/edit#gid=984751844"
		* Categories: [UNDEFINED]
			* Log.Step("Create new Crm Company");
			* Log.ExpectedResult("Created company is displayed on Prospects (CRM) page");
			* Log.Step("Open Edit Crm Company page");
			* Log.ExpectedResult("Creation date displayed correct on Edit page");
			* Log.Step("Add new Crm Company Contact");
			* Log.ExpectedResult("Created Contact displayed on Edit page");
			* Log.Step($"Assign {manager} - manager to created Crm Company");
			* Log.ExpectedResult("Assigned manager is displayed on Prospects (CRM) page for company");
			* Log.Step("Open All contacts page");
			* Log.Step("Open Edit Crm Company page by contact");
			* Log.ExpectedResult("Created contact is displayed on Edit page");
			* Log.Step("Edit contact");
			* Log.ExpectedResult("Edited contact is displayed on Edit page");
			* Log.Step("Filter Crm company by Sources dropdown filter");
			* Log.Step("Filtered Crm company by Sources is displayed");
* File: QuestionAnswerCreationTests.cs
	* Method: QuestionCollectionCreateAnswer_AnswerModificationCreated
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: QuestionCollectionCreateAnswer_ThrowArgumentOutOfRangeExceptionWhenCollectionIndexIsNotZeroAndNoAnswersAdded
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: QuestionCollectionCreateAnswer_ThrowArgumentOutOfRangeExceptionWhenQuestionNotFound
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: QuestionCollectionCreateAnswerArray_AnswerModificationsCreated
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: QuestionCollectionCreateAnswerArray_ThrowArgumentOutOfRangeExceptionWhenCollectionIndexIsNotZeroAndNoAnswersAdded
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: QuestionCreateAnswer_AnswerModificationCreated
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: QuestionCreateAnswer_AnswerModificationWithParentIdxCreated
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: QuestionMultiselectCreateAnswer_AnswerModificationCreated
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: QuestionPicklistCreateAnswer_ThrowArgumentOutOfRangeExceptionWhenOptionNotFoundByLabel
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: QuestionSelectCreateAnswer_AnswerModificationCreated
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: QuestionSelectCreateAnswer_ThrowArgumentOutOfRangeExceptionWhenOptionNotFoundByLabel
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: QuestionnaireDataTests.cs
	* Method: AllSections_IsFlattenedSectionsTree
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: FindByPath_QuestionFound
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: FindByPath_QuestionNotFound
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: FindBySection_QuestionsFound
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: FindBySection_QuestionsFoundByGenericType
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: QuestionnaireHelperTests.cs
	* Method: GetQuestionnaire_DataParsed
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: GetQuestionnaireWithAnswers_DataParsed
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: QuoteCoverPageTests.cs
	* Method: AppulateQuoteCoverPageSettingIsUncheckedForNewProgram
		* TestCaseLink: "DCP_0001 - DCP_0002 : https://docs.google.com/spreadsheets/d/1v3nG4q8jGhZB_OJmhuMPJcncsOaZUB5vlqJPu2WJAwc/edit#gid=429415091&range=2:5"
		* Categories: [UNDEFINED]
			* Log.Step($"Log in to Admin site, find {market}, go to Programs tab");
			* Log.Step("Add Program");
			* Log.ExpectedResult("Quote cover page label is shown in Quotes section. Appulate checkbox is unchecked");
			* Log.Step("Log in as a market user, create an insured and Rfq");
			* Log.Step($"Upload PDF file {pdfQuoteName} using Upload quote button");
			* Log.ExpectedResult($"{MarketsSelectorAction.MarkAsBound.GetDescription()} button is the main active button for {pdfQuoteName}");
			* Log.ExpectedResult($"{MarketsSelectorAction.AddCoverPage.GetDescription()} button is not appeared for {pdfQuoteName}");
			* Log.Step($"Upload not PDF file {notPdfDocumentName} using Upload quote button");
			* Log.ExpectedResult($"{MarketsSelectorAction.MarkAsBound.GetDescription()} is the main active button for {notPdfDocumentName}");
			* Log.ExpectedResult($"{MarketsSelectorAction.AddCoverPage.GetDescription()} button is not appeared for {notPdfDocumentName}");
			* Log.Step($"Log in to Admin, go to Programs tab of {market}");
			* Log.Step("Check Appulate checkbox for Quote cover page in Quotes section and save changes");
			* Log.ExpectedResult("Appulate checkbox is checked");
			* Log.Step("Log in to the main site as a market user, open the Rfq");
			* Log.ExpectedResult($"{MarketsSelectorAction.AddCoverPage.GetDescription()} button is the main active button for {pdfQuoteName}");
			* Log.ExpectedResult($"{MarketsSelectorAction.MarkAsBound.GetDescription()} button exists in actions menu for {pdfQuoteName}");
			* Log.ExpectedResult($"{MarketsSelectorAction.MarkAsBound.GetDescription()} button is the main active button for {notPdfDocumentName}");
			* Log.ExpectedResult($"{MarketsSelectorAction.AddCoverPage.GetDescription()} button is not appeared for {notPdfDocumentName}");
* File: QuotedOnColumnInQuotesGridTests.cs
	* Method: GeneralQuotedOnTest
		* TestCaseLink: "QouteGrid1 - https://docs.google.com/spreadsheets/d/1vti36wD8exGu1-ZQKhEdaKhfOL13V3NZfV06cuUTu2Q/edit#gid=0&range=A3:G13"
		* Categories: [UNDEFINED]
			* Log.Step("Create RfQ and submit on market");
			* Log.Step("Submit on submarket");
			* Log.Step("Upload quote document on SUBMARKET side");
			* Log.Step("Release quote document on SUBMARKET side");
			* Log.Step("Before release quote document on MARKET side");
			* Log.Step("Release quote document on MARKET side");
			* Log.Step("Before send quote document to insured on AGENCY side");
			* Log.Step("Send quote document to insured on AGENCY side");
			* Log.Step("Change status of quote document on 'Accepted by Insured'");
			* Log.Step("Check QuotedOn on MARKET side");
			* Log.Step("Check QuotedOn on SUBMARKET side");
* File: QuoteGenerationSettingsTests.cs
	* Method: DefaultQuoteGeneratorSwitchingTest
		* TestCaseLink: "qd_cc_04 - https://docs.google.com/spreadsheets/d/1XvwVbDvFAog70B0kI6V0lJl2ANZWdSKSz0mHVPR6FYM/edit#gid=0&range=A26:A31"
		* Categories: [UNDEFINED]
			* Log.Step("Set Dummy generator as default for market");
			* Log.Step("Check settings (market -> agency)");
			* Log.Step("Check, that auto-generation appeared on Markets' Selector on agency side");
			* Log.Step("Set AppulateInternal generator as default for market");
			* Log.Step("Check settings (market -> agency)");
			* Log.Step("Check, that auto-generation NOT appeared on Markets' Selector on agency side");
* File: QuoteGenerationTests.cs
	* Method: ExModValuesPresentInQuoteDocumentFileOnlyForStates
		* TestCaseLink: "AmTrust-WC-QGEMNS-01: https://docs.google.com/spreadsheets/d/1Fxh5RiDMOWikMOCB_TC9bI5ysTVVUwfciVu5OkrBFLM/edit#gid=0&range=A14:A19"
		* Categories: Categories.Clients.External.AmTrustWc
			* Log.Step($"Create Insured and RFQ, select {carrier}");
			* Log.Step("Fill out questionnaire");
			* Log.Step("Click on QPD icon and select 1M/1M/1M value");
			* Log.ExpectedResult("MGA and Carrier have green A indicators, Submit button is displayed for Carrier");
			* Log.Step($"Perform submit on {carrier}");
			* Log.ExpectedResult($"Record's and {carrier}'s status is Quote Prepared");
			* Log.ExpectedResult("Quote document generated and estimated premium calculated");
			* Log.Step("Open record's activity log page");
			* Log.ExpectedResult("Check events in Activity tab of record");
			* Log.ExpectedResult("Check ExMod value only for DE state is present in Quote Document Requested Technical Information file");
	* Method: LimitsAndDeductibleValuesCopiedToFailedRequestRow
		* TestCaseLink: "QGE_002: https://docs.google.com/spreadsheets/d/1o_Eefg2vZqFxZLGYigD2mTbS6UdSSNaDUy8hloZfBDg/edit#gid=1037188020&range=A9"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agent, create GL line Rfq");
			* Log.Step("Select Carrier(with Dummy generator and 'Failed' setting for generations) on MS");
			* Log.Step("Submit to carrier");
			* Log.Step("Request Quote from carrier");
			* Log.ExpectedResult("Correct Limits and Deductibles are appeared in Quote Request line");
	* Method: NewFailedRequestRowForFailedGenerations
		* TestCaseLink: "QGE_001: https://docs.google.com/spreadsheets/d/1o_Eefg2vZqFxZLGYigD2mTbS6UdSSNaDUy8hloZfBDg/edit#gid=1037188020&range=A2"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agent, create Wild line Rfq");
			* Log.Step("Select Mga with Carrier(with Dummy generator and 'Failed' setting for generations) on MS");
			* Log.Step("Submit to Mga");
			* Log.Step("Log in as an Mga user, go to current Rfq");
			* Log.Step("Submit from Mga to Carrier");
			* Log.Step("Log in as an agent, go to current RFQ");
			* Log.Step("Click Request Quote for Carrier");
			* Log.Step("Log in as an Mga, go to current RFQ");
			* Log.Step("Click Request Quote for Carrier");
			* Log.Step("Log in as an Carrier, go to current RFQ");
			* Log.Step("Click Request Quote for Carrier");
			* Log.Step("Log in as an Mga, go to current RFQ");
			* Log.Step("Log in as an agent, go to current RFQ");
	* Method: OrchidUnderwritersHighNetWorthQuoteGenerationTest
		* TestCaseLink: "OQID_001 - https://docs.google.com/spreadsheets/d/1v3nG4q8jGhZB_OJmhuMPJcncsOaZUB5vlqJPu2WJAwc/edit#gid=1439682558&range=A2:A6"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites
			* Log.Step("Log in as an agency user, create an Automobile-Personal RFQ, select markets and submit");
			* Log.ExpectedResult("Check that submit is successful and market status is changed");
			* Log.Step($"Log in as an {mga.Name} market user and open received RFQ");
			* Log.Step($"Click 'Upload quote' button under the {carrier.Name} carrier");
			* Log.ExpectedResult("Check that the following fields are required: 'Policy Period', 'Total Premium', 'Upload Quote'");
			* Log.Step("Fill out required fields and upload a .pdf document");
			* Log.ExpectedResult("Check that document is uploaded correctly");
			* Log.Step("Download the quote document and check it");
	* Method: QuoteGenerationAndQuoteForAutobLloydsAndSutterUnderBrookside
		* TestCaseLink: "Bro-Q2: https://docs.google.com/spreadsheets/d/1jBGIks6RAdLiDkkpQuthKhhCCvZu5KjPoSfyISvvWas/edit#gid=1570398961&range=A7:A12"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites, Categories.BrooksideGeneral
			* Log.Step("Log in as an MGA user, create RFQ and select carriers on Markets Selector");
			* Log.ExpectedResult($"There are '{MarketStatus.NotSubmitted}' status AND upload quote action for '{sutterCarrier}' market");
			* Log.ExpectedResult($"There are '{MarketStatus.NotSubmitted}' status AND upload quote action for '{lloydsCarrier}' market");
			* Log.Step("Fill questionnaire");
			* Log.Step("Fill coverage and deductible for markets");
			* Log.Step("Add loss run history, attach loss run doc");
			* Log.Step("Upload Motor Vehicle Record and Vehicle Registration Certificate documents to Docs tab");
			* Log.Step("Assign an agency and a producer");
			* Log.ExpectedResult($"Upload quote and generate quote actions are available for '{sutterCarrier.Name}' market");
			* Log.ExpectedResult($"Upload quote and generate quote actions are available for '{lloydsCarrier}' market");
			* Log.Step("Generate quote");
			* Log.ExpectedResult("Quote appeared under market");
			* Log.ExpectedResult($"There are '{MarketStatus.QuotePrepared}' status AND upload quote and generate quote actions for '{sutterCarrier}' market");
			* Log.ExpectedResult($"There are '{MarketStatus.NotSubmitted}' status AND upload quote and quote generation actions for '{lloydsCarrier}' market");
			* Log.ExpectedResult("Pdf file has same values as questionnaire");
			* Log.Step("Generate quote");
			* Log.ExpectedResult("Quote NOT appeared under market");
			* Log.ExpectedResult(
				$"For '{Markets.BrooksideGeneralInsuranceServicesTesting}' market there is '{MarketStatus.QuotePrepared}' status. Upload quote and generate quote actions are NOT available");
			* Log.ExpectedResult($"Quote appeared for '{lloydsCarrier}' market");
			* Log.ExpectedResult($"There are '{MarketStatus.QuotePrepared}' status AND upload quote link AND quote generation link for '{lloydsCarrier}' market");
			* Log.ExpectedResult("Pdf file has same values as questionnaire");
	* Method: QuoteGenerationAndQuoteForGlAndIllinoisUnderBrookside
		* TestCaseLink: "Bro-Q3: https://docs.google.com/spreadsheets/d/1jBGIks6RAdLiDkkpQuthKhhCCvZu5KjPoSfyISvvWas/edit?ts=5de9220e#gid=1570398961&range=A15:A18"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites, Categories.BrooksideGeneral
			* Log.Step("Create rfq AND select market");
			* Log.Step("Fill location and business type");
			* Log.ExpectedResult($"Upload quote and generate quote actions are available for '{market}' market");
			* Log.Step("Generate quote");
			* Log.ExpectedResult($"There is '{MarketStatus.QuotePrepared}' status for '{market}' market. Upload quote and Generate Quote are available");
			* Log.ExpectedResult($"Quote appeared for '{market}' market");
			* Log.ExpectedResult("Pdf file has same values as questionnaire");
	* Method: QuoteGenerationAndQuoteForMtcLloydsUnderBrookside
		* TestCaseLink: "Bro-Q1: https://docs.google.com/spreadsheets/d/1jBGIks6RAdLiDkkpQuthKhhCCvZu5KjPoSfyISvvWas/edit#gid=1570398961&range=A2:A5"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites, Categories.BrooksideGeneral
			* Log.Step("Log in AND create RFQ");
			* Log.Step("Select market");
			* Log.ExpectedResult($"There is '{MarketStatus.NotSubmitted}' status AND upload quote link");
			* Log.Step("Fill questionnaire and select limit's and deductible's values");
			* Log.ExpectedResult($"There is '{MarketStatus.NotSubmitted}' status");
			* Log.Step("Go to Loss Runs tab, add loss run history and attach loss run doc for a market");
			* Log.Step($"Open Docs tab and upload a '{DocumentType.MotorVehicleRecord.GetDescription()}' document");
			* Log.Step("Assign an agency and a producer");
			* Log.Step("Open qa page");
			* Log.ExpectedResult("Upload quote link with generate quote link are available");
			* Log.Step("Generate quote");
			* Log.ExpectedResult("Quote appeared under market");
			* Log.ExpectedResult($"There is '{MarketStatus.QuotePrepared}' status AND upload quote link with generate quote link are available");
			* Log.ExpectedResult("There is NO quote under market");
			* Log.ExpectedResult($"There is '{MarketStatus.QuotePrepared}' status AND upload quote link with generate quote link are NOT available");
	* Method: SunzHoldingQuoteGeneration
		* TestCaseLink: "SunzWC-QG-01 : https://docs.google.com/spreadsheets/d/1sja2AIS2o-fe-U_qkbaisyungSujyc6wTqs_caxNSMA/edit#gid=0&range=A2:A5"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites
			* Log.Step("Log in as an underwriter in SUNZ market AND create an WC RFQ");
			* Log.Step("Select underwriter");
			* Log.Step("Open Q&A page");
			* Log.ExpectedResult($"There is '{MarketStatus.NotSubmitted}' status");
			* Log.ExpectedResult($"Upload quote action is available for {market}, Generate quote is available for {carrier1}, {carrier2}");
			* Log.Step("Open generate quote dialog");
			* Log.ExpectedResult("Rating dialog is opened");
			* Log.Step("Generate quote");
			* Log.ExpectedResult($"There is '{MarketStatus.QuotePrepared}' status");
			* Log.ExpectedResult("Quote appeared under market");
			* Log.ExpectedResult($"Upload quote AND generate quote links are available for {carrier1.Name}");
	* Method: SyndicatedWcForQuoteGenerationWithMarketSpecificity
		* TestCaseLink: "Syn-01: https://docs.google.com/spreadsheets/d/1o_Eefg2vZqFxZLGYigD2mTbS6UdSSNaDUy8hloZfBDg/edit#gid=1928642754&range=2:3"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites
			* Log.Step("Log in as an agent, create Workers Compensation Rfq");
			* Log.Step($"Add {market} market to Markets Selector");
			* Log.Step("Filled Questionnaire to green U, submit to market");
			* Log.Step("Log in a market user, open the Rfq");
			* Log.Step($"Add {aigMarket.Name}, {sunzInsuranceMarket.Name} markets to Markets Selector");
			* Log.ExpectedResult($"The {market} has no Generate quote action, it has only Upload quote action");
			* Log.ExpectedResult($"{aigMarket.Name} has Generate and Upload quote actions");
			* Log.Step($"Generate a quote for {aigMarket.Name} market");
			* Log.ExpectedResult($"Quote is generated for {aigMarket.Name} and has name '[Insured's name] - proposal.pdf'");
			* Log.ExpectedResult($"{sunzInsuranceMarket.Name} has no Generate quote action");
* File: QuoteReleaseTests.cs
	* Method: CancelQuoteCoverLetter
		* TestCaseLink: "QUO-REL-05: https://docs.google.com/spreadsheets/d/1oqbYdT3X3x_Pixt-pzS1H7H_eNxX8ZrLZ3oWTVeHbJU/edit#gid=20973911&range=A28:A30"
		* Categories: [UNDEFINED]
			* Log.Step("Click 'Release' action and cancel 'Cover Letter' sending");
			* Log.ExpectedResult("Check RFQ interface elements: Quote status - Quote prepared, Release action is active");
	* Method: QuoteReleaseWithCoverLetter
		* TestCaseLink: "QUO-REL-02: https://docs.google.com/spreadsheets/d/1oqbYdT3X3x_Pixt-pzS1H7H_eNxX8ZrLZ3oWTVeHbJU/edit#gid=20973911&range=A6:A13"
		* Categories: [UNDEFINED]
			* Log.Step("Click 'Release' action and cancel 'Cover Letter' sending");
			* Log.ExpectedResult("Check RFQ interface elements: Quote status - Quote prepared, Release action is active");
			* Log.Step("Click 'Release' action, upload any document to the email editor and send a cover letter");
			* Log.ExpectedResult("Check RFQ interface elements: Quote status - Quote released, Bind action is active, 'Quote prepared' and 'Cover letter' emails have been sent");
			* Log.Step("Open activity tab and check Quote Cover Letter related events");
			* Log.Step("Log in as an agency user again and open RFQ");
			* Log.Step("Check that quote document status is 'Quote prepared'");
			* Log.Step("Open activity tab and check Quote Cover Letter related events");
	* Method: QuoteReleaseWithoutCoverLetter
		* TestCaseLink: "QUO-REL-01: https://docs.google.com/spreadsheets/d/1oqbYdT3X3x_Pixt-pzS1H7H_eNxX8ZrLZ3oWTVeHbJU/edit#gid=20973911&range=A1:A4"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as a market user, create a WC RFQ and select a Source agency");
			* Log.Step("Upload a quote document and release it to the agency");
			* Log.ExpectedResult("Check RFQ interface elements: Quote status - Quote released, Bind action is active, 'Quote prepared' email has been sent");
			* Log.Step("Open activity tab of the RFQ");
			* Log.ExpectedResult("Check that 'Quote Document Released' appears");
			* Log.Step("Log in as an agency user and open assigned RFQ");
			* Log.ExpectedResult("Check RFQ interface elements: Quote status - Quote prepared, Request to bind action is active");
* File: QuotesGridsTests.cs
	* Method: CheckRecordDisplayInQuotesGrids
		* TestCaseLink: "QM-1, QM-2, QM-3: https://docs.google.com/spreadsheets/d/1TNc8VONemJNIS6H2tJ-5CpgPZk4XZRPJWEtEVxCQFTM/edit#gid=517954195&range=B2:B7"
		* Categories: Categories.SentDocumentForSignCategory
			* Log.Step("Create RFQ and open QA page");
			* Log.ExpectedResult("Record isn't displayed in Quotes->New/Unassigned grid");
			* Log.Step("Reopen RFQ, open Options tab, set None for Producer dropdown and click Save button");
			* Log.ExpectedResult("Record is displayed in Quotes->New/Unassigned grid");
			* Log.Step("Reopen RFQ, select market, fill out questionnaire, submit");
			* Log.ExpectedResult("Record is displayed in Quotes->Underway grid");
			* Log.ExpectedResult("Record isn't displayed in Quotes->New/Unassigned grid");
	* Method: RecordDisplayedInQuotesGridsAfterActionsWithAnotherPolicyRecordForTheSameInsured
		* TestCaseLink: "QM-5: https://docs.google.com/spreadsheets/d/1TNc8VONemJNIS6H2tJ-5CpgPZk4XZRPJWEtEVxCQFTM/edit#gid=517954195"
		* Categories: Categories.PolicyCategory
			* Log.Step($"Log in as an agent, create a policy for '{_market}', WC line");
			* Log.Step("Log in as an market user, and open Options tab for created policy");
			* Log.Step("Assign Underwriter to policy as current market user and renew policy");
			* Log.Step("Open recently created policy and set effective dates - (today-2years) for provoke expired policy");
* File: RatingTests.cs
	* Method: CheckCaliforniaMarketsPremiumWithTwoCodesAndExMod
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: CheckNevadaPremium
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: CheckScifPremium
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: RealTimeSynchronizationTests.cs
	* Method: ActiveUsersCountTest
		* TestCaseLink: "Case PB-01: https://docs.google.com/spreadsheets/d/1JaRs6EgNBftLh5rvSnNJijWmGUAS-8RVWMQvYgXK7so/edit#gid=1012879454&range=A2:A3"
		* Categories: [UNDEFINED]
	* Method: CheckEditionOfBigTextBoxControl
		* TestCaseLink: "RT-06 - https://docs.google.com/spreadsheets/d/1JaRs6EgNBftLh5rvSnNJijWmGUAS-8RVWMQvYgXK7so/edit#gid=281790202&range=A17:A18"
		* Categories: [UNDEFINED]
			* Log.Step("Create RFQ and open current RFQ in two browser");
			* Log.Step($"Fill value on questionnaire in '{questionTitle}' field");
			* Log.ExpectedResult("Entered value displayed correct on second user side");
			* Log.ExpectedResult("Entered value displayed correct on first user side");
			* Log.Step("Delete insured by API");
	* Method: CheckEditionOfControlWithFeinValidator
		* TestCaseLink: "RT-02 - https://docs.google.com/spreadsheets/d/1JaRs6EgNBftLh5rvSnNJijWmGUAS-8RVWMQvYgXK7so/edit#gid=281790202&range=A6:A8"
		* Categories: [UNDEFINED]
			* Log.Step("Create RFQ and open current RFQ in two browser");
			* Log.Step("Fill invalid value in FEIN field");
			* Log.ExpectedResult("There are correct error Fein Message, fein value - displayed for first browser");
			* Log.ExpectedResult("There are correct error Fein Message, fein value, user tooltip - displayed for second browser");
			* Log.Step("Fill valid value in FEIN field");
			* Log.ExpectedResult("There are not displayed - error Fein Message, fein value - correct displayed for first browser");
			* Log.ExpectedResult("There are not displayed - error Fein Message, fein value - displayed, user tooltip - displayed for second browser");
			* Log.ExpectedResult("Tooltip on questionnaire about activity of users displayed correct information");
			* Log.Step("Delete insured by API");
	* Method: CheckEditionOfSelectControlPresentedAsDropdown
		* TestCaseLink: "RT-11 - https://docs.google.com/spreadsheets/d/1JaRs6EgNBftLh5rvSnNJijWmGUAS-8RVWMQvYgXK7so/edit#gid=281790202&range=A33:A36"
		* Categories: [UNDEFINED]
			* Log.Step("Create RFQ and open current RFQ in two browser");
			* Log.Step($"Open FormEditor page on editing '{acord}'");
			* Log.ExpectedResult("Correct Section is displayed on first user side");
			* Log.ExpectedResult($"Fill question '{question}' on FormEditor questionnaire on first user side");
			* Log.ExpectedResult("Question answer is correct on first user side");
			* Log.ExpectedResult("Question answer is correct on second user side");
			* Log.ExpectedResult("Question is highLighted and user is displayed on second user side");
			* Log.ExpectedResult($"Change answer on question '{question}' on FormEditor questionnaire on second user side");
			* Log.ExpectedResult("Question answer is correct on second user side");
			* Log.ExpectedResult("Question is still highLighted on second user side");
			* Log.ExpectedResult("Question answer is correct on first user side");
			* Log.ExpectedResult("Question is highLighted on first user side");
			* Log.Step("Delete insured by API");
	* Method: CheckEditionOfSelectControlRenderedAsRadio
		* TestCaseLink: "RT-10 - https://docs.google.com/spreadsheets/d/1JaRs6EgNBftLh5rvSnNJijWmGUAS-8RVWMQvYgXK7so/edit#gid=281790202&range=A28:A32"
		* Categories: [UNDEFINED]
			* Log.Step("Create RFQ and open current RFQ in two browser");
			* Log.Step($"Go to section '{section}' -> '{subsection}' subsection on first user side");
			* Log.ExpectedResult($"Check that '{collection}' collection is visible and collapsed");
			* Log.ExpectedResult($"'{collection}' collection contain '{question}' column with correct answer on first user side");
			* Log.Step($"Go to section '{section}' -> '{subsection}' subsection on second user side");
			* Log.ExpectedResult($"'{collection}' collection contain '{question}' column with correct answer on second user side");
			* Log.ExpectedResult("User and highlighting answer correct in collection row on second user side");
			* Log.Step("Expand collection  on second user side");
			* Log.ExpectedResult("User and highlighting answer correct in expanded question in collection  on second user side");
			* Log.Step($"Changed answer in question '{question}' to '{secondAnswer}' on second user side");
			* Log.ExpectedResult("User and highlighting answer correct in expanded question in collection on unanswered value on second user side");
			* Log.ExpectedResult("Answer correct in question in collection column on second user side");
			* Log.Step("Expand collection on first user side");
			* Log.ExpectedResult($"'{collection}' collection contain '{question}' column with correct answer on first user side");
			* Log.ExpectedResult("User and highlighting answer correct in expanded question in collection on answered value on first user side");
			* Log.Step("Delete insured by API");
	* Method: CheckEditionOfTextBoxWithThePhoneValidator
		* TestCaseLink: "RT-12 - https://docs.google.com/spreadsheets/d/1JaRs6EgNBftLh5rvSnNJijWmGUAS-8RVWMQvYgXK7so/edit#gid=281790202&range=A37:A38"
		* Categories: [UNDEFINED]
			* Log.Step("Create RFQ and open current RFQ in two browser");
			* Log.Step($"Open FormEditor page on editing '{acord}'");
			* Log.ExpectedResult($"Fill question '{question}' on FormEditor questionnaire on first user side");
			* Log.ExpectedResult("Question answer is correct on first user side");
			* Log.ExpectedResult("Question answer is correct on second user side");
			* Log.ExpectedResult("Question is highLighted and user is displayed on second user side");
			* Log.Step("Delete insured by API");
	* Method: CheckEditionOfYesNoControls
		* TestCaseLinks:
			* "RT-07 - https://docs.google.com/spreadsheets/d/1JaRs6EgNBftLh5rvSnNJijWmGUAS-8RVWMQvYgXK7so/edit#gid=281790202&range=A19:A23"
			* "RT-08 - https://docs.google.com/spreadsheets/d/1JaRs6EgNBftLh5rvSnNJijWmGUAS-8RVWMQvYgXK7so/edit#gid=281790202&range=A24:A25"
		* Categories: [UNDEFINED]
			* Log.Step("Create RFQ and open current RFQ in two browser");
			* Log.Step($"Fill value 'No' in '{noAnswerOfQuestion.Title}' field");
			* Log.ExpectedResult("Entered value displayed correct on first user side");
			* Log.ExpectedResult("Entered value displayed correct on second user side");
			* Log.ExpectedResult("User name displayed correct in the field on second user side");
			* Log.Step($"Fill value 'Yes' in '{yesAnswerOfQuestion.Title}' field");
			* Log.ExpectedResult("Entered value displayed correct on second user side");
			* Log.ExpectedResult("User name displayed correct in the field on first user side");
			* Log.ExpectedResult("User name displayed correct in the field on first user side");
			* Log.Step($"Fill value in subquestion '{subquestionOfYesAnswer.Title}' field");
			* Log.ExpectedResult("Entered value displayed correct on first user side");
			* Log.ExpectedResult("User name still displayed correct in the field on first user side");
			* Log.ExpectedResult("User name displayed correct in the field on second user side");
			* Log.Step("Delete insured by API");
	* Method: CheckNumberActiveUsersDisplayedOnBothRfqAndReversePortalAndControls
		* TestCaseLink: "RT-14-19 - https://docs.google.com/spreadsheets/d/1JaRs6EgNBftLh5rvSnNJijWmGUAS-8RVWMQvYgXK7so/edit#gid=281790202&range=A41"
		* Categories: [UNDEFINED]
			* Log.ExpectedResult($"Tooltip on questionnaire about active users displayed correct information on {currentUserName} user side");
			* Log.ExpectedResult($"Question highlighted and correct User Name displayed on '{currentUserName}' user side");
			* Log.ExpectedResult($"Multiselect question model displayed correct on '{side}' user side");
			* Log.ExpectedResult($"Correct answer displayed in '{currentSimpleQuestion.Title}' after filling on '{side}' user side");
			* Log.Step("Create RFQ and open current RFQ in first browser");
			* Log.Step("Select market on Markets Selector");
			* Log.Step("Add new contact to Insured");
			* Log.Step("Send questionnaire to complete to new Insureds contact");
			* Log.Step("Click on the link from letter body => open questionnaire on reverse portal");
			* Log.Step($"Fill '{questionTitle}' multiselect question on first user side");
			* Log.ExpectedResult("Correct User Name Tooltip displayed on questions on reverse portal side");
			* Log.Step("Unselect first Option on Multiselect control");
			* Log.Step("Fill correct answer to Calendar question on first user side");
			* Log.Step("Fill incorrect date value on calendar field on reverse portal side");
			* Log.ExpectedResult("Correct date format error message appeared on first user side");
			* Log.ExpectedResult("Correct date format error message appeared on reverse portal user side");
			* Log.Step("Fill correct money value on Money field on first user side");
			* Log.Step("Close page on reverse portal");
			* Log.ExpectedResult("Users counter is not displayed on Navigation bar on first user side");
			* Log.Step("Delete insured by API");
	* Method: CheckRecordAddingToCollection
		* TestCaseLinks:
			* "RT-03 - https://docs.google.com/spreadsheets/d/1JaRs6EgNBftLh5rvSnNJijWmGUAS-8RVWMQvYgXK7so/edit#gid=281790202&range=A9:A11"
			* "RT-04 - https://docs.google.com/spreadsheets/d/1JaRs6EgNBftLh5rvSnNJijWmGUAS-8RVWMQvYgXK7so/edit#gid=281790202&range=A12:A13"
			* "RT-05 - https://docs.google.com/spreadsheets/d/1JaRs6EgNBftLh5rvSnNJijWmGUAS-8RVWMQvYgXK7so/edit#gid=281790202&range=A14:A16"
		* Categories: [UNDEFINED]
			* Log.Step("Create RFQ and open current RFQ in two browser");
			* Log.Step($"Add new item in collection {collectionRatingFactors.Title} and fill {stateFieldInCollection.Title} field");
			* Log.ExpectedResult("Entered value displayed correct on first user side");
			* Log.ExpectedResult("Current collection is not expanded on second user side");
			* Log.ExpectedResult("Entered value displayed correct on second user side");
			* Log.Step("Get User name from field tooltip on second user side");
			* Log.ExpectedResult("User name displayed correct in the field on second user side");
			* Log.ExpectedResult("Correct message during try to sort collection");
			* Log.ExpectedResult("Correct message during try to delete row in collection on second user side");
			* Log.Step("Try Delete row in collection from first user side");
			* Log.ExpectedResult("Row is not displayed in collection on first user side");
			* Log.ExpectedResult("Row is not displayed in collection on second user side");
			* Log.Step("Delete insured by API");
	* Method: CheckTheFillingOfAddressFields
		* TestCaseLink: "RT-13 - https://docs.google.com/spreadsheets/d/1JaRs6EgNBftLh5rvSnNJijWmGUAS-8RVWMQvYgXK7so/edit#gid=281790202&range=A39:A40"
		* Categories: [UNDEFINED]
			* Log.ExpectedResult($"Correct address is displayed on questionnaire on '{userName}' side");
			* Log.ExpectedResult($"Correct User Name Tooltip displayed on questions on '{userName}' side");
			* Log.Step("Create RFQ and open current RFQ in two browser");
			* Log.Step($"Open FormEditor page on editing '{acord}'");
			* Log.ExpectedResult("Chose address from ZipCode Lookup on first user side");
			* Log.Step("Delete insured by API");
* File: RecordSubstatusTests.cs
	* Method: CreatePolicyWithSubstatusAndCheckAllPoliciesGridTest
		* TestCaseLink: "RS_2: https://docs.google.com/spreadsheets/d/1gCx7XSKJCViMJdoH6PsDpfe-gZPX6n-HGxbAnTEd1xE/edit#gid=868663994&range=A7"
		* Categories: [UNDEFINED]
			* Log.Step("Log in to Appulate -> Create a new insured and a policy with a specified substatus");
			* Log.Step("Open 'All Policies' grid and check the substatus");
			* Log.Step("Change a substatus on the 'All Policies' grid and make sure that a row has changed its color");
			* Log.Step("Check changed substatus on the 'Options' tab of a Policy");
	* Method: CreateRfqWithSubstatusAndCheckAllRfqGridTest
		* TestCaseLink: "RS_1: https://docs.google.com/spreadsheets/d/1gCx7XSKJCViMJdoH6PsDpfe-gZPX6n-HGxbAnTEd1xE/edit#gid=868663994&range=A2"
		* Categories: [UNDEFINED]
			* Log.Step("Log in to Appulate -> Create a new insured and an RFQ with a specified substatus");
			* Log.Step("Open 'All Requests for Quote' grid and check the substatus");
			* Log.Step("Change a substatus on the 'All Requests for Quote' grid and make sure that a row has changed its color");
			* Log.Step("Check changed substatus on the 'Options' tab of an RFQ");
	* Method: SubstatusesAreNotSharedBetweenCompaniesTest
		* TestCaseLink: "RS_3: https://docs.google.com/spreadsheets/d/1gCx7XSKJCViMJdoH6PsDpfe-gZPX6n-HGxbAnTEd1xE/edit#gid=868663994&range=A12"
		* Categories: [UNDEFINED]
			* Log.Step("Log in to Appulate -> Create a new insured and a policy with a specified substatus");
			* Log.Step("Submit an RFQ to a market");
			* Log.Step("Log in as a market user, open 'All Requests for Quote' grid and check the substatus");
			* Log.Step("Specify a substatus for an RFQ on the 'All Requests for Quote' grid on a market side");
			* Log.Step("Log in as an agency user again and make sure that previously specified substatus hasn't changed");
* File: RegionsTests.cs
	* Method: AddRegionToAllLocations
		* TestCaseLink: [UNDEFINED]
		* Categories: Categories.PopupTooltipsCategory
* File: RegisterEmailContactInActivityLogTests.cs
	* Method: EmailSentToContactIsNotGroupedOnActivityLogTest
		* TestCaseLink: "ESTC_6 - https://docs.google.com/spreadsheets/d/1hHZsRjSo-W5NPhqACTbvNWkMYCMtP3uoBiiJ8-2cbTY/edit#gid=877467821&range=A33:A34"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency user and create an RFQ");
			* Log.Step("Add a new contact and send two identical emails to it");
			* Log.Step("Open Activity tab of the RFQ and check that 'Email Sent to Contact' events aren't grouped");
			* Log.Step("Open Activity Log and check that 'Email Sent to Contact' events aren't grouped");
* File: RegistrAgencyWithUniqueEmailDomainUnderMarketsUrl.cs
	* Method: RegisterAgencyUnderMarketUrl
		* TestCaseLink: "UM_01 - https://docs.google.com/spreadsheets/d/1ldCkNdi0iC1-aBwioTNrO0hOvwNtNJGcmux4CUFTX3E/edit#gid=1828615373&range=A2"
		* Categories: [UNDEFINED]
	* Method: RegisterAgencyUnderMarketUrlWithCode
		* TestCaseLink: "UM_02 - https://docs.google.com/spreadsheets/d/1ldCkNdi0iC1-aBwioTNrO0hOvwNtNJGcmux4CUFTX3E/edit#gid=1828615373&range=A3"
		* Categories: [UNDEFINED]
	* Method: RegisterAgencyUnderMarketUrlWithCodeAndCreds
		* TestCaseLink: "UM_04 - https://docs.google.com/spreadsheets/d/1ldCkNdi0iC1-aBwioTNrO0hOvwNtNJGcmux4CUFTX3E/edit#gid=1828615373&range=A5"
		* Categories: [UNDEFINED]
	* Method: RegisterAgencyUnderMarketUrlWithCreds
		* TestCaseLink: "UM_03 - https://docs.google.com/spreadsheets/d/1ldCkNdi0iC1-aBwioTNrO0hOvwNtNJGcmux4CUFTX3E/edit#gid=1828615373&range=A4"
		* Categories: [UNDEFINED]
* File: RegistrationOfAgencyUnderMarketUrlTests.cs
	* Method: BackNavigationFromMarketInformationToUserInformation
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1ldCkNdi0iC1-aBwioTNrO0hOvwNtNJGcmux4CUFTX3E/edit#gid=1828615373&range=A8"
		* Categories: [UNDEFINED]
	* Method: BackNavigationFromUserInformationToCompanyInformation
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1ldCkNdi0iC1-aBwioTNrO0hOvwNtNJGcmux4CUFTX3E/edit#gid=1828615373&range=A6"
		* Categories: [UNDEFINED]
	* Method: CheckMarketInfoRadioButtonDefaultValue
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1ldCkNdi0iC1-aBwioTNrO0hOvwNtNJGcmux4CUFTX3E/edit#gid=1828615373&range=A12"
		* Categories: [UNDEFINED]
	* Method: EmptyCredentialsCouldBeSavedWithoutErrors
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1ldCkNdi0iC1-aBwioTNrO0hOvwNtNJGcmux4CUFTX3E/edit#gid=1828615373&range=A15"
		* Categories: [UNDEFINED]
	* Method: MissedValuesOnMarketInformation
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1ldCkNdi0iC1-aBwioTNrO0hOvwNtNJGcmux4CUFTX3E/edit#gid=1828615373&range=A11"
		* Categories: [UNDEFINED]
	* Method: NavigationBetweenMarketInformationAndUserInformation
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1ldCkNdi0iC1-aBwioTNrO0hOvwNtNJGcmux4CUFTX3E/edit#gid=1828615373&range=A9"
		* Categories: [UNDEFINED]
	* Method: NavigationBetweenUserInformationAndCompanyInformation
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1ldCkNdi0iC1-aBwioTNrO0hOvwNtNJGcmux4CUFTX3E/edit#gid=1828615373&range=A7"
		* Categories: [UNDEFINED]
	* Method: OverflowingValuesOnMarketInformation
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1ldCkNdi0iC1-aBwioTNrO0hOvwNtNJGcmux4CUFTX3E/edit#gid=1828615373&range=A10"
		* Categories: [UNDEFINED]
	* Method: SaveLoginWithoutPasswordThrowsError
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1ldCkNdi0iC1-aBwioTNrO0hOvwNtNJGcmux4CUFTX3E/edit#gid=1828615373&range=A13"
		* Categories: [UNDEFINED]
	* Method: SavePasswordWithoutLoginThrowsError
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1ldCkNdi0iC1-aBwioTNrO0hOvwNtNJGcmux4CUFTX3E/edit#gid=1828615373&range=A14"
		* Categories: [UNDEFINED]
* File: RenewActivityLog.cs
	* Method: RenewPolicyAndCheckActivityLogEvent
		* TestCaseLink: "Renew-18.1: https://docs.google.com/spreadsheets/d/1f2iaDmDNuLIgQV0oqTT0k-HJvngsImds7py-vnJghjg/edit#gid=675829155&range=A113:A114"
		* Categories: [UNDEFINED]
			* Log.Step("Login on main site as Appulate,Inc user");
			* Log.Step("Open 'Options' tab");
			* Log.Step("Renew and open renewed RFQ");
			* Log.Step("Open 'Activity' tab");
			* Log.ExpectedResult("Activity log contains 'Record Renewed' event");
* File: ReportsDataVerificationSemiAutomatedTests.cs
	* Method: AllActivitiesAdminReportDataCollection
		* TestCaseLink: "RR1: https://docs.google.com/spreadsheets/d/1vaD8LKKueeksa7DWu3Fuh67Ywmndl6bQ5UyX0Ylp20w/edit#gid=0&range=E3"
		* Categories: Categories.ReportsDataCollection
			* Log.Step($"Log in to admin site and open the {nameof(AllActivitiesReportPage)} report");
			* Log.Step("Filter report data");
			* Log.Step("Expand columns");
			* Log.Step("Collect data and save it to an email");
	* Method: AllSubmissionsAdminReportDataCollection
		* TestCaseLink: "RR1: https://docs.google.com/spreadsheets/d/1vaD8LKKueeksa7DWu3Fuh67Ywmndl6bQ5UyX0Ylp20w/edit#gid=0&range=E4"
		* Categories: Categories.ReportsDataCollection
			* Log.Step($"Log in to admin site and open the {nameof(AllSubmissionsReportPage)} report");
			* Log.Step("Filter report data");
			* Log.Step("Expand columns");
			* Log.Step("Collect data and save it to an email");
	* Method: BookOfBusinessMainSiteReportDataCollection
		* TestCaseLink: "RR1: https://docs.google.com/spreadsheets/d/1vaD8LKKueeksa7DWu3Fuh67Ywmndl6bQ5UyX0Ylp20w/edit#gid=0&range=E10"
		* Categories: Categories.ReportsDataCollection
			* Log.Step($"Log in to admin site and open the {nameof(BookOfBusinessReportPage)} report");
			* Log.Step("Filter report data");
			* Log.Step("Collect data and save it to an email");
	* Method: ClassCodesAdminReportDataCollection
		* TestCaseLink: "RR1: https://docs.google.com/spreadsheets/d/1vaD8LKKueeksa7DWu3Fuh67Ywmndl6bQ5UyX0Ylp20w/edit#gid=0&range=E5"
		* Categories: Categories.ReportsDataCollection
			* Log.Step($"Log in to admin site and open the {nameof(ClassCodesReportPage)} report");
			* Log.Step("Filter report data");
			* Log.Step("Expand rows and columns");
			* Log.Step("Collect data and save it to an email");
	* Method: GenerateReportsTestData
		* TestCaseLink: [UNDEFINED]
		* Categories: Categories.ReportsDataGeneration
			* Log.Step("Log in as an agency user, create an insured and a WC RFQ");
			* Log.Step("Open 'All insured' page and make a copy of the recently created insured");
			* Log.Step("Open copied insured's RFQ, fill questionnaire, select a market and submit to it by email");
			* Log.Step("Upload a quote and bind policy");
			* Log.Step("Log in as a root user to admin site and create a new market with WC program and a user in it");
			* Log.Step($"Log in to the main site, open Agencies -> Available page and add the {TestingAgency.Name} to the Selected list");
			* Log.Step($"Open Markets -> Available page and add the {EmailMarket.Name} to the Selected list");
			* Log.Step("Create a new insured on the market side and select a source agency");
			* Log.Step("Select market and submit to it by email");
	* Method: RequestsForQuoteMainSiteReportDataCollection
		* TestCaseLink: "RR1: https://docs.google.com/spreadsheets/d/1vaD8LKKueeksa7DWu3Fuh67Ywmndl6bQ5UyX0Ylp20w/edit#gid=0&range=E8"
		* Categories: Categories.ReportsDataCollection
			* Log.Step($"Log in to admin site and open the {nameof(RequestsForQuoteReportPage)} report");
			* Log.Step("Filter report data");
			* Log.Step("Expand rows");
			* Log.Step("Collect data and save it to an email");
	* Method: StatisticsMainSiteReportDataCollection
		* TestCaseLink: "RR1: https://docs.google.com/spreadsheets/d/1vaD8LKKueeksa7DWu3Fuh67Ywmndl6bQ5UyX0Ylp20w/edit#gid=0&range=E11"
		* Categories: Categories.ReportsDataCollection
			* Log.Step($"Log in to admin site and open the {nameof(StatisticsReportPage)} report");
			* Log.Step("Filter report data");
			* Log.Step("Expand rows");
			* Log.Step("Collect data and save it to an email");
	* Method: SubmissionsMainSiteReportDataCollection
		* TestCaseLink: "RR1: https://docs.google.com/spreadsheets/d/1vaD8LKKueeksa7DWu3Fuh67Ywmndl6bQ5UyX0Ylp20w/edit#gid=0&range=E9"
		* Categories: Categories.ReportsDataCollection
			* Log.Step($"Log in to admin site and open the {nameof(SubmissionsReportPage)} report");
			* Log.Step("Filter report data");
			* Log.Step("Collect data and save it to an email");
	* Method: SubmittingAgenciesAdminReportDataCollection
		* TestCaseLink: "RR1: https://docs.google.com/spreadsheets/d/1vaD8LKKueeksa7DWu3Fuh67Ywmndl6bQ5UyX0Ylp20w/edit#gid=0&range=E6"
		* Categories: Categories.ReportsDataCollection
			* Log.Step($"Log in to admin site and open the {nameof(SubmittingAgenciesReportPage)} report");
			* Log.Step("Filter report data");
			* Log.Step("Expand columns");
			* Log.Step("Collect data and save it to an email");
	* Method: WorkCompClassCodesMainSiteReportDataCollection
		* TestCaseLink: "RR1: https://docs.google.com/spreadsheets/d/1vaD8LKKueeksa7DWu3Fuh67Ywmndl6bQ5UyX0Ylp20w/edit#gid=0&range=E12"
		* Categories: Categories.ReportsDataCollection
			* Log.Step($"Log in to admin site and open the {nameof(WorkCompClassCodesReportPage)} report");
			* Log.Step("Filter report data");
			* Log.Step("Expand columns and rows");
			* Log.Step("Collect data and save it to an email");
* File: ReportUiTests.cs
	* Method: CheckFilter
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
			* Log.Step("Open Work Comp Class Codes Report Page");
			* Log.Step("Check grid data before change filters");
			* Log.Step("Sort by Descending");
			* Log.Step("Filter by Last Year");
	* Method: CheckFilterOnQuotesReport
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
			* Log.Step("Open Quotes Report Page");
			* Log.Step("Open tab 'By Date', filter and sorting (EncinoInsuranceCo, Descending, LastYear)");
			* Log.Step("Filter and sorting (Today, AimMutualInsCo) for empty data");
	* Method: ExpandAndCollapseColumnsAndRows
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
			* Log.Step("Open Work Comp Class Codes Report Page");
			* Log.Step("Check value before expand");
			* Log.Step("Check value after expand columns");
			* Log.Step("Check value after expand rows");
			* Log.Step("Check value after collapse columns");
			* Log.Step("Check value after collapse rows");
* File: ResourceNotFoundException.cs
	* Method: ResourceNotFoundExceptionContentExpected
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1Kvrs9g-WBcpF7dZGKIsm7QBpiheehN-9NycOGIZE7Rw/edit#gid=0&range=6:6"
		* Categories: [UNDEFINED]
* File: SelectDeselectMarket.cs
	* Method: AdminCanDeselectMarket
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: AdminCanSelectMarket
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: UserCanNotDeselectMarket
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: SendDocsViaEmailTests.cs
	* Method: SendAcordsAndSupplementalsFromPolicyQuoteDocsByEmail
		* TestCaseLink: "SD-01: https://docs.google.com/spreadsheets/d/1c-n85yM4eX0FTdhkAoQDqgZzItawEBh_CXpyGeth2is/edit#gid=0&range=A9:H17"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agent, open a WC policy of already existing insured and open Quote Docs page");
			* Log.Step("Send acord forms by an email");
			* Log.ExpectedResult("Check that email is delivered with selected acord forms as attachments");
	* Method: SendEncinoWcPolicyDocument
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agent, open a WC policy of already existing insured and open Policy Docs page");
			* Log.Step("Send already existing policy by an email");
			* Log.ExpectedResult("Check that email is delivered with already existing policy doc as an attachment");
	* Method: SendUploadedPolicyDocumentForNewInsuredUser
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agent, create a WC policy and open Policy Docs page");
			* Log.Step("Upload a document");
			* Log.Step("Send document by an email");
			* Log.ExpectedResult("Check that email is delivered with recently uploaded document as an attachment");
* File: SessionExpirationTests.cs
	* Method: SessionTerminatedAfterDeletingSessionId
		* TestCaseLink: "SS-4 - https://docs.google.com/spreadsheets/d/1yWoVlk2brnJHuk4zINjHeXpD-rvMLIShORCNCWrEg64/edit#gid=0&range=A11:A13"
		* Categories: [UNDEFINED]
	* Method: SessionTerminatedIfAllInsuredOpenedInOtherTab
		* TestCaseLink: "SS-2 - https://docs.google.com/spreadsheets/d/1yWoVlk2brnJHuk4zINjHeXpD-rvMLIShORCNCWrEg64/edit#gid=0&range=A6:A10"
		* Categories: [UNDEFINED]
	* Method: SessionTerminatedIfQaPageIsOpenedInOtherTab
		* TestCaseLink: "SS-5 - https://docs.google.com/spreadsheets/d/1yWoVlk2brnJHuk4zINjHeXpD-rvMLIShORCNCWrEg64/edit#gid=0&range=A14:A15"
		* Categories: [UNDEFINED]
	* Method: SessionTerminatedInDuplicatedTab
		* TestCaseLink: "SS-1: https://docs.google.com/spreadsheets/d/1yWoVlk2brnJHuk4zINjHeXpD-rvMLIShORCNCWrEg64/edit#gid=0&range=A2:A5"
		* Categories: [UNDEFINED]
* File: SettingsPageTests.cs
	* Method: CheckAgencyManagementSystemSetting
		* TestCaseLink: "SP-AMS-03 - https://docs.google.com/spreadsheets/d/1lOWuH2CnLtkYA067HcQ3ZKUjO_zdpUxU7lpVgct7rK0/edit#gid=767009783&range=7:9"
		* Categories: [UNDEFINED]
			* Log.Step("Select 'Nexsure' value in drop-down of 'External AMS' setting, clear required fields and try save");
			* Log.ExpectedResult("Red warning messages appear for each required field of Nexsure Integration section");
			* Log.ExpectedResult("Fill all the required settings of 'Nexsure Integration' section with valid values, select checkbox of 'Export insured' setting");
			* Log.ExpectedResult("Click Save and refresh the page");
			* Log.ExpectedResult("Check Nexsure Integration values provided before are displayed");
	* Method: CheckAppointmentRequirementsSetting
		* TestCaseLink: "SP-APP-02 - https://docs.google.com/spreadsheets/d/1lOWuH2CnLtkYA067HcQ3ZKUjO_zdpUxU7lpVgct7rK0/edit#gid=87448771&range=6:6"
		* Categories: [UNDEFINED]
	* Method: CheckAppulateMarketsListingSetting
		* TestCaseLink: "SP-GEN-04-05 - https://docs.google.com/spreadsheets/d/1lOWuH2CnLtkYA067HcQ3ZKUjO_zdpUxU7lpVgct7rK0/edit#gid=0&range=7:10"
		* Categories: [UNDEFINED]
	* Method: CheckAutoRenewalSettingWithInvalidValues
		* TestCaseLink: "SP-GEN-19, SP-GEN-20, SP-GEN-21, SP-GEN-22, SP-GEN-23, SP-GEN-24 - https://docs.google.com/spreadsheets/d/1lOWuH2CnLtkYA067HcQ3ZKUjO_zdpUxU7lpVgct7rK0/edit#gid=0&range=35:40"
		* Categories: [UNDEFINED]
			* Log.Step($"Change the number of days to {boarderValueWithErrorMessage.Key}");
			* Log.ExpectedResult("Check that an expected error message is displayed in case of invalid data entered");
	* Method: CheckAutoRenewalSettingWithValidNumberOfDays
		* TestCaseLink: "SP-GEN-17 : https://docs.google.com/spreadsheets/d/1lOWuH2CnLtkYA067HcQ3ZKUjO_zdpUxU7lpVgct7rK0/edit#gid=0&range=31:32"
		* Categories: [UNDEFINED]
			* Log.Step("Select 'Auto-renewal' checkbox, fill number of days from 1 to 120 in 'days prior to the policy expiration date' field appeared");
			* Log.Step("Click 'Save' and refresh the page");
			* Log.ExpectedResult("The setting is displayed with the updated value");
	* Method: CheckAvailabilityForMarketsSetting
		* TestCaseLink: "SP-GEN-02-03 - https://docs.google.com/spreadsheets/d/1lOWuH2CnLtkYA067HcQ3ZKUjO_zdpUxU7lpVgct7rK0/edit#gid=0&range=3:6"
		* Categories: [UNDEFINED]
	* Method: CheckChangesNotificationSettingCheckboxes
		* TestCaseLink: "SP-NOT-11, SP-NOT-12, SP-NOT-13,SP-NOT-14 - https://docs.google.com/spreadsheets/d/1lOWuH2CnLtkYA067HcQ3ZKUjO_zdpUxU7lpVgct7rK0/edit#gid=969239596&range=12:15"
		* Categories: [UNDEFINED]
	* Method: CheckControlOfAgencyUsersByMarketsSetting
		* TestCaseLink: "SP-SEC-21-22 - https://docs.google.com/spreadsheets/d/1lOWuH2CnLtkYA067HcQ3ZKUjO_zdpUxU7lpVgct7rK0/edit#gid=324678628&range=28:29"
		* Categories: [UNDEFINED]
	* Method: CheckCustomHelpUrlSettingWithRandomValue
		* TestCaseLink: "SP-GEN-33 - https://docs.google.com/spreadsheets/d/1lOWuH2CnLtkYA067HcQ3ZKUjO_zdpUxU7lpVgct7rK0/edit#gid=0&range=60:60"
		* Categories: [UNDEFINED]
	* Method: CheckEffectiveDateDelayMoreThanSetting
		* TestCaseLink: "SP-GEN-16 : https://docs.google.com/spreadsheets/d/1lOWuH2CnLtkYA067HcQ3ZKUjO_zdpUxU7lpVgct7rK0/edit#gid=0&range=27:29"
		* Categories: [UNDEFINED]
	* Method: CheckHintsAreDisplayed
		* TestCaseLink: "SP-GEN-01 : https://docs.google.com/spreadsheets/d/1lOWuH2CnLtkYA067HcQ3ZKUjO_zdpUxU7lpVgct7rK0/edit#gid=0&range=2:2"
		* Categories: [UNDEFINED]
	* Method: CheckInterlocationIsolationLevelSetting
		* TestCaseLink: "SP-SEC-04, SP-SEC-05 - https://docs.google.com/spreadsheets/d/1lOWuH2CnLtkYA067HcQ3ZKUjO_zdpUxU7lpVgct7rK0/edit#gid=324678628&range=5:6"
		* Categories: [UNDEFINED]
	* Method: CheckInvalidValidEmailsForAppointmentNotificationEmailAddressSetting
		* TestCaseLink: "SP-APP-01 - https://docs.google.com/spreadsheets/d/1lOWuH2CnLtkYA067HcQ3ZKUjO_zdpUxU7lpVgct7rK0/edit#gid=87448771&range=2:5"
		* Categories: [UNDEFINED]
			* Log.Step("Login as a market admin user, open Settings page");
			* Log.Step("Select 'Require my agencies to go through Appointment process' checkbox");
			* Log.Step("Fill invalid email in the text field of 'Appointment notification email address' setting, save");
			* Log.ExpectedResult("'Appointment notification email address is incorrect' message appears");
			* Log.Step("Fill valid email in the text field of 'Appointment notification email address' setting, save and reopen page");
			* Log.ExpectedResult("Valid email is saved in 'Appointment notification email address' field");
	* Method: CheckInvitationPageUrlSettingHasLinkToJoinToAppulatePage
		* TestCaseLink: "SP-GEN-34 - https://docs.google.com/spreadsheets/d/1lOWuH2CnLtkYA067HcQ3ZKUjO_zdpUxU7lpVgct7rK0/edit#gid=0&range=61:63"
		* Categories: [UNDEFINED]
			* Log.Step("Click on URL presented in 'Invitation page URL' setting");
			* Log.ExpectedResult("'Join on Appulate' header is displayed on page opened");
			* Log.ExpectedResult("Click on 'Copy to Clipboard' icon");
			* Log.ExpectedResult("'Copy to Clipboard' icon is marked with green tick. The icon's hint is changed to 'Copied to Clipboard'.");
			* Log.Step("Open new tab in browser and paste URL from Clipboard");
			* Log.ExpectedResult("'Join on Appulate' header is displayed on page opened");
	* Method: CheckMyMarketsVisibilitySelectInvisibleSetting
		* TestCaseLink: "SP-GEN-08 - https://docs.google.com/spreadsheets/d/1lOWuH2CnLtkYA067HcQ3ZKUjO_zdpUxU7lpVgct7rK0/edit#gid=0&range=15:16"
		* Categories: [UNDEFINED]
			* Log.Step("Login as a market user, choose 'Select' in 'My Markets' Visibility for Agents' setting, save");
			* Log.Step("Open Markets -> Selected, choose 'Invisible' setting for the submarket");
			* Log.Step("Login as an agent of the licensed agency, create a request for quote");
			* Log.ExpectedResult("Check the submarket is invisible to the agency");
	* Method: CheckMyMarketsVisibilitySelectVisibleNotSelectedSetting
		* TestCaseLink: "SP-GEN-09 - https://docs.google.com/spreadsheets/d/1lOWuH2CnLtkYA067HcQ3ZKUjO_zdpUxU7lpVgct7rK0/edit#gid=0&range=17:17"
		* Categories: [UNDEFINED]
			* Log.Step("Login as a market user, choose 'Select' in 'My Markets' Visibility for Agents' setting, save");
			* Log.Step("Open Markets -> Selected, choose 'Visible not selected' setting for the submarket");
			* Log.Step("Login as an agent of the licensed agency, create a request for quote");
			* Log.ExpectedResult("Check the submarket is visible to the agency but not selected");
	* Method: CheckMyMarketsVisibilitySelectVisibleSelectedSetting
		* TestCaseLink: "SP-GEN-10 - https://docs.google.com/spreadsheets/d/1lOWuH2CnLtkYA067HcQ3ZKUjO_zdpUxU7lpVgct7rK0/edit#gid=0&range=18:18"
		* Categories: [UNDEFINED]
			* Log.Step("Login as a market user, choose 'Select' in 'My Markets' Visibility for Agents' setting, save");
			* Log.Step("Open Markets -> Selected, choose 'Visible, selected' setting for the submarket");
			* Log.Step("Login as an agent of the licensed agency, create a request for quote");
			* Log.ExpectedResult("Check the submarket is visible to the agency and selected");
	* Method: CheckMyMarketsVisibilitySetting
		* TestCaseLink: "SP-GEN-06, SP-GEN-07 - https://docs.google.com/spreadsheets/d/1lOWuH2CnLtkYA067HcQ3ZKUjO_zdpUxU7lpVgct7rK0/edit#gid=0&range=11:14"
		* Categories: [UNDEFINED]
	* Method: CheckRegionsSetting
		* TestCaseLink: "SP-GEN-25-26 - https://docs.google.com/spreadsheets/d/1lOWuH2CnLtkYA067HcQ3ZKUjO_zdpUxU7lpVgct7rK0/edit#gid=0&range=42:44"
		* Categories: [UNDEFINED]
	* Method: CheckRequiredDocumentsSetting
		* TestCaseLink: "SP-APP-03 - https://docs.google.com/spreadsheets/d/1lOWuH2CnLtkYA067HcQ3ZKUjO_zdpUxU7lpVgct7rK0/edit#gid=87448771&range=7:7"
		* Categories: [UNDEFINED]
			* Log.Step("Login as a market admin user, open Settings page");
			* Log.Step("Fill multi-select field of the 'Required Documents' setting with any two values");
			* Log.Step("Unselect one value by pressing cross button");
			* Log.Step("Save");
			* Log.ExpectedResult("Valid document type is saved in 'Required Documents' field");
	* Method: CheckSettingIsAvailableForAgent
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: CheckSettingIsAvailableForMga
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: CheckTurnOffAutoRenewalSetting
		* TestCaseLink: "SP-GEN-18 : https://docs.google.com/spreadsheets/d/1lOWuH2CnLtkYA067HcQ3ZKUjO_zdpUxU7lpVgct7rK0/edit#gid=0&range=33:34"
		* Categories: [UNDEFINED]
			* Log.Step("Deselect 'Auto-renewal' checkbox");
			* Log.Step("Click 'Save' and refresh the page");
			* Log.ExpectedResult("The setting is displayed with the updated value");
	* Method: CheckTwoFactorAuthenticationSetting
		* TestCaseLink: "SP-SEC-15, SP-SEC-16, SP-SEC-17 - https://docs.google.com/spreadsheets/d/1lOWuH2CnLtkYA067HcQ3ZKUjO_zdpUxU7lpVgct7rK0/edit#gid=324678628&range=16:18"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agent");
			* Log.Step($"Set {option} option in 'Two Factor Authentication' setting, save, refresh page");
			* Log.ExpectedResult($"{option} is expected after page refresh in 'Two Factor Authentication' setting");
	* Method: CheckUplinkSettingsDisplayedForAgentUser
		* TestCaseLink: "SP-UPL-02 - https://docs.google.com/spreadsheets/d/1lOWuH2CnLtkYA067HcQ3ZKUjO_zdpUxU7lpVgct7rK0/edit#gid=1343898036&range=3:3"
		* Categories: [UNDEFINED]
	* Method: CheckUplinkSettingsDisplayedForMarketUser
		* TestCaseLink: "SP-UPL-01 - https://docs.google.com/spreadsheets/d/1lOWuH2CnLtkYA067HcQ3ZKUjO_zdpUxU7lpVgct7rK0/edit#gid=1343898036&range=2:2"
		* Categories: [UNDEFINED]
	* Method: CheckWhoCanDeleteInsuredSetting
		* TestCaseLink: "SP-SEC-06, SP-SEC-07, SP-SEC-08 - https://docs.google.com/spreadsheets/d/1lOWuH2CnLtkYA067HcQ3ZKUjO_zdpUxU7lpVgct7rK0/edit#gid=324678628&range=7:9"
		* Categories: [UNDEFINED]
* File: SharedPrivateDocumentsTests.cs
	* Method: BindedQuoteUploadedToMarketsSelectorIsPrivateDespiteQuoteUploadedToDocsTab
		* TestCaseLink: "ShPr_0005: https://docs.google.com/spreadsheets/d/1mHHonW3ITyfeY-mnTeKq9P-gcw-Jyv52L90zX1HpSkw/edit#gid=1550464163&range=38:38"
		* Categories: [UNDEFINED]
			* Log.Step($"Add {documentName1} document with Quote type to Docs tab");
			* Log.Step($"Upload {documentName2} document with Quote type to Markets Selector");
			* Log.Step($"Press '{MarketsSelectorAction.MarkAsBound.GetDescription()}' button");
			* Log.Step("Go to Quote Docs tab, section Quotes");
			* Log.ExpectedResult($"{documentName1} and {documentName2} are visible for the agent user. {documentName1} has disabled Shared icon, {documentName2} has disabled Private icon");
	* Method: DocumentIsSharedByDefaultForAnyUserOfCompanyAndHasMakePrivateButton
		* TestCaseLink: "ShPr_0001: https://docs.google.com/spreadsheets/d/1mHHonW3ITyfeY-mnTeKq9P-gcw-Jyv52L90zX1HpSkw/edit#gid=1550464163&range=18:19"
		* Categories: [UNDEFINED]
			* Log.Step("Upload document of any type except ACORD, Supplemental, Loss Run to Docs tab");
			* Log.ExpectedResult($"The document is visible for '{agent1.FirstName} {agent1.LastName}', Shared icon is enabled");
			* Log.Step($"Log in as an '{agent2.FirstName} {agent2.LastName}' of the company, open the RFQ, go to Docs tab");
			* Log.ExpectedResult($"The document is visible for '{agent2.FirstName} {agent2.LastName}', Shared icon is enabled");
	* Method: PrivateAttributeIsSavedIfDocumentTypeIsChanged
		* TestCaseLink: "ShPr_0003: https://docs.google.com/spreadsheets/d/1mHHonW3ITyfeY-mnTeKq9P-gcw-Jyv52L90zX1HpSkw/edit#gid=1550464163&range=26:31"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as a market user, open the RFQ, go to Docs tab");
			* Log.ExpectedResult($"{documentName} is visible for the market user, Share icon is disabled");
			* Log.ExpectedResult("Activity log for the RFQ has 2 records for the document (Document uploaded, Document changed)");
			* Log.Step("Log in as the agent, open the RFQ, go to Docs tab");
			* Log.Step($"Make {documentName} private and change it type");
			* Log.ExpectedResult("Activity log for the RFQ has new Document changed record for the document");
			* Log.Step("Log in as a market user, open the RFQ, go to Docs tab");
			* Log.ExpectedResult($"{documentName} is not visible for the market user");
			* Log.ExpectedResult($"Activity log for the RFQ doesn't have any records with {documentName}");
	* Method: SharedDocumentOnPolicyTabIsVisibleForNonOwnersPrivateIsNotVisible
		* TestCaseLink: "ShPr_0004: https://docs.google.com/spreadsheets/d/1mHHonW3ITyfeY-mnTeKq9P-gcw-Jyv52L90zX1HpSkw/edit#gid=1550464163&range=32:37"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as a market user, open the policy, go to Docs tab");
			* Log.ExpectedResult($"{documentName1}, {documentName2} are visible for the market user, Share icon is visible and disabled for both");
			* Log.ExpectedResult("Activity log for the policy has 'Document uploaded' records for each document");
			* Log.Step("Log in as the agent, open the policy, go to Docs tab");
			* Log.Step($"Make {documentName1} private");
			* Log.ExpectedResult($"{documentName1} and {documentName2} are visible for the agent user. {documentName1} has enabled Private icon");
			* Log.ExpectedResult($"Activity log doesn't have additional records for {documentName1}");
			* Log.Step("Log in as a market user, open the policy, go to Docs tab");
			* Log.ExpectedResult($"{documentName1} is not visible for the market user. {documentName2} is visible, has disabled Share icon");
			* Log.ExpectedResult($"Activity log for the policy doesn't have any records with {documentName1}");
	* Method: UserFromNonOwnerOfDocumentCompanyInSubmissionChainSeesSharedDocumentAndDoesNotSeePrivate
		* TestCaseLink: "ShPr_0002: https://docs.google.com/spreadsheets/d/1mHHonW3ITyfeY-mnTeKq9P-gcw-Jyv52L90zX1HpSkw/edit#gid=1550464163&range=20:25"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as a market user, open the RFQ, go to Docs tab");
			* Log.ExpectedResult($"{documentName1}, {documentName2} are visible for the market user, Share icon is visible and disabled for both");
			* Log.ExpectedResult("Activity log for the RFQ has 2 records for each document (Document uploaded, Document changed)");
			* Log.Step("Log in as the agent, open the RFQ, go to Docs tab");
			* Log.Step($"Make {documentName1} private");
			* Log.ExpectedResult($"{documentName1} and {documentName2} are visible for the agent user. {documentName1} has enabled Private icon");
			* Log.ExpectedResult($"Activity log doesn't have additional records for {documentName1}");
			* Log.Step("Log in as a market user, open the RFQ, go to Docs tab");
			* Log.ExpectedResult($"{documentName1} is not visible for the market user. {documentName2} is visible, has disabled Share icon");
			* Log.ExpectedResult($"Activity log for the RFQ doesn't have any records with {documentName1}");
* File: ShareLoginChange.cs
	* Method: TwoUserEditEloginOnQaPage
		* TestCaseLink: "EL_01: https://docs.google.com/spreadsheets/d/1IgqQU0CeKbSAgp6TvzAxeXVE8ca0Qs_-nKWZ8Ho0kTw/edit#gid=0&range=A2:A18"
		* Categories: [UNDEFINED]
			* Log.Step("Login on main site as Appulate,Inc user and clear market login");
			* Log.Step("Open the RFQ, select market and open options dialog");
			* Log.Step("Set login type as MyLogin, stay options dialog opened");
			* Log.Step("Login on main site as another user Appulate,Inc and clear market logins");
			* Log.Step("Open the RFQ, select market and open options dialog");
			* Log.Step("Set login type as SharedLogin and save");
			* Log.Step("Return to the Appulate,Inc user, save submission options");
			* Log.Step("Reopen options dialog");
			* Log.ExpectedResult("MyLogin credentials are saved");
			* Log.ExpectedResult("SharedLogin credentials are empty");
* File: SmartQnATests.cs
	* Method: CheckingAnswerSynchronizationBetweenSmartQnAAndQuestionnaire
		* TestCaseLink: "SQnA-1: https://docs.google.com/spreadsheets/d/1Z179YWIIg0c4sDdytvngmbb-IBx_UyJ-hWPSChQzIwM/edit#gid=0&range=A2:A4"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency user, create an insured and a GL RFQ");
			* Log.Step($"Select '{smartQnAMarket}' market on Markets Selector");
			* Log.Step("Click disabled Submit button and get Smart QnA dialog");
			* Log.ExpectedResult("There are two tabs on SmartQnA dialog. One tab for each submarket");
			* Log.Step("Fill questionnaire using Smart QnA dialog");
			* Log.Step("Upload MVR and close dialog");
			* Log.ExpectedResult("Check that previously filled on Smart QnA dialog questions are filled as expected on the main questionnaire");
			* Log.ExpectedResult("Open Docs tab and make sure that recently uploaded MVR document is displayed there");
* File: SourceAgency.cs
	* Method: AssignSourceAgencyTest
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
			* Log.Step("Log in as a market user, create a WC RFQ and assign a Source Agency");
			* Log.Step("Log in as the agency, open 'All Insured' grid and find assigned Insured");
	* Method: AttachmentsNotSelectedByDefaultWhenEmailSendsToSourceAgencyTest
		* TestCaseLink: "ESA-1 - https://docs.google.com/spreadsheets/d/1KcPSyRXBuECQpNHX1sOB5YAekM59NvnJFOwuAYWDolA/edit#gid=6223435&range=A2:A4"
		* Categories: [UNDEFINED]
			* Log.Step("Create a WC RFQ, assign a Source agency and a producer");
			* Log.Step("Upload a couple of documents to Docs tab");
			* Log.Step("Click 'Send email' button next to Source agency's producer and check attachments");
	* Method: ChangeSourceAgencyInMarketTest
		* TestCaseLink: "SA-010: https://docs.google.com/spreadsheets/d/1-0qOPd7Or40HXHibIrXoMYiqw7RpoRIi1jqdnfT_mFs/edit#gid=0&range=A26:A28"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as a market user, Create insured and quote");
			* Log.Step("Assign agency and producer/csr");
			* Log.Step("Create another quote for insured");
			* Log.Step("Select another agency and producer/csr");
			* Log.Step("Open first quote");
	* Method: ChangingProducerCsrOnAgencySideTest
		* TestCaseLink: "SA-008: https://docs.google.com/spreadsheets/d/1-0qOPd7Or40HXHibIrXoMYiqw7RpoRIi1jqdnfT_mFs/edit#gid=0&range=A18:A21 and " +
		                                  "SA-009: https://docs.google.com/spreadsheets/d/1-0qOPd7Or40HXHibIrXoMYiqw7RpoRIi1jqdnfT_mFs/edit#gid=0&range=A22:A25"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as a market user, Create insured and quote");
			* Log.Step("Assign agency and producer/csr");
			* Log.Step("Login as admin of agency and open quote");
			* Log.Step("Change producer/csr");
			* Log.Step("Login as market user and open quote");
			* Log.Step("Change producer/csr");
			* Log.Step("Login as admin of agency and open quote");
	* Method: CommunicationBoxButtonsAndTooltipsChecksOnAgencySide
		* TestCaseLink: "TT-1: https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=1669380484&range=A2"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency user and create a WC RFQ");
			* Log.ExpectedResult("Check that Main Contact filled value is 'No Main Contact' and 'Send Questionnaire to complete' button is displayed");
			* Log.Step("Add a contact.Specify the first and last names only");
			* Log.ExpectedResult("Check contact's First and Last names, buttons' tooltips, 'Edit' and 'Send email' buttons are displayed");
			* Log.Step("Add an email to the main contact");
			* Log.ExpectedResult("Check 'Send Email' button's tooltip");
	* Method: CommunicationBoxButtonsAndTooltipsChecksOnMarketSide
		* TestCaseLink: "TT-2: https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=1669380484&range=A13"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as a market user and create a WC RFQ");
			* Log.ExpectedResult("Check that Agency/Producer/CSR filled values are 'Not Selected' and 'Send Questionnaire to complete' button is displayed");
			* Log.Step("Select a source agency, producer and csr");
			* Log.ExpectedResult("Check that agency, producer and csr chosen values are displayed. 'Send email' buttons next to contacts are also displayed");
			* Log.Step("Assign the RFQ to a market viewer");
			* Log.Step("Log in as a market viewer");
			* Log.ExpectedResult("Check that 'Send questionnaire to complete' button is disabled");
	* Method: DeleteInsuredInLineOfAssigningTest
		* TestCaseLink: "SA-018: https://docs.google.com/spreadsheets/d/1-0qOPd7Or40HXHibIrXoMYiqw7RpoRIi1jqdnfT_mFs/edit#gid=0&range=A52:A56"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as a market user, Create insured and quote");
			* Log.Step($"Assign '{secondMarket}' market and producer/csr");
			* Log.Step($"Login as '{secondMarket}' market user and open quote");
			* Log.Step("Assign agency and producer/csr");
			* Log.Step($"Delete Insured as User of '{secondMarket}'");
			* Log.Step($"Login as user of {Markets.SourceAgencyTestMarket.Name} and open quote");
			* Log.Step($"Login as user of {_agency.Name} and open quote");
	* Method: DeleteInsuredOnAgencySideTest
		* TestCaseLink: "SA-013: https://docs.google.com/spreadsheets/d/1-0qOPd7Or40HXHibIrXoMYiqw7RpoRIi1jqdnfT_mFs/edit#gid=0&range=A35:A37"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as a market user, Create insured and quote");
			* Log.Step("Assign agency and producer/csr");
			* Log.Step("Login as agent and delete insured");
			* Log.Step("Login as market user, open quote");
	* Method: DisabledAgencyIsInListOfAvailableAgenciesTest
		* TestCaseLink: "SA-006: https://docs.google.com/spreadsheets/d/1-0qOPd7Or40HXHibIrXoMYiqw7RpoRIi1jqdnfT_mFs/edit#gid=0&range=A12:A14"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as a market user, create a WC RFQ, Assign agency and producer");
			* Log.Step("Login to admin site and disable agency");
			* Log.Step("Login as market user, open quote");
	* Method: DisabledUsersAreInListOfAvailableProducersTest
		* TestCaseLink: "SA-007: https://docs.google.com/spreadsheets/d/1-0qOPd7Or40HXHibIrXoMYiqw7RpoRIi1jqdnfT_mFs/edit#gid=0&range=A15:A17"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as a market user, create a WC RFQ, Assign agency and producer");
			* Log.Step("Login as admin of agency and make assigned  user inactive");
			* Log.Step("Login as market user, open quote");
	* Method: MarketChangeAgencyForInsuredTest
		* TestCaseLink: "SA-001: https://docs.google.com/spreadsheets/d/1-0qOPd7Or40HXHibIrXoMYiqw7RpoRIi1jqdnfT_mFs/edit#gid=0&range=A2:A3 and " +
		                                  "SA-017: https://docs.google.com/spreadsheets/d/1-0qOPd7Or40HXHibIrXoMYiqw7RpoRIi1jqdnfT_mFs/edit#gid=0&range=A48:A51"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as a market user, create a WC RFQ and assign a Source Agency");
			* Log.Step("Change tab of record");
			* Log.Step("Login as agent and open quote");
			* Log.Step("Login as Market user");
			* Log.Step("Login as Market user");
	* Method: MarketUserCantSeeNotAssignedQuoteTest
		* TestCaseLink: "SA-016: https://docs.google.com/spreadsheets/d/1-0qOPd7Or40HXHibIrXoMYiqw7RpoRIi1jqdnfT_mFs/edit#gid=0&range=A45:A47"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as a market user, Create insured and quote");
			* Log.Step("Assign agency and producer/csr");
			* Log.Step("Login as agent and open quote");
			* Log.Step("Create new quote for insured as agent");
			* Log.Step("Login as market user and open insured");
	* Method: SourceAgencyDropdownDisplayedOnInsuredSummaryAfterRfqCreation
		* TestCaseLink: "SA-020: https://docs.google.com/spreadsheets/d/1-0qOPd7Or40HXHibIrXoMYiqw7RpoRIi1jqdnfT_mFs/edit#gid=0&range=A61:A64"
		* Categories: [UNDEFINED]
			* Log.Step("Create insured");
			* Log.ExpectedResult("Check absence of Source agency dropdown on Insured's summary page");
			* Log.Step("Open policy options page");
			* Log.ExpectedResult("Check Source agency dropdown on policy options page");
			* Log.Step("Click Cancel button on policy options page");
			* Log.ExpectedResult("Check absence of Source agency dropdown on Insured's summary page");
			* Log.ExpectedResult("Reopen policy options page, select IL, reopen Insured's summary page");
			* Log.ExpectedResult("Check Source agency dropdown on Insured's summary page");
	* Method: SourceAgencyProducerAndCsrAreReadonlyOnMarketSideAfterSubmitAndProducerAndScrAreEditableForAnotherRfqTest
		* TestCaseLink: "SA-014: https://docs.google.com/spreadsheets/d/1-0qOPd7Or40HXHibIrXoMYiqw7RpoRIi1jqdnfT_mFs/edit#gid=0&range=A38:A40 and" +
		                                  "SA-019: https://docs.google.com/spreadsheets/d/1-0qOPd7Or40HXHibIrXoMYiqw7RpoRIi1jqdnfT_mFs/edit#gid=0&range=A57:A60"
		* Categories: [UNDEFINED]
			* Log.Step("Login as user of agency, Create insured and quote");
			* Log.Step("Submit to market");
			* Log.Step("Login as market user and open received quote");
			* Log.ExpectedResult("Source agency is filled with Agency's name and readonly");
			* Log.ExpectedResult("Producer is filled with agent's name and readonly");
			* Log.ExpectedResult("CSR is not selected and readonly");
			* Log.Step("Creating GL RFQ for the same insured");
			* Log.ExpectedResult("Source agency is filled with Agency's name and readonly");
			* Log.ExpectedResult("Producer is not selected and editable");
			* Log.ExpectedResult("CSR is not selected and readonly");
	* Method: SubmitAssignedQuoteToAnotherMarketTest
		* TestCaseLink: "SA-015: https://docs.google.com/spreadsheets/d/1-0qOPd7Or40HXHibIrXoMYiqw7RpoRIi1jqdnfT_mFs/edit#gid=0&range=A41:A44"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as a market user, Create insured and quote");
			* Log.Step("Assign agency and producer/csr");
			* Log.Step("Login as agent and open quote");
			* Log.Step("Submit to Market#2");
			* Log.Step("Login as User of Market#1 and open quote");
			* Log.Step("Login as User of Market#2 and open quote");
* File: StateFundFirstLogicTests.cs
	* Method: StateFundFirstLogicTest
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: StatusesCalculationLogicTests.cs
	* Method: AgencySubmitsToCarrierAndGetsAutogeneratedQuoteDocumentThenCarrierBindsRfqTest
		* TestCaseLink: "SCL_7 - https://docs.google.com/spreadsheets/d/1_t9MLTsQsW8kwo9s3tY9xxvWko95sbfUvsYnFGVJ1dw/edit#gid=0&range=A97:L97"
		* Categories: Categories.SentDocumentForSignCategory, Categories.ExcludingCategoryOnlyTestingSites
			* Log.Step("Agency creates a WC RFQ");
			* Log.Step("Agency selects a Carrier");
			* Log.Step($"Fill out the questionnaire to get a 'green A' indicator for the Carrier '{_.CarrierN(1).Name}'");
			* Log.Step("Agency submits to the Carrier and gets autogenerated quote document");
			* Log.Step("Agency sets 'Accepted by Insured' status for the quote document");
	* Method: AgencySubmitsToCarrierThroughMgaThenCarrierUploadsQuoteDocumentAndInsuredAcceptsItTest
		* TestCaseLink: "SCL_1 - https://docs.google.com/spreadsheets/d/1_t9MLTsQsW8kwo9s3tY9xxvWko95sbfUvsYnFGVJ1dw/edit#gid=0&range=A3:L3"
		* Categories: Categories.PolicyCategory, Categories.SmokeTestsCategory, Categories.Notification, Categories.ExcludingCategoryOnlyTestingSites, Categories.SentDocumentForSignCategory
			* Log.Step("Agency creates an RFQ, selects a market and submarket, and submits to a market");
			* Log.Step("MGA assigns an underwriter and submits to the Carrier");
			* Log.Step("Carrier assigns an underwriter, uploads a quote document and releases it");
			* Log.Step("MGA releases a quote document to the Agency");
			* Log.Step("Agency sends the quote document to the insured by email");
			* Log.Step("Agency sets the 'Accepted by Insured' status to the quote document");
	* Method: AgencySubmitsToCarrierThroughMgaThenCarrierUploadsSeveralQuoteDocumentsAndEachOneGetsDifferentStatusesTestPart1
		* TestCaseLink: "SCL_2_part1 - https://docs.google.com/spreadsheets/d/1_t9MLTsQsW8kwo9s3tY9xxvWko95sbfUvsYnFGVJ1dw/edit#gid=0&range=A33:L33"
		* Categories: [UNDEFINED]
			* Log.Step("Agency creates an RFQ, selects a market and a submarket");
			* Log.Step("Agency submits to the MGA");
			* Log.Step("MGA assigns an Underwriter and submits to a Carrier");
			* Log.Step("Carrier uploads the first quote document and releases it to the MGA");
			* Log.Step("MGA releases the quote document to the Agency");
	* Method: AgencySubmitsToCarrierThroughMgaThenCarrierUploadsSeveralQuoteDocumentsAndEachOneGetsDifferentStatusTestPart2
		* TestCaseLink: "SCL_2_part2 - https://docs.google.com/spreadsheets/d/1_t9MLTsQsW8kwo9s3tY9xxvWko95sbfUvsYnFGVJ1dw/edit#gid=0&range=A33:L33"
		* Categories: [UNDEFINED]
			* Log.Step("Agency creates an RFQ, selects a market and a submarket");
			* Log.Step("Agency submits to the MGA");
			* Log.Step("MGA assigns an Underwriter and submits to a Carrier");
			* Log.Step("Carrier uploads the first quote document and releases it to the MGA");
			* Log.Step("MGA releases the quote document to the Agency");
			* Log.Step("Agency sends the quote document to the insured by email");
			* Log.Step("Agency sets 'Declined by Insured' status to the quote document on behalf of insured");
			* Log.Step("Carrier uploads the second quote document and releases it to the MGA");
			* Log.Step("MGA releases the second quote document to the Agency");
	* Method: AgencySubmitsToCarrierThroughMgaThenCarrierUploadsSeveralQuoteDocumentsAndEachOneGetsDifferentStatusTestPart3
		* TestCaseLink: "SCL_2_part3 - https://docs.google.com/spreadsheets/d/1_t9MLTsQsW8kwo9s3tY9xxvWko95sbfUvsYnFGVJ1dw/edit#gid=0&range=A33:L33"
		* Categories: [UNDEFINED]
			* Log.Step("Agency creates an RFQ, selects a market and a submarket");
			* Log.Step("Agency submits to the MGA");
			* Log.Step("MGA assigns an Underwriter and submits to a Carrier");
			* Log.Step("Carrier uploads the first quote document and releases it to the MGA");
			* Log.Step("MGA releases the quote document to the Agency");
			* Log.Step("Agency sends the quote document to the insured by email");
			* Log.Step("Agency sets 'Declined by Insured' status to the quote document on behalf of insured");
			* Log.Step("Carrier uploads the second quote document and releases it to the MGA");
			* Log.Step("MGA releases the second quote document to the Agency");
			* Log.Step("Agency sets 'Declined by Producer' status to the second quote document");
			* Log.Step("Carrier uploads the third quote document and releases it to the MGA");
			* Log.Step("MGA releases the third quote document to the Agency");
	* Method: AgencySubmitsToCarrierThroughMgaThenCarrierUploadsSeveralQuoteDocumentsAndEachOneGetsDifferentStatusTestPart4
		* TestCaseLink: "SCL_2_part4 - https://docs.google.com/spreadsheets/d/1_t9MLTsQsW8kwo9s3tY9xxvWko95sbfUvsYnFGVJ1dw/edit#gid=0&range=A33:L33"
		* Categories: Categories.SentDocumentForSignCategory, Categories.ExcludingCategoryOnlyTestingSites
			* Log.Step("Agency creates an RFQ, selects a market and a submarket");
			* Log.Step("Agency submits to the MGA");
			* Log.Step("MGA assigns an Underwriter and submits to a Carrier");
			* Log.Step("Carrier uploads the first quote document and releases it to the MGA");
			* Log.Step("MGA releases the quote document to the Agency");
			* Log.Step("Agency sends the quote document to the insured by email");
			* Log.Step("Agency sets 'Declined by Insured' status to the quote document on behalf of insured");
			* Log.Step("Carrier uploads the second quote document and releases it to the MGA");
			* Log.Step("MGA releases the second quote document to the Agency");
			* Log.Step("Agency sets 'Declined by Producer' status to the second quote document");
			* Log.Step("Carrier uploads the third quote document and releases it to the MGA");
			* Log.Step("MGA releases the third quote document to the Agency");
			* Log.Step("Agency sends the third quote document to the insured by email");
			* Log.Step("Agency sets the 'Accepted by Insured' status to the third quote document");
	* Method: AgencySubmitsToMgaThenMgaSubmitsToTwoCarriersAndSetsDeclinedByMarketStatusesForEachOneTest
		* TestCaseLink: "SCL_8 - https://docs.google.com/spreadsheets/d/1_t9MLTsQsW8kwo9s3tY9xxvWko95sbfUvsYnFGVJ1dw/edit#gid=0&range=A107:L107"
		* Categories: [UNDEFINED]
			* Log.Step("Agency creates a WC RFQ, then selects market and its submarkets on MS");
			* Log.Step("Agency submits to the MGA");
			* Log.Step("MGA submits to both Carriers");
			* Log.Step("MGA sets 'Declined by Market (No appetite)' status to the Carrier");
			* Log.Step("MGA sets 'Declined by Market (Reserved)' status to the Carrier2");
	* Method: AgencySubmitsToThreeCarriersAndThenAgencySetsDifferentStatusesForMarketsTest
		* TestCaseLink: "SCL_4 - https://docs.google.com/spreadsheets/d/1_t9MLTsQsW8kwo9s3tY9xxvWko95sbfUvsYnFGVJ1dw/edit#gid=0&range=A67:L67"
		* Categories: [UNDEFINED]
			* Log.Step("Agency creates a WC RFQ");
			* Log.Step("Agency selects a weblink Carrier and submits to it");
			* Log.Step("Agency selects an eSubmission Carrier and submits to it");
			* Log.Step("Agency selects an email Carrier and submits to it");
			* Log.Step("Agency sets the 'Declined by market (No appetite)' status for the weblink Carrier");
			* Log.Step("Agency uploads a quote document under the eSubmission Carrier");
			* Log.Step("Agency sets 'Declined by Insured' status for the eSubmission Carrier on behalf of insured");
			* Log.Step("Agency uploads a quote document under the Email Carrier");
			* Log.Step($"Agent performs '{MarketsSelectorAction.MarkAsBound.GetDescription()}' on behalf of the email Carrier");
	* Method: DirectSubmitToMgaSubsequentSubmitToCarrierAndDeclinationOnMgaSideTest
		* TestCaseLink: "SCL_3 - https://docs.google.com/spreadsheets/d/1_t9MLTsQsW8kwo9s3tY9xxvWko95sbfUvsYnFGVJ1dw/edit#gid=0&range=A57:L57"
		* Categories: [UNDEFINED]
			* Log.Step("Agency creates an RFQ, selects a market and submarket");
			* Log.Step("Agency unassigns a producer from the RFQ");
			* Log.Step("Agency assigns another producer to the RFQ");
			* Log.Step("Agency submits to MGA directly to an underwriter");
			* Log.Step("MGA submits to a Carrier");
			* Log.Step("MGA sets Declined by Market (Reserved) for own market");
	* Method: MgaAssignsAgencyAndSubmitsToCarrierThenMgaDeclinesQuoteDocumentTest
		* TestCaseLink: "SCL_5 - https://docs.google.com/spreadsheets/d/1_t9MLTsQsW8kwo9s3tY9xxvWko95sbfUvsYnFGVJ1dw/edit#gid=0&range=A79:L79"
		* Categories: [UNDEFINED]
			* Log.Step("MGA's user creates an RFQ");
			* Log.Step("MGA's user assigns an agency and a producer to the RFQ");
			* Log.Step("MGA's user submits to a Carrier");
			* Log.Step("MGA's user uploads a Quote document under Carrier");
			* Log.Step("MGA's user releases quote document to the agency");
			* Log.Step("MGA's user set 'Declined by Insured' status for the quote document");
	* Method: PolicyCancellationOnAgencySideTest
		* TestCaseLink: "SCL_1.2 - https://docs.google.com/spreadsheets/d/1_t9MLTsQsW8kwo9s3tY9xxvWko95sbfUvsYnFGVJ1dw/edit#gid=0&range=A28:L28"
		* Categories: Categories.PolicyCategory
			* Log.Step("Create an active Policy");
			* Log.Step("Agency cancels policy");
	* Method: QuoteDocumentIsAutoreleasedFromCarrierToAgencyThroughMgaWhenCarrierSetsAcceptedByInsuredStatusTest
		* TestCaseLink: "SCL_6 - https://docs.google.com/spreadsheets/d/1_t9MLTsQsW8kwo9s3tY9xxvWko95sbfUvsYnFGVJ1dw/edit#gid=0&range=A88:L88"
		* Categories: [UNDEFINED]
			* Log.Step("Agency creates an RFQ, selects an MGA and a Carrier");
			* Log.Step("Agency submits to MGA");
			* Log.Step("MGA submits to Carrier");
			* Log.Step("Carrier uploads a QD");
			* Log.Step("Carrier sets 'Accepted by Insured' status to the QD");
			* Log.Step("Carrier binds the RFQ");
	* Method: RfqCancellationOnAgencySideTest
		* TestCaseLink: "SCL_1.1 - https://docs.google.com/spreadsheets/d/1_t9MLTsQsW8kwo9s3tY9xxvWko95sbfUvsYnFGVJ1dw/edit#gid=0&range=A19:L19"
		* Categories: [UNDEFINED]
			* Log.Step("Agency creates a new RFQ and selects an email market on Markets selector");
			* Log.Step("Agency submits to the email market");
			* Log.Step("Agency sets the 'Declined by Market (Other)' status for the Carrier");
			* Log.Step("Agency clicks 'Restore' option in the market's status dropdown");
			* Log.Step("Agency cancels the RFQ using options tab");
	* Method: TrupanionPetRfqHasDeclinedIndicatorWithYesterdayEffectiveDateAndNoExpirationDate
		* TestCaseLink: "EffPet_01 - https://docs.google.com/spreadsheets/d/1GAie3oY8xtyfimP6voADOw7zjhNPrbGK7sORzs_G9pM/edit#gid=292832170&range=2:5"
		* Categories: Categories.Clients.External.TrupanionPet
			* Log.Step("Create new insured with 'Personal' insurance type.");
			* Log.ExpectedResult("Insurance line is empty. Effective Date = today + 3 month. Expiration Date = Effective Date + 1 year.");
			* Log.Step("Select 'Pet Insurance' insurance line.");
			* Log.ExpectedResult("Insurance line is 'Pet Insurance'. Effective Date = today. Expiration Date is absent.");
			* Log.Step("Click 'Continue'.");
			* Log.Step("On Q&A tab check 'Trupanion Testing' market.");
			* Log.ExpectedResult("Effective Date = today, Expiration Date is absent on the RFQ.");
			* Log.Step("Change Effective Date to yesterday. Save changes.");
			* Log.ExpectedResult("Market Admission indicator on market selector is Declined (D).");
* File: SubmarketBehaviourTests.cs
	* Method: UnselectedSubmarketsDontDisplayLimitsAndDeductibleTest
		* TestCaseLink: "LM_1 - https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=1961147605&range=A2"
		* Categories: [UNDEFINED]
			* Log.Step("Create an insured and a GL RFQ");
			* Log.Step("Select a market and a submarket");
			* Log.Step("Uncheck a submarket and make sure that the submarket name is not clickable and limits and deductible aren't displayed");
* File: SubmarketsRateFilings.cs
	* Method: IcwMarketNotContainsRateFillingsFromSubmarkets
		* TestCaseLink: [UNDEFINED]
		* Categories: Categories.RateFillingsCategory
	* Method: MarketContainsRateFillingsFromSubmarkets
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: VisibleSubmarketRateFillings
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: SubmissionErrorMessages.cs
	* Method: EmailAddressIsRequiredOnEmailEditorDuringEmailSubmission
		* TestCaseLink: "SEM-06: https://docs.google.com/spreadsheets/d/19aVzFb2R6jmSaUtvfB6g-WcSxJo8vPcDUsMM0lTjjEc/edit#gid=0&range=A7"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency user, create an insured and a WC RFQ");
			* Log.Step($"Select '{emailMarket.Name}' market on Markets Selector");
			* Log.Step("Click Submit button to open Email editor dialog");
			* Log.Step("Click Send button on the Email Editor dialog");
			* Log.ExpectedResult("An email isn't sent. Error ui message appears");
	* Method: LoginAndPasswordAreRequiredForEsubmissionAndWeblinkSubmissionOnMarketsSelector
		* TestCaseLink: "SEM-04: https://docs.google.com/spreadsheets/d/19aVzFb2R6jmSaUtvfB6g-WcSxJo8vPcDUsMM0lTjjEc/edit#gid=0&range=A5"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency user, create an insured and a WC RFQ");
			* Log.Step($"Select '{eSubmissionMarket.Name}' and '{weblinkMarket.Name}' markets on Markets Selector");
	* Method: OcrLicenseErrorMessageAppearsDuringEsubmissionIfBothCompaniesHaveNoOcrLicense
		* TestCaseLink: "SEM-07: https://docs.google.com/spreadsheets/d/19aVzFb2R6jmSaUtvfB6g-WcSxJo8vPcDUsMM0lTjjEc/edit#gid=0&range=A8"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency user and open previously uplinked OCR RFQ");
			* Log.Step($"Select '{eSubmissionNoOcrMarket.Name}' market on Markets Selector");
			* Log.Step($"Click Submit button next to the '{eSubmissionNoOcrMarket.Name}' market");
			* Log.ExpectedResult("An error dialog appears");
			* Log.Step($"Follow the '{linkText}' link on the error message to open Contact us page");
* File: SubmissionWorkflow.cs
	* Method: AgouraSubmissionWorkflowTest
		* TestCaseLink: [UNDEFINED]
		* Categories: Categories.PolicyCategory, Categories.SmokeTestsCategory
			* Log.Step("Create rfq AND select market");
			* Log.Step("Fill questionnaire");
			* Log.Step("Submit rfq");
			* Log.Step("Upload Quote");
			* Log.Step($"'{MarketsSelectorAction.MarkAsBound.GetDescription()}' Quote");
	* Method: BeaconAviationRequestToBindWorkflow
		* TestCaseLink: "BA_BP_001: https://docs.google.com/spreadsheets/d/1sUT0qFFZxZ_QDiZG4LyTt9GE2qyeRAF33Kyz2cKFVAA/edit#gid=0&range=A2:A15"
		* Categories: Categories.SentDocumentForSignCategory
			* Log.Step("Create rfq AND select market");
			* Log.Step("Fill questionnaire to green indicator");
			* Log.Step("Submit rfq");
			* Log.Step("Release quote");
			* Log.Step("Fill in missing questions on questionnaire AND click 'Request to bind' button for quote document");
			* Log.ExpectedResult($"'Open Signing Tool' button is enabled({acordName}) AND 'Proceed' button is disabled");
			* Log.Step("Choose applicant with producer AND sign acord");
			* Log.ExpectedResult("Acord is signed");
			* Log.Step("Opened 'Requset to Bind' window");
			* Log.ExpectedResult($"{acordName} is signed AND 'Proceed' button is enabled");
			* Log.ExpectedResult("Market and quote document status is 'Requested to Bind' AND 'Cancel Binding' action for the quote document is available");
	* Method: BindBlocking
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
			* Log.Step("Create insured with rfq AND select markets");
			* Log.Step("Fill questionnaire");
			* Log.Step($"Submit rfq to the '{market}' market");
			* Log.Step("Upload quote");
			* Log.Step($"Click rtb button for '{DocumentNamesAggregator.TestingQuote}' doc");
			* Log.ExpectedResult("There is expected message");
			* Log.Step("Fill question");
			* Log.ExpectedResult("Dialog is opened");
	* Method: EncinoWorkflowTest
		* TestCaseLink: "MSR_34: https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A39:J39"
		* Categories: Categories.SentDocumentForSignCategory, Categories.PolicyCategory, Categories.SmokeTestsCategory, Categories.ExcludingCategoryOnlyTestingSites
			* Log.Step($"Create RfQ and Select {_.CarrierN(1)}");
			* Log.Step("Fill questionnaire and upload ExMod");
			* Log.Step($"Submit to {_.CarrierN(1)}");
			* Log.Step($"Select {_.CarrierN(2)} and submit");
			* Log.Step($"Upload and release quote under {_.CarrierN(2)} user");
			* Log.Step($"Change {_.CarrierN(2)} quote status");
			* Log.ExpectedResult("Markets have different statuses. Record status is Quote Accepted By Insured");
	* Method: GenericWorkflowWithoutSubmarketTest
		* TestCaseLink: "MSR_35 - https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=0&range=A40:J40"
		* Categories: Categories.PolicyCategory, Categories.PopupTooltipsCategory, Categories.SmokeTestsCategory
			* Log.Step("Create RFQ and select market");
			* Log.Step("Submit RFQ");
			* Log.Step("Assign underwriter");
			* Log.Step("Upload quote");
			* Log.Step("Release quote");
			* Log.ExpectedResult("Quote, market and record have status 'Quote Released'");
			* Log.Step("Accept quote by insured");
	* Method: HullCompanySigningAutoGeneretedQuoteWorkflowTest
		* TestCaseLink: "HullGenQ-SignQ001: https://docs.google.com/spreadsheets/d/1c-n85yM4eX0FTdhkAoQDqgZzItawEBh_CXpyGeth2is/edit#gid=1856670990&range=A2"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites, Categories.Clients.External.HullAndCompanyPl
			* Log.Step("Create RFQ PL-line on Agency side");
			* Log.Step($"Select '{_.Mga.Name}', '{_.CarrierN(1).Name}' submarket on Markets Selector");
			* Log.Step("Fill questionnaire to 'GreenA' admission indicator");
			* Log.Step("Perform Appulate submit to the MGA");
			* Log.ExpectedResult("Check Record status, Markets statuses, and auto-generated Quote name");
	* Method: JohnsonAndJohnsonWorkflow
		* TestCaseLink: "JJ_1: https://docs.google.com/spreadsheets/d/1DF23UHbifkLjs0Z-eFgpyLodV0ouUtqZwz9zvimL8EQ/edit#gid=0&range=2:35"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites, Categories.Clients.External.JohnsonAndJohnsonFlood
			* Log.Step("Create RFQ and Select market 'Johnson and Johnson'. Fill in questionnaire to red indicator");
			* Log.ExpectedResult("Admission indicator is D");
			* Log.Step("Fill in questionnaire and limits. Submit RFQ");
			* Log.ExpectedResult("Statuses are 'Quote Prepared'. Indicator is Green A");
			* Log.Step("Click 'Request quote'");
			* Log.ExpectedResult("6 quotes are displayed. All statuses are 'Quote Prepared'");
			* Log.ExpectedResult("Statuses on market side are 'Quote Released'");
			* Log.Step("Generate quote on market side");
			* Log.ExpectedResult("Status for new generated quote is 'Quote Prepared', for already existed is 'Quote Released'. 9 quotes are displayed");
	* Method: MarketsUserCantPerformBindQuoteThatAlreadyBindByAnotherMarket
		* TestCaseLink: "UMBB_001: https://docs.google.com/spreadsheets/d/1UJ15FxjWUXqdn_qvjn-GIabcRO4E5OgBOE6xPkeySZw/edit#gid=1374105318&range=A3:A9"
		* Categories: Categories.Bind
			* Log.Step("Create insured with rfq AND select markets");
			* Log.Step($"Submit to '{carrierMarketWithAppulateSubmit}' market");
			* Log.Step($"Mark '{carrierMarketWithEmailSubmit}' market as submitted");
			* Log.Step($"Upload quote for '{carrierMarketWithEmailSubmit}' market");
			* Log.Step($"'{MarketsSelectorAction.MarkAsBound.GetDescription()}' quote for '{carrierMarketWithEmailSubmit}' market");
			* Log.Step($"Go to '{carrierMarketWithAppulateSubmit}' market side AND upload a quote for the market");
			* Log.Step($"Press '{MarketsSelectorAction.MarkAsBound.GetDescription()}' button on the quote");
			* Log.ExpectedResult("There is expected message");
	* Method: ScifQaBindWorkflow
		* TestCaseLink: [UNDEFINED]
		* Categories: Categories.ExcludingCategoryOnlyProductionSite, Categories.PolicyCategory
			* Log.Step("Create application and select market with Locations collection prefill");
			* Log.Step("Select test market with questionnaire prefill");
			* Log.ExpectedResult("Check that prod market is ready to submit with green A");
			* Log.Step("Make e-submit to test market");
			* Log.Step($"Upload quote and '{MarketsSelectorAction.MarkAsBound.GetDescription()}' it");
			* Log.ExpectedResult("RFQ has successfully become policy");
	* Method: VoltaRequestToBindWorkflow
		* TestCaseLink: "Case Vo-0: https://docs.google.com/spreadsheets/d/1sl-_xVyqVuNJBvqlQSL7rUFwN_G-PeBm9-GlHQCjBZM/edit#gid=2033986656&range=A3:A11"
		* Categories: Categories.SentDocumentForSignCategory, Categories.ExcludingCategoryOnlyTestingSites, Categories.Forms, Categories.VoltaTopaCategory
			* Log.Step($"Create RFQ, add {_.Mga} on Markets Selector and tick only {_.CarrierN(1)} as submarket if possible");
			* Log.Step("Fill in questionnaire");
			* Log.Step("Submit");
			* Log.Step("Fill in questionnaire");
			* Log.Step($"Upload loss run for {_.CarrierN(1)}");
			* Log.ExpectedResult("Record status is Quote Prepared");
	* Method: WeblinkSubmissionWorkflowTest
		* TestCaseLink: [UNDEFINED]
		* Categories: Categories.PolicyCategory, Categories.SmokeTestsCategory
			* Log.Step("Create RFQ and Select weblink market");
			* Log.Step("Submit RFQ to Weblink market");
			* Log.Step("Upload Quote");
			* Log.Step($"'{MarketsSelectorAction.MarkAsBound.GetDescription()}'quote and check policy status");
* File: SubtabsRedirect.cs
	* Method: CheckRedirect
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: SupplementalWithoutHighlightsTests.cs
	* Method: SupplementalSideWithoutAdmissionHighlightsTests
		* TestCaseLink: "SCH-001 : https://docs.google.com/spreadsheets/d/140fXn5Ke6pqYHoYTo2__gded1NYg0XsbQsHY6tGGrOA/edit#gid=2040477632"
		* Categories: [UNDEFINED]
			* Log.Step("Create RFQ GL - line");
			* Log.Step($"Select market {market.Name} on Markets Selector");
			* Log.Step($"Fill question: {questionTitleFist} on questionnaire");
			* Log.Step($"Click on indicator tooltip question {questionTitleSecond} => go to highlight question on questionnaire");
			* Log.Step($"Open edit form page for {supplementalName} document");
* File: SwitchingOfSections.cs
	* Method: CheckQuestionnaireAfterSwitchingToFormEditor
		* TestCaseLink: "https://docs.google.com/spreadsheets/d/1JaRs6EgNBftLh5rvSnNJijWmGUAS-8RVWMQvYgXK7so/edit#gid=410507212&range=A2:A7"
		* Categories: [UNDEFINED]
	* Method: CheckSectionsStateDroppingAfterDeselectingMarket
		* TestCaseLink: "SS-1: https://docs.google.com/spreadsheets/d/1JaRs6EgNBftLh5rvSnNJijWmGUAS-8RVWMQvYgXK7so/edit#gid=410507212&range=A8:N10"
		* Categories: [UNDEFINED]
			* Log.Step($"Creating WC RFQ, selecting {marketEncino.Name} and opening Policy section");
			* Log.ExpectedResult($"{marketEncino.Name} is selected on MS");
			* Log.ExpectedResult("Policy section and Insured subsection are opened");
			* Log.Step($"Deselecting {marketEncino.Name} on MS");
			* Log.ExpectedResult($"{marketEncino.Name} is deselected on MS");
			* Log.ExpectedResult("Subject section is opened");
	* Method: CheckSectionStateSavingAfterEditingLossRunsTab
		* TestCaseLink: "SS-2: https://docs.google.com/spreadsheets/d/1JaRs6EgNBftLh5rvSnNJijWmGUAS-8RVWMQvYgXK7so/edit#gid=410507212&range=A11:N13"
		* Categories: [UNDEFINED]
			* Log.Step("Creating WC RFQ and opening Underwriting section");
			* Log.ExpectedResult("Underwriting section and General Operations subsection are opened");
			* Log.Step($"Opening Loss Runs tab and adding {market.Name} as Carrier for 2018-2019 period");
			* Log.ExpectedResult($"{market.Name} is specified as Carrier for 2018-2019 period");
			* Log.Step("Going back to Q&A tab");
			* Log.ExpectedResult("Underwriting section and General Operations subsection are opened");
* File: SynchronisationOfContactsTest.cs
	* Method: CreateContactInQuestionnaireCopyInsuredAndCheckContact
		* TestCaseLink: "23 - https://docs.google.com/spreadsheets/d/1JaRs6EgNBftLh5rvSnNJijWmGUAS-8RVWMQvYgXK7so/edit#gid=923020371&range=A69:A77"
		* Categories: [UNDEFINED]
	* Method: CreateContactOnFormDialogAndCheckItIsAddedOnContacts
		* TestCaseLink: [UNDEFINED]
		* Categories: Categories.SentDocumentForSignCategory, Categories.ExcludingCategoryOnlyTestingSites
	* Method: CreateContactOnFormEditorAndSetMainContact
		* TestCaseLink: "25 - https://docs.google.com/spreadsheets/d/1JaRs6EgNBftLh5rvSnNJijWmGUAS-8RVWMQvYgXK7so/edit#gid=923020371&range=A83:A84," +
		                                  "26 - https://docs.google.com/spreadsheets/d/1JaRs6EgNBftLh5rvSnNJijWmGUAS-8RVWMQvYgXK7so/edit#gid=923020371&range=A85:A87"
		* Categories: [UNDEFINED]
	* Method: CreateContactOnLossRunsDialogAndCheckItIsAddedOnContacts
		* TestCaseLink: [UNDEFINED]
		* Categories: Categories.LossRunsCategory, Categories.ExcludingCategoryOnlyTestingSites
	* Method: CreateContactOnQuoteDialogAndCheckItIsAddedOnContacts
		* TestCaseLink: "24 - https://docs.google.com/spreadsheets/d/1JaRs6EgNBftLh5rvSnNJijWmGUAS-8RVWMQvYgXK7so/edit#gid=923020371&range=A78:A82"
		* Categories: Categories.SentDocumentForSignCategory, Categories.ExcludingCategoryOnlyTestingSites
	* Method: CreateContactOnSendRequestToCompleteDialogAndCheckItIsAddedOnContacts
		* TestCaseLink: "EE-1, https://docs.google.com/spreadsheets/d/1KcPSyRXBuECQpNHX1sOB5YAekM59NvnJFOwuAYWDolA/edit#gid=448167758&range=A2:A4"
		* Categories: [UNDEFINED]
	* Method: CreateNewMainContactTest
		* TestCaseLink: "MC_1: https://docs.google.com/spreadsheets/d/11XqAJUWu21T_9vjL-KmMcdtcPxyJuWWqmAHK86q6yfQ/edit#gid=0&range=A2:A7"
		* Categories: [UNDEFINED]
			* Log.Step("Login as user of agency, Create insured and quote");
			* Log.ExpectedResult("No Main contact is selected");
			* Log.Step("Adding New Main Contact");
			* Log.ExpectedResult("Created contact is displayed as Main Contact and Edit, Send email buttons are displayed");
	* Method: MainContactAutomaticallyAddedToSqtcLetterTest
		* TestCaseLink: "MC_2: https://docs.google.com/spreadsheets/d/11XqAJUWu21T_9vjL-KmMcdtcPxyJuWWqmAHK86q6yfQ/edit#gid=0&range=A8:A15"
		* Categories: [UNDEFINED]
			* Log.Step("Login as user of agency, Create insured and quote");
			* Log.Step("Opening Contacts tab and adding 2 contacts");
			* Log.Step("Reopening QA tab and selecting second contact");
			* Log.ExpectedResult($"{contact2.FirstName} {contact2.LastName} is selected as Main Contact");
			* Log.Step("Clicking SQTC button and opening email dialog");
			* Log.ExpectedResult($"{contact2.FirstName} {contact2.LastName} is chosen as Recipient in To field");
* File: TooltipLink.cs
	* Method: ErrorMessageForHiddenCollectionsControlsTest
		* TestCaseLink: "AI-21 - https://docs.google.com/spreadsheets/d/140fXn5Ke6pqYHoYTo2__gded1NYg0XsbQsHY6tGGrOA/edit#gid=0&range=A75:A80"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency user, create a GL RFQ and add market on Markets Selector");
			* Log.ExpectedResult("Check the set of active sections in questionnaire");
			* Log.Step("Answer the 'You are applying as:' question");
			* Log.ExpectedResult($"Check the set of active sections in questionnaire after answering on the '{YouAreApplyingAs}' question");
			* Log.Step("Open 'Coverage History' section and answer the '{AnyPriorClaimsLosses}' question");
			* Log.ExpectedResult("make sure that 'Claims and losses' collection is required");
			* Log.Step($"Fill the '{TotalClaimAmount}' question in the '{ClaimsOrLosses}' collection");
			* Log.ExpectedResult($"Make sure that the '{TotalClaimAmount}' isn't required and admission indicator is changed to orange U");
			* Log.Step("Check 'Required unanswered only' filter");
			* Log.ExpectedResult($"Make sure that the'{TotalClaimAmount}' question is hidden");
			* Log.Step($"Hover over the admission indicator and click the '{claimsAndLossesTooltipLinkText}' link");
			* Log.ExpectedResult("Check the text in the popup error message which appears after clicking on a link in admission tooltip");
* File: TrialExpiredWithoutBilling.cs
	* Method: AgencyTryingDownloadMoreThanOneAcordFormsOnFormsTabViaGetAsOnePdfWhenTrialExpired
		* TestCaseLink: "FTEXP_006 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=1508423839&range=A61:A67"
		* Categories: [UNDEFINED]
			* Log.Step("Create insured with rfq");
			* Log.Step("Go to Forms tab");
			* Log.Step("Click 'upgrade to ProducerConnect Premium'");
	* Method: AgencyWithProducerConnectStandardAndExpiredTrialHasRestrictionToAccessAcordFormsFromActivePolicyInterface
		* TestCaseLink: "FTEXP_007 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=1508423839&range=69:77"
		* Categories: [UNDEFINED]
			* Log.Step("Perform submit");
			* Log.Step("Upload quote");
			* Log.Step("Log in as a market user, open the RFQ, mark it as bound");
			* Log.Step("Log in as the agent, click on Quote Docs tab on the left side bar and open Forms collection");
			* Log.ExpectedResult($"There is an information string under Forms collection: '{expectedProducerConnectPremiumMessage}'");
			* Log.Step("Click on the link 'upgrade to ProducerConnect Premium' and click on [Start Trial] button in Dialog box");
	* Method: ResubmitToEmailMarketWhenTrialExpired
		* TestCaseLink: "FTEXP_004 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=1508423839&range=A41:A52"
		* Categories: [UNDEFINED]
	* Method: ResubmitToWeblinkMarketWhenTrialExpired
		* TestCaseLink: "FTEXP_002 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=1508423839&range=A15:A25"
		* Categories: [UNDEFINED]
	* Method: SubmitToEmailMarketWhenTrialExpired
		* TestCaseLink: "FTEXP_003 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=1508423839&range=A27:A39"
		* Categories: [UNDEFINED]
	* Method: SubmitToWeblinkMarketWhenTrialExpired
		* TestCaseLink: "FTEXP_001 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=1508423839&range=A2:A13"
		* Categories: [UNDEFINED]
* File: TrialExtendedNoBilling.cs
	* Method: AvailableResubmitToEmailMarketAfterTrialExtended
		* TestCaseLink: "FTEXT_004 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=1960693214&range=A23:A21"
		* Categories: [UNDEFINED]
	* Method: AvailableResubmitToWeblinkMarketAfterTrialExtended
		* TestCaseLink: "FTEXT_002 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=1960693214&range=A9:A13"
		* Categories: [UNDEFINED]
	* Method: AvailableSubmitMarkAsSubmittedSubmitByEmailToWeblinkMarketAfterTrialExtended
		* TestCaseLink: "FTEXT_001 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=1960693214&range=A2:A7"
		* Categories: [UNDEFINED]
	* Method: AvailableSubmitMarkAsSubmittedToEmailMarketAfterTrialExtended
		* TestCaseLink: "FTEXT_003 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=1960693214&range=A15:A21"
		* Categories: [UNDEFINED]
* File: TrialStartedWithoutBilling.cs
	* Method: AgencyTryingToDownloadAcordFormOnFormsTab
		* TestCaseLink: "FTA_009 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=0&range=A72:A79"
		* Categories: [UNDEFINED]
			* Log.Step("Create insured with rfq");
			* Log.Step("Go to Forms tab");
			* Log.Step("Click 'upgrade to ProducerConnect Premium' and start trial");
			* Log.Step("Click on download link");
	* Method: AgentClickOnEmailButtonStartTrialDialogIsAppeared
		* TestCaseLink: "FTA_12 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=0&range=A98:A105"
		* Categories: [UNDEFINED]
			* Log.Step("Create insured with rfq");
			* Log.Step("Go to Forms tab");
			* Log.Step("Click 'upgrade to ProducerConnect Premium' and start trial");
			* Log.Step("Select all forms");
			* Log.Step("Press on [Email] button");
			* Log.Step("Wait for 'Send email' dialog");
	* Method: AgentClickOnSendByEmailButtonStartTrialDialogIsAppeared
		* TestCaseLink: "FTA_13 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=0&range=A107:A113"
		* Categories: [UNDEFINED]
			* Log.Step("Create insured with rfq");
			* Log.Step("Go to Forms tab");
			* Log.Step("Click 'upgrade to ProducerConnect Premium' and start trial");
			* Log.Step("Click on [Send by Email]");
	* Method: AgentDownloadAcordAndSupplementalFormsAsZipStartTrialDialogIsAppeared
		* TestCaseLink: "FTA_016 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=0&range=A132:A140"
		* Categories: [UNDEFINED]
			* Log.Step("Go to Forms tab");
			* Log.Step("Click 'upgrade to ProducerConnect Premium' and start trial");
			* Log.Step("Select forms");
			* Log.Step("Press on  [Download as ZIP Archive] button");
	* Method: AgentDownloadAcordFormsViaDownloadAsZipArchiveStartTrialDialogIsAppeared
		* TestCaseLink: "FTA_11 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=0&range=A89:A96"
		* Categories: [UNDEFINED]
			* Log.Step("Create insured with rfq");
			* Log.Step("Go to Forms tab");
			* Log.Step("Click 'upgrade to ProducerConnect Premium' and start trial");
			* Log.Step("Select all forms");
			* Log.Step("Press on [Download as ZIP Archive] button");
	* Method: AgentDownloadAcordFormsViaGetAsOnePdfStartTrialDialogIsAppeared
		* TestCaseLink: "FTA_10 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=0&range=A80:A87"
		* Categories: [UNDEFINED]
			* Log.Step("Create insured with rfq");
			* Log.Step("Go to Forms tab");
			* Log.Step("Click 'upgrade to ProducerConnect Premium' and start trial");
			* Log.Step("Select all forms");
			* Log.Step("Press on [Get as one PDF] button");
	* Method: AgentDownloadAcordsAndSupplementalFormsAsOnePdfStartTrialDialogIsAppeared
		* TestCaseLink: "FTA_015 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=0&range=A123:A130"
		* Categories: [UNDEFINED]
			* Log.Step("Go to Forms tab");
			* Log.Step("Click 'upgrade to ProducerConnect Premium' and start trial");
			* Log.Step("Select all forms");
			* Log.Step("Press on [Get as one PDF] button");
	* Method: AgentDownloadSignedAcordFormStartTrialDialogIsAppeared
		* TestCaseLink: "FTA_14 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=0&range=A115:A121"
		* Categories: [UNDEFINED]
			* Log.Step("Create insured with rfq");
			* Log.Step("Go to Forms tab");
			* Log.Step("Press [Click here] button (if it is present)");
			* Log.Step("Make all forms available");
			* Log.Step("Sign 'ACORD 125'");
			* Log.Step("Wait for 'ACORD 125' change status to signed");
			* Log.Step("Download signed 'ACORD 125'");
	* Method: AgentSendAcordFormViaSendByEmailStartTrialDialogIsNotAppeared
		* TestCaseLink: "FTA_019 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=0&range=A165:A171"
		* Categories: [UNDEFINED]
			* Log.Step("Create insured with rfq");
			* Log.Step("Go to Docs tab");
			* Log.Step("Upload pdf");
			* Log.Step("Go to Forms tab");
			* Log.Step("Press [Click here] button (if it is present)");
			* Log.Step("Click on [Send by Email] for uploaded doc");
			* Log.Step("Wait for 'Send email' dialog");
	* Method: AgentSendAcordsAndSupplementalFormsOnEmailStartTrialDialogIsAppeared
		* TestCaseLink: "FTA_017 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=0&range=A143:A153"
		* Categories: [UNDEFINED]
			* Log.Step("Go to Forms tab");
			* Log.Step("Click 'upgrade to ProducerConnect Premium' and start trial");
			* Log.Step("Select all forms");
			* Log.Step("Press on [Email] button");
			* Log.Step("Wait for 'Send email' dialog");
			* Log.Step("All documents are attached");
	* Method: AgentStartsTrialFromActivePolicyInterfaceToHaveAccessToAcordForms
		* TestCaseLink: "FTA_021 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=0&range=183:192"
		* Categories: [UNDEFINED]
			* Log.Step("Perform submit");
			* Log.Step("Upload quote");
			* Log.Step("Log in as a market user, open the RFQ, mark it as bound");
			* Log.Step("Log in as the agent, click on Quote Docs tab on the left side bar and open Forms collection");
			* Log.ExpectedResult($"There is an information string under Forms collection: '{expectedProducerConnectPremiumMessage}'");
			* Log.Step("Click on the link 'upgrade to ProducerConnect Premium' and click on [Start Trial] button in Dialog box");
			* Log.ExpectedResult("ACORD forms have appeared on the screen: ACORD 130 Workers Compensation Application");
			* Log.Step("Click on the ACORD in a list");
			* Log.ExpectedResult("Download ACORD form in PDF has started");
	* Method: StartTrialAfterMarkAsSubmittedToEmailMarket
		* TestCaseLink: "FTA_006 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=0&range=A44:A49"
		* Categories: [UNDEFINED]
	* Method: StartTrialAfterMarkAsSubmittedToWeblinkMarket
		* TestCaseLink: "FTA_002 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=0&range=A10:A15"
		* Categories: [UNDEFINED]
	* Method: StartTrialAfterResubmitToEmailMarket
		* TestCaseLink: "FTA_007 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=0&range=A51:A63"
		* Categories: [UNDEFINED]
	* Method: StartTrialAfterResubmitToWeblinkMarket
		* TestCaseLink: "FTA_004 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=0&range=A25:A34"
		* Categories: [UNDEFINED]
	* Method: StartTrialAfterSubmitByEmailAcrossWeblinkMarket
		* TestCaseLink: "FTA_003 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=0&range=A17:A23"
		* Categories: [UNDEFINED]
	* Method: StartTrialAfterSubmitOnEmailMarket
		* TestCaseLink: "FTA_005 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=0&range=A36:A42"
		* Categories: [UNDEFINED]
	* Method: StartTrialAfterWeblinkSubmit
		* TestCaseLink: "FTA_001 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=0&range=A2:A7"
		* Categories: [UNDEFINED]
	* Method: StartTrialDialogIsNotShownAgain
		* TestCaseLink: "FTA_008 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=0&range=A65:A70"
		* Categories: [UNDEFINED]
	* Method: StartTrialForAgencyFromEnterpriseSiteViaPremiumButton
		* TestCaseLink: "FTA_026 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=0&range=A224:A227"
		* Categories: [UNDEFINED]
			* Log.Step("Login as Agency user");
			* Log.Step("Go to premium gage AND start trial");
			* Log.ExpectedResult("There is NO premium menu item");
	* Method: StartTrialPeriodForRetailAgencyFromAdminSite
		* TestCaseLink: "FTA_025 : https://docs.google.com/spreadsheets/d/1ffTDLLFRTTac_ZgQfMHsiaWKLHRJns6Vui_T7lej3B4/edit#gid=0&range=A221:A222"
		* Categories: [UNDEFINED]
* File: TutorialTests.cs
	* Method: ThereIsNoNewFeaturesNotifierElementAfterPressOkGotItOnTutorialPopupViaAgentWithUserRole
		* TestCaseLink: "OV-1 : https://docs.google.com/spreadsheets/d/1U-wX6JIVJFuxU-E1EhPjFRz-sDLcXx8DBJz_l8WWHdY/edit#gid=640613836&range=A2:A7"
		* Categories: [UNDEFINED]
			* Log.Step("Reset tutorial video for user");
			* Log.Step("Open 'All insureds' page");
			* Log.Step("Open tutorial dialog");
			* Log.Step("Confirm that tutorial was watched");
			* Log.Step("Logout");
			* Log.ExpectedResult("Open 'All insureds' page");
			* Log.ExpectedResult("There is NO 'New feature notifier' element");
* File: UnrecognizedPagesAndFilesProcessingDragAndDropTests.cs
	* Method: DragAndDropAssignUnparsedPagesToRfqDocsTab
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
			* Log.Step("Upload partly recognized PDF to the Forms tab of the RFQ");
			* Log.ExpectedResult("Document successfully uploaded to the Forms tab of the RFQ");
			* Log.ExpectedResult($"Question '{expectedAnswer.Title}' is filled correctly on the Q&A tab of the RFQ");
			* Log.ExpectedResult("Unparsed pages are assigned to the Docs tab of the RFQ");
			* Log.Step("Find appropriate record in Driver Log");
			* Log.ExpectedResult($"Record status is {expectedStatus}");
	* Method: DragAndDropAssignUnrecognizedPdfToRfqDocsTab
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
			* Log.Step("Upload unrecognized PDF to the Forms tab of the RFQ");
			* Log.ExpectedResult("Document is assigned to the Docs tab of the RFQ");
			* Log.Step("Find appropriate record in Driver Log");
			* Log.ExpectedResult($"Record status is {expectedStatus}");
	* Method: DragAndDropDoNotAssignUnrecognizedXmlToRfqDocsTab
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
			* Log.Step("Upload unrecognized XML to the Forms tab of the RFQ");
			* Log.ExpectedResult("Unparsed pages are not assigned to the Docs tab of the RFQ");
* File: UnrecognizedPagesAndFilesProcessingUplinkDriverTests.cs
	* Method: UplinkAssignUnparsedPagesToRfqDocsTabForAppulateUI
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
			* Log.Step("Uplink partly recognized PDF to Appulate");
			* Log.Step("Open Docs tab of the RFQ");
			* Log.ExpectedResult("Unparsed pages are assigned to the Docs tab of the RFQ");
			* Log.Step("Find appropriate record in Driver Log");
			* Log.ExpectedResult($"Record status is {expectedStatus}");
	* Method: UplinkAssignUnrecognizedPdfToRfqFormsTab
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
			* Log.Step("Uplink unrecognized PDF to Appulate");
			* Log.Step("Set ACORD document type");
			* Log.Step("Assign document to the new RFQ");
			* Log.ExpectedResult("Document is assigned to the Forms tab of the RFQ");
			* Log.ExpectedResult("Support Request email is received");
			* Log.Step("Find appropriate record in Driver Log");
			* Log.ExpectedResult($"Record status is {expectedStatus}");
	* Method: UplinkAssignUnrecognizedXmlToInsuredDocsTab
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
			* Log.Step("Uplink unrecognized XML to Appulate");
			* Log.Step("Assign document to the new Insured");
			* Log.ExpectedResult("Document is assigned to the Docs tab of the Insured");
			* Log.Step("Find appropriate record in Driver Log");
			* Log.ExpectedResult($"Record status is {expectedStatus}");
	* Method: UplinkDoNotAssignUnparsedPagesToRfqDocsTabForCarrierDirect
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
			* Log.Step("Uplink partly recognized PDF to Carrier Direct");
			* Log.Step("Select market, fill options and submit");
			* Log.ExpectedResult("Successful submission");
			* Log.Step("Open submitted RFQ in Appulate");
			* Log.Step("Open Docs tab of the RFQ");
			* Log.ExpectedResult("Unparsed pages are not assigned to the Docs tab of the RFQ");
			* Log.Step("Find appropriate record in Driver Log");
			* Log.ExpectedResult($"Record status is {expectedStatus}");
* File: UplinkIncorrectDocument.cs
	* Method: UplinkToAppulate
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: UplinkLimitsTests.cs
	* Method: AcordXmlContainsLimitsAndDeductiblesCustomSetValuesFromMarketsSelectorColumnsDuringEsubmissionEmailEmulation
		* TestCaseLink: "LimDedAcordXml-4: https://docs.google.com/spreadsheets/d/1pV13jp7eLCgU2pkXEdBS6DnGrH_BC6fuoaOhsM0y6Ms/edit#gid=1181605001&range=A25:A28"
		* Categories: [UNDEFINED]
			* Log.Step("Uplink an ACORD with filled limits an deductibles to Appulate UI");
			* Log.Step($"Select the {CustomLimitsMarket.Name} on Markets Selected");
			* Log.ExpectedResult("Check limits and deductibles custom values on Markets Selector");
			* Log.Step("Click 'Request XML' action and open Request XML in another tab");
			* Log.ExpectedResult("Check that request XML contains limits and deductibles primarily from Markets selector and secondarily from uploaded ACORD");
			* Log.Step($"Submit to the {CustomLimitsMarket.Name} market");
			* Log.Step("Open activity tab of the record and find the last eSubmission event");
			* Log.ExpectedResult("Check that request XML contains the same limits and deductibles values after submit");
	* Method: AcordXmlContainsLimitsAndDeductiblesDefaultSetValuesFromMarketsSelectorColumnsDuringEsubmissionEmailEmulation
		* TestCaseLink: "LimDedAcordXml-3: https://docs.google.com/spreadsheets/d/1pV13jp7eLCgU2pkXEdBS6DnGrH_BC6fuoaOhsM0y6Ms/edit#gid=1181605001&range=A20:A24"
		* Categories: [UNDEFINED]
			* Log.Step("Uplink an ACORD with filled limits an deductibles to Appulate UI");
			* Log.Step($"Select the {DefaultLimitsMarket.Name} on Markets Selected");
			* Log.ExpectedResult("Check limits and deductibles default values on Markets Selector");
			* Log.Step("Click 'Request XML' action and open Request XML in another tab");
			* Log.ExpectedResult("Check that request XML contains limits and deductibles primarily from Markets selector and secondarily from uploaded ACORD");
			* Log.Step("Set new values for limits and deductibles");
			* Log.Step("Click 'Request XML' action and open Request XML in another tab");
			* Log.ExpectedResult("Check that request XML contains newly set limits and deductibles primarily from Markets selector and secondarily from uploaded ACORD");
			* Log.Step("Click the 'View the technical details of data communication' button and get ACORD xml");
			* Log.ExpectedResult("Check that ACORD XML which can be opened using the 'View the technical details of data communication' button contains limits and deductibles from uploaded ACORD");
* File: UplinkSetup.cs
	* Method: AmsIsSynchronizedFromDownloadToSettings
		* TestCaseLink: "AMS_DU9: https://docs.google.com/spreadsheets/d/1SyToSFFBRWaSRbmiaIyBnYz8pTOZaDR9Hc9B-thpD0E/edit#gid=0&range=A23:A27"
		* Categories: [UNDEFINED]
	* Method: AmsIsSynchronizedFromSettingsToDownload
		* TestCaseLink: "AMS_DU9: https://docs.google.com/spreadsheets/d/1SyToSFFBRWaSRbmiaIyBnYz8pTOZaDR9Hc9B-thpD0E/edit#gid=0&range=A23:A27"
		* Categories: [UNDEFINED]
	* Method: ErrorOccurenceIfEmptyAmsSaved
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: UplinkSupportedAmsPageTests.cs
	* Method: CheckColumnExpandersOnSupportedAmsPage
		* TestCaseLink: "AmsList-001 : https://docs.google.com/spreadsheets/d/1-79w0U1pYfQ4MSn6moJzl-1beW4yJDMpto6xxxHrsso/edit#gid=1446918897&range=2:6"
		* Categories: [UNDEFINED]
			* Log.Step("Open 'Agency Management Systems and ACORD Forms Supported' page ");
			* Log.Step($"Expand column '{acordNumber}'");
			* Log.ExpectedResult($"Acord dialog with 'ACORD {acordNumber}' title is opened");
			* Log.Step($"Close dialog with 'ACORD {acordNumber}' title");
* File: UplinkTests.cs
	* Method: AbsenceOfMergeAcordFormsBeforeSubmitOnRedirectorPage
		* TestCaseLink: "NoMergeCd-01 - https://docs.google.com/spreadsheets/d/1WguLlLbsaRgWLybFqvSYfRrtn401x4c9gPg3_wp0GYI/edit#gid=905422879&range=A12:A15"
		* Categories: [UNDEFINED]
			* Log.Step("Uplink on Appulate");
			* Log.ExpectedResult("There are data on questionnaire from ACORD ");
			* Log.Step("Uplink on Carrier Direct");
			* Log.ExpectedResult("There are elements in xml");
			* Log.Step("Make a submission to Market");
			* Log.ExpectedResult("There is successful submission message");
			* Log.ExpectedResult("There are data on questionnaire from ACORD");
	* Method: EmptyDocNameInDriverLog
		* TestCaseLink: "UplUpd-01 - https://docs.google.com/spreadsheets/d/1WguLlLbsaRgWLybFqvSYfRrtn401x4c9gPg3_wp0GYI/edit#gid=300659870&range=55:59"
		* Categories: [UNDEFINED]
			* Log.Step("Create new RfQ by Uplink and change dates");
			* Log.Step("Update RfQ by Uplinking same document");
			* Log.Step("Check markets Acord in Xml");
			* Log.Step("Check DriverLog record for Insured Name");
* File: UplinkViaEmail.cs
	* Method: UplinkViaEmailUnrecognizedFilesProcessing
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
			* Log.Step("Send Email with attached document");
			* Log.Step("Receive notification message");
			* Log.ExpectedResult("Notification message contains expected text");
* File: UploadDocumentTests.cs
	* Method: ResumeBioDocumentTypeUpload
		* TestCaseLink: "Bio - 1: https://docs.google.com/spreadsheets/d/1vmRmrfR67p25BYHhcy5ZRp3FKvkwk3sSfcd-SK79ASQ/edit#gid=0&range=B20"
		* Categories: Categories.Documents
			* Log.Step("Log in as an agency user, create an insured and an RFQ");
			* Log.Step("Go to Docs tab and upload a document");
			* Log.Step("Select document type");
			* Log.Step("Save uploaded document");
			* Log.ExpectedResult("Document is uploaded and has a set of displayed buttons");
			* Log.ExpectedResult("Icon of document has expected title");
			* Log.ExpectedResult($"Document preview dialog has '{documentName}' name");
	* Method: UploadAcordPages
		* TestCaseLink: [UNDEFINED]
		* Categories: Categories.SmokeTestsCategory
	* Method: UploadInsuredDocs
		* TestCaseLink: [UNDEFINED]
		* Categories: Categories.SmokeTestsCategory
	* Method: UploadPolicyDocs
		* TestCaseLink: [UNDEFINED]
		* Categories: Categories.SmokeTestsCategory, Categories.PolicyCategory
* File: UploadQuoteTests.cs
	* Method: AgencyCarriers
		* TestCaseLink: "QD_1 : https://docs.google.com/spreadsheets/d/12bcxPVyovw46WXyZk1MnbleJdo_wWRIo02wbCtIERnw/edit#gid=973979512&range=A2"
		* Categories: [UNDEFINED]
			* Log.Step("Create RFQ and Select markets");
			* Log.Step("Submit by appulate");
			* Log.ExpectedResult($"Check for {MarketsSelectorAction.UploadQuote.GetDescription()} action for markets from market side");
			* Log.Step("Select market");
			* Log.ExpectedResult("Check for 'Upload quote' links under markets from market side");
			* Log.Step("Upload quote");
			* Log.ExpectedResult("Check that quote is uploaded");
	* Method: AgencyMgaCarrier
		* TestCaseLink: "QD_3 : https://docs.google.com/spreadsheets/d/12bcxPVyovw46WXyZk1MnbleJdo_wWRIo02wbCtIERnw/edit#gid=973979512&range=A15"
		* Categories: [UNDEFINED]
			* Log.Step("Create RFQ");
			* Log.Step("Select markets");
			* Log.Step("Market and submarket don't have 'Upload quote' actions");
			* Log.Step("Fill in some questions and submit");
			* Log.ExpectedResult($"Check that there are '{MarketsSelectorAction.UploadQuote.GetDescription()}' actions for market and submarket");
			* Log.Step("Upload quotes");
			* Log.ExpectedResult("Check that quotes are uploaded");
	* Method: CarrierMgaAgency
		* TestCaseLink: "QD_2 : https://docs.google.com/spreadsheets/d/12bcxPVyovw46WXyZk1MnbleJdo_wWRIo02wbCtIERnw/edit#gid=973979512&range=A8"
		* Categories: [UNDEFINED]
			* Log.Step("Create RfQ");
			* Log.Step("Select source agency");
			* Log.Step("Upload quote");
			* Log.Step("Check that quote is uploaded");
			* Log.Step($"Check for '{MarketsSelectorAction.UploadQuote.GetDescription()}' action");
			* Log.Step("Upload quotes");
			* Log.Step("Check that quotes are uploaded");
			* Log.Step("Select source agency");
			* Log.Step($"Check for '{MarketsSelectorAction.UploadQuote.GetDescription()}' actions");
			* Log.Step($"Check for '{MarketsSelectorAction.UploadQuote.GetDescription()}' actions");
* File: UserProfileTests.cs
	* Method: ActivateAgencyViewerFromMarketSide
		* TestCaseLink: "UPP_10 : https://docs.google.com/spreadsheets/d/1C-I-UUEM-j2BVsqbLmYj57n1y3vsQ_iDORW6jFCVmdE/edit#gid=0&range=134:140"
		* Categories: [UNDEFINED]
			* Log.Step("Create an RFQ, select an agency and an producer. Open Agency Info page");
			* Log.Step("Click 'Edit user' on the right column of users grid to open User Profile page");
			* Log.ExpectedResult("User role is 'Viewer'");
			* Log.Step("Click 'Upgrade Role' button at the bottom of the page");
			* Log.ExpectedResult("'Upgrade Role' button disappears, the user role changes to 'User'");
	* Method: SameEmailOnLoginAndResetPasswordPages
		* TestCaseLink: "PSW-RST-001 - https://docs.google.com/spreadsheets/d/1a7ATpkJwXkGGi1t2jXUceFo4NXfcEE2Yu2H9A8HLZac/edit#gid=0&range=2:2"
		* Categories: [UNDEFINED]
* File: UsersGridTests.cs
	* Method: ActiveAndInactiveUsersAreDisplayedOnUsersPage
		* TestCaseLink: "U-1 : https://docs.google.com/spreadsheets/d/1YdChWYkmrq4EssLPdLMv3YBDoUW75P19e3IKpwbVlMI/edit#gid=1626946334&range=A2:A3"
		* Categories: [UNDEFINED]
			* Log.ExpectedResult($"Active and Inactive users are displayed on users page AND STATUS filter value is {EnabledFilter.All}");
* File: VisibilitySetting.cs
	* Method: VisibilityForAgenciesSetting
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: VisibleCompanyWithRealCompanyTests.cs
	* Method: TestingAgencyForNonAccessTestingMarketUser
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: TestingMarketForNonAccessTestingAgencyUser
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: TestingMarketForNonAccessTestingMarketUser
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: VisibleOnAgencyAvailableGridTest.cs
	* Method: Agency_Exists_On_Agencies_Selected_Page
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Available_Agency
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Disabled_Agency
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Hidden_Agency_From_Market
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Non_Test_Agency
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Not_Available_Broker
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Not_Available_Carrier
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Testing_Agency_Excluded_By_Filter
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: VisibleOnAgencySelectedGridTest.cs
	* Method: Agency_Exists_On_Agency_Available_Page
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Disabled_Selected_Agency
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Hidden_Selected_Agency_From_Market
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Selected_Agency
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Selected_Market_As_Agency
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: VisibleOnMarketAvailableGridForAgencyTest.cs
	* Method: Available_Market
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Disabled_Market
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Empty_Program_Market
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Hidden_Market
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Insurance_Line_Filter
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Market_Exists_On_Market_Blocked_Page
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Market_Exists_On_Market_Selected_Page
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: MarketWithNoHostName
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Non_Appulate_Market_Listing
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Non_Test_Market
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: VisibleOnMarketAvailableGridForMarketTest.cs
	* Method: Available_Broker
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Available_Carrier
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Disabled_Market
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Empty_Program_Market
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Hidden_Market
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Insurance_Line_Filter
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Market_Exists_On_Market_Blocked_Page
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Market_Exists_On_Market_Selected_Page
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: MarketWithNoHostName
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Non_Appulate_Market_Listing
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Non_Test_Market
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: VisibleOnMarketSelectedGridForAgencyTest.cs
	* Method: Disabled_Selected_Market
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Insurance_Line_Filter
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Market_Exists_On_Market_Available_Page
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Market_Exists_On_Market_Blocked_Page
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: VisibleOnMarketSelectedGridForMarketTest.cs
	* Method: Disabled_Selected_Market
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Insurance_Line_Filter
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Market_Exists_On_Market_Available_Page
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Market_Exists_On_Market_Blocked_Page
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: Own_Market_Selected_Everywhere
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
* File: WebinarsTests.cs
	* Method: AnonymousUserCanOpenWebinarPageAndJoin
		* TestCaseLink: "APPW_002 - https://docs.google.com/spreadsheets/d/1vfaxKeIt0QcMzCOMfHLNHA6AUSExGJsQSBDHKXm7c40/edit#gid=1885814762&range=A8"
		* Categories: [UNDEFINED]
			* Log.Step("Open home page as anonymous user");
			* Log.Step("Check webinars page");
	* Method: OpenWebinarsPageAndJoinToWebinarTest
		* TestCaseLink: "APPW_001 - https://docs.google.com/spreadsheets/d/1vfaxKeIt0QcMzCOMfHLNHA6AUSExGJsQSBDHKXm7c40/edit#gid=1885814762&range=A2"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency user and open All Insured page");
			* Log.Step("Check webinars page");
* File: WeblinkSetup.cs
	* Method: CheckWeblinkInstallationLinks
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: InstallationTestNotPassedIfPluginNotInstalled
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: InstallPluginAndCheckAutoLogin
		* TestCaseLink: [UNDEFINED]
		* Categories: [UNDEFINED]
	* Method: SetupWeblinkExtensionToChrome
		* TestCaseLink: [UNDEFINED]
		* Categories: Categories.ExcludingCategoryOnlyProductionSite
* File: Workflow5Star.cs
	* Method: MainWorkflow5Star
		* TestCaseLink: "5Star_2 : https://docs.google.com/spreadsheets/d/1SL2WiQqwa-P1e8VekDgm7dd7aUXPoJhfh9GfA49lKlw/edit#gid=0&range=A24:A29"
		* Categories: Categories.SentDocumentForSignCategory
			* Log.Step("Create rfq AND select market and submarket");
			* Log.Step("Fill questionnaire to green A indicator");
			* Log.Step("Submit to market");
			* Log.Step("Fill insurance history: market name; attach file");
			* Log.Step("Release quote");
			* Log.ExpectedResult("Check that under submarket appeared quote document");
			* Log.Step("Sign ACORD and do request to bind");
			* Log.ExpectedResult("Check statuses");
			* Log.Step("Bind quote");
			* Log.ExpectedResult("Check policy appeared");
* File: WorkflowSubmissionTests.cs
	* Method: AmTrustApiMgaWorkflowTest
		* TestCaseLink: "AmTrWc-Wf-01: https://docs.google.com/spreadsheets/d/17BuayNbZ745i-hw7mo-qvq7TXNvu1NYZqUN9YBE_3DI/edit#gid=1146484527&range=2:14"
		* Categories: Categories.Clients.External.AmTrustWc, Categories.ExcludingCategoryOnlyTestingSites
			* Log.ExpectedResult($"Check correct credentials between {_.Mga.Name} and {_.CarrierN(1).Name}");
			* Log.Step("Create RFQ WC-line on Agency side");
			* Log.Step("Select market and submarket on Markets Selector");
			* Log.Step("Fill in questionnaire to A-indicator");
			* Log.ExpectedResult($"'{_.CarrierN(1)}' market has admission indicator '{AdmissionIndicator.OrangeA.GetDescription()}'");
			* Log.ExpectedResult($"'{_.CarrierN(1)}' market qpd icon counter value is 1");
			* Log.Step($"Open QPD and check '{QpdTabs.LimitsAndDeductibles.GetDescription()}' tab");
			* Log.Step("Select limits");
			* Log.ExpectedResult($"'{Limits.LimitsCombination.GetDescription()}' control is NOT required");
			* Log.Step("Close qpd");
			* Log.ExpectedResult($"'{_.Mga}' and '{_.CarrierN(1)}' markets have '{AdmissionIndicator.GreenA.GetDescription()}' admission indicators");
			* Log.ExpectedResult($"There are expected available actions for '{_.Mga}' market");
			* Log.ExpectedResult($"'{_.CarrierN(1)}' market qpd icon counter doesn't have value");
			* Log.Step($"Submit to {_.Mga}");
			* Log.ExpectedResult("Related row elements: indicator, premium - Agency side for market and generated quote - as an expected");
			* Log.ExpectedResult("Related row elements: indicator, premium - Mga side for market and generated quote - as an expected");
			* Log.Step($"Submit to '{_.CarrierN(1)}' market");
			* Log.ExpectedResult($"'{_.Mga}' and '{_.CarrierN(1)}' markets have '{MarketStatus.QuoteReleased.GetDescription()}' status");
			* Log.ExpectedResult("There is new quote");
			* Log.ExpectedResult($"'{quoteName}' quote has premium");
			* Log.ExpectedResult($"'{quoteName}' quote has expected actions");
			* Log.Step($"Release '{quoteName}' quote");
			* Log.ExpectedResult($"'{quoteName}' quote has status '{QuoteStatus.QuoteReleased.GetDescription()}'");
			* Log.ExpectedResult($"'{PaymentPlan.PaymentPlan.GetDescription()}' and '{PaymentPlan.BillingType.GetDescription()}' questions are required");
			* Log.Step("Select payment plan");
			* Log.ExpectedResult($"'{quoteName}' quote has status '{QuoteStatus.RequestedToBind.GetDescription()}'");
			* Log.Step("Perform external Bind");
			* Log.ExpectedResult("Check bound status policy");
	* Method: AnswersInQpdAffectCommoditiesHauledCollectionInQuestionnaire
		* TestCaseLink: "Bro-QPD1 - https://docs.google.com/spreadsheets/d/1jBGIks6RAdLiDkkpQuthKhhCCvZu5KjPoSfyISvvWas/edit#gid=503873439&range=2:7"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites, Categories.BrooksideGeneral
			* Log.Step($"Log in as an agency user, create an insured and a '{insuranceLine.GetDescription()}' RFQ");
			* Log.Step($"Select '{_.Mga}' market and '{_.CarrierN(1)}' submarket on markets selector");
			* Log.Step("Open QP dialog and select insurance program");
			* Log.Step("Choose 'Motor Truck Cargo' = Yes and go to 'Limits&Deductibles' tab of QP dialog");
			* Log.ExpectedResult($"'{Deductibles.MotorTruckCargoDeductible.GetDescription()}' dropdown has expected values on Limits & Deductibles tab");
			* Log.Step("Close QP dialog");
			* Log.Step("Add 2 records to Commodities hauled collection: one Commodity supports and another does not support 500 and 1000 values for MTC Deductible");
			* Log.Step("Return to QP dialog and open Limits & Deductibles tab");
			* Log.ExpectedResult($"'{Deductibles.MotorTruckCargoDeductible.GetDescription()}' dropdown has updated values on Limits & Deductibles tab");
			* Log.Step("Close QP dialog");
			* Log.Step("Delete first record from the Commodities hauled collection");
			* Log.Step("Return to QP dialog and open Limits & Deductibles tab");
			* Log.ExpectedResult($"'{Deductibles.MotorTruckCargoDeductible.GetDescription()}' dropdown has initial values on Limits & Deductibles tab");
	* Method: AtlasVoltaGlWorkflowTest
		* TestCaseLink: "VolAtlGl-QG-01 : https://docs.google.com/spreadsheets/d/1BftUC66S-Bu2MIQGECEXQCAhhDqOWT18EfOoCnDArvM/edit#gid=0"
		* Categories: Categories.Clients.External.RliInsuranceCompanyBop, Categories.ExcludingCategoryOnlyTestingSites
			* Log.Step("Create RFQ GL-line on Agency side");
			* Log.Step("Select Mga and his carrier on Markets Selector");
			* Log.Step("Fill in questionnaire to A-indicator");
			* Log.ExpectedResult("Check related row elements: indicator, buttons");
			* Log.Step($"Perform Submit to {_.Mga.Name}");
			* Log.ExpectedResult("Check related row elements: premium, indicator, buttons, statuses");
			* Log.Step("Fill in new question to A-indicator");
			* Log.Step("Perform request quote");
			* Log.ExpectedResult("Check related row elements: premium, indicator, statuses");
			* Log.ExpectedResult("Check related row elements: indicator, buttons");
	* Method: AutoSubmitAfterQuoteIsGenerated
		* TestCaseLink: "SW_7: https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=83694423&range=A62:A63"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an MGA user, create an insured and a GL RFQ");
			* Log.Step("Add a carrier on Markets Selector");
			* Log.Step("Fill out questionnaire");
			* Log.ExpectedResult("Check indicator, statuses and available actions");
			* Log.Step("Generate quote");
			* Log.ExpectedResult("Check statuses");
			* Log.ExpectedResult("Check activity log events");
	* Method: AutoSubmitAfterQuoteIsUploaded
		* TestCaseLink: "SW_6: https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=83694423&range=A56"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an MGA user, create an insured and a WC RFQ");
			* Log.Step("Add three carriers on MS");
			* Log.Step("Upload a quote under the email type carrier");
			* Log.ExpectedResult("Check record, carriers' and quote document statuses");
			* Log.Step("Upload a quote under the weblink type carrier");
			* Log.ExpectedResult("Check record, carriers' and quote document statuses");
			* Log.Step("Upload a quote under the eSubmission type carrier");
			* Log.ExpectedResult("Check record, carriers' and quote document statuses");
			* Log.ExpectedResult("Check activity log events");
	* Method: BindingIsSuccessfulForTrupanionFromAppointedAgency
		* TestCaseLink: "TruPet_01 : https://docs.google.com/spreadsheets/d/1GAie3oY8xtyfimP6voADOw7zjhNPrbGK7sORzs_G9pM/edit#gid=1979592123&range=2:6"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites, Categories.Clients.External.TrupanionPet
			* Log.Step("Fill in questionnaire.");
			* Log.Step("Click 'Submit' button.");
			* Log.ExpectedResult("Newly generated 3 quotes returned by the external service are displayed, estimated premium is displayed for each one.");
			* Log.Step("Click 'Bind' for the first quote.  Click 'Open Card Registering Tool' button. Fill in card data");
			* Log.Step("Click 'Bind' for the second quote. Click 'Open Card Registering Tool' button. Fill in card data.");
			* Log.Step("Click 'Bind' for the second quote and click 'Proceed'");
			* Log.Step("Go to 'Options' tab of the Policy.");
			* Log.ExpectedResult("Policy number is not empty as it is taken from the external site.");
	* Method: BindingIsSuccessfulForTrupanionFromPendingRequestAgency
		* TestCaseLink: "TruPet_02 : https://docs.google.com/spreadsheets/d/1GAie3oY8xtyfimP6voADOw7zjhNPrbGK7sORzs_G9pM/edit#gid=1979592123&range=7:12"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites, Categories.Clients.External.TrupanionPet
			* Log.Step("Go to RFQ -> Q&A tab -> Select 'Trupanion Testing' market on Markets Selector. Fill in questionnaire.");
			* Log.Step("Click 'Submit' button.");
			* Log.ExpectedResult("'Bind' button is available.");
			* Log.Step("Open the RFQ as a Market user");
			* Log.Step("For Proposal under current Market click on 'Bind' button. Click 'Open Card Registering Tool' button. Fill in card data");
			* Log.Step(" Click 'Proceed' on 'Bind' window.");
			* Log.ExpectedResult("'Active policy' page is opened. Market for policy = Test market, Record Status = Bound");
	* Method: BrooksideLloydsAutomobileBusinessWorkflowTest
		* TestCaseLink: "Bro-L1: https://docs.google.com/spreadsheets/d/1jBGIks6RAdLiDkkpQuthKhhCCvZu5KjPoSfyISvvWas/edit#gid=1849636041&range=A28:A43"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites, Categories.BrooksideGeneral
			* Log.Step("Log in as an agency user and create an Automobile-Business RFQ");
			* Log.ExpectedResult("Check record status, it must be equal to 'New request for quote'");
			* Log.Step($"Select '{_.Mga.Name}', '{_.CarrierN(1).Name}' and {_.CarrierN(2).Name}  submarkets on Markets Selector");
			* Log.ExpectedResult("Check related to market and submarket row elements: indicator, status, buttons, contact.  And docs tab has asterisk");
			* Log.Step("Set deductible for both markets");
			* Log.ExpectedResult("Check related to submarket row elements: indicator, deductibles, auto-generation icon");
			* Log.Step("Add a new insured main contact");
			* Log.Step("Fill out questionnaire, assign a producer, upload required documents to get GreenA indicator");
			* Log.ExpectedResult("Check related to market and submarket row elements: indicator, status, buttons, contact");
			* Log.Step($"Submit to an MGA: {_.Mga.Name}");
			* Log.ExpectedResult("Check related to market and submarket row elements: indicator, status, buttons, contact");
			* Log.Step("Proceed RtB");
			* Log.ExpectedResult("Check Binding has been requested. Status = Requested to Bind, 'Cancel Binding' button is available");
			* Log.Step("Underwriter finds and opens this RFQ in its account in Appulate");
			* Log.ExpectedResult("Check that Status = Requested to Bind, 'Bind' button is available");
			* Log.Step($"Underwriter '{MarketsSelectorAction.MarkAsBound.GetDescription()}' quote");
			* Log.ExpectedResult($"Check Record status = Active Policy, {_.CarrierN(1).Name} has Bound status and active UnBind button");
	* Method: BrooksideLloydsMtcWorkflowTest
		* TestCaseLink: "Bro-L2: https://docs.google.com/spreadsheets/d/1jBGIks6RAdLiDkkpQuthKhhCCvZu5KjPoSfyISvvWas/edit#gid=1849636041&range=A44:A50"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites, Categories.BrooksideGeneral
			* Log.Step("Log in as an agency user and create a MTC RFQ");
			* Log.Step($"Select '{_.Mga.Name}' and the '{_.CarrierN(1).Name}' submarket on Markets Selector");
			* Log.ExpectedResult("Check related to market and submarket row elements: indicator, status, buttons, contact and docs tab");
			* Log.Step("Select limit's, deductible's values and answer required questions");
			* Log.Step("Fill out questionnaire, assign a producer, upload required documents to get GreenA indicator");
			* Log.ExpectedResult("Check related to market and submarket row elements: indicator, status, buttons, contact");
			* Log.Step($"Submit to an MGA: {_.Mga.Name}");
			* Log.ExpectedResult("Check market and submarket status");
			* Log.Step("Click Request to bind button");
			* Log.ExpectedResult("Check Binding has been requested. Status = Requested to Bind");
			* Log.Step("Underwriter finds and opens this RFQ in its account in Appulate");
			* Log.ExpectedResult("Check that Status = Requested to Bind, 'Bind' button is available");
			* Log.Step($"Underwriter '{MarketsSelectorAction.MarkAsBound.GetDescription()}' quote");
			* Log.ExpectedResult($"Check Record status = Active Policy, {_.CarrierN(1).Name} has Bound status and active UnBind button");
	* Method: BrooksideSutterAutomobileBusinessWorkflowTest
		* TestCaseLink: "Bro-S1: https://docs.google.com/spreadsheets/d/1jBGIks6RAdLiDkkpQuthKhhCCvZu5KjPoSfyISvvWas/edit#gid=1849636041&range=A2:A19"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites, Categories.BrooksideGeneral
			* Log.Step("Log in as an agency user and create an Automobile-Business RFQ");
			* Log.ExpectedResult("Check record status, it must be equal to 'New request for quote'");
			* Log.Step($"Select '{_.Mga.Name}', '{_.CarrierN(1).Name}' and {_.CarrierN(2).Name}  submarkets on Markets Selector");
			* Log.ExpectedResult("Check related to market and submarket row elements: indicator, premium, status, buttons, contact. And docs tab has asterisk");
			* Log.Step("Set deductible for both markets");
			* Log.ExpectedResult("Check related to submarket row elements: indicator, premium, limits, deductibles, auto-generation icon");
			* Log.Step("Add a new insured main contact");
			* Log.Step("Fill out questionnaire, assign a producer, upload required documents to get GreenA indicator");
			* Log.ExpectedResult("Check related to market and submarket row elements: indicator, premium, status, buttons, contact");
			* Log.Step($"Submit to an MGA: {_.Mga.Name}");
			* Log.ExpectedResult("Check related to market and submarket row elements: indicator, premium, status, buttons, contact");
			* Log.Step("Upload Vehicle Registration Certificate and Request to Bind");
			* Log.ExpectedResult("Check Binding has been requested. Status = Requested to Bind, 'Cancel Binding' button is available");
			* Log.ExpectedResult("Check that Status = Requested to Bind, 'Bind' button is available");
			* Log.Step("Underwriter finds and opens this RFQ in its account in Appulate");
			* Log.ExpectedResult("Check that Status = Requested to Bind, 'Bind' button is available");
			* Log.Step("Underwriter binds quote");
			* Log.ExpectedResult($"Check Record status = Active Policy, {_.CarrierN(1).Name} has Bound status and active UnBind button");
	* Method: BurnsWilcoxPuWorkflowTest
		* TestCaseLink: "DQ_01 : https://docs.google.com/spreadsheets/d/1b54L4y4rNcUPSTaeBIhXUvOq2JF7mqUhaiY9CUU2V0w/edit#gid=1245275954&range=A2:A9"
		* Categories: Categories.Clients.External.BurnsWilcoxUmbrella, Categories.ExcludingCategoryOnlyTestingSites
			* Log.Step("Create RFQ PU-line on Agency side");
			* Log.Step("Fill in questionnaire for QuickQuote generation");
			* Log.Step("Assign Ag.producer to RFQ");
			* Log.Step("Perform submission -> request QuickQuote");
			* Log.ExpectedResult("Check correct Indicators");
			* Log.ExpectedResult("Check correct Quote Document Name");
			* Log.ExpectedResult("Check correct statuses, premium and buttons on MS");
			* Log.Step("Fill in a question");
			* Log.Step($"Click rtb button for the '{quickQuoteName}' quote");
			* Log.ExpectedResult("There is expected message");
			* Log.Step($"Status of '{quickQuoteName}' quote is '{QuoteStatus.QuotePrepared.GetDescription()}'");
			* Log.Step("Fill questionnaire");
			* Log.ExpectedResult("Check correct Indicators");
			* Log.Step("Perform request DetailedQuote");
			* Log.ExpectedResult("Check correct Indicators");
			* Log.ExpectedResult("Check correct Quote Document Name");
			* Log.ExpectedResult("Check correct statuses, premium and buttons on MS");
	* Method: CheckQpdForSutterCommercialAutoPackage
		* TestCaseLink: "Bro-QPD6: https://docs.google.com/spreadsheets/d/1jBGIks6RAdLiDkkpQuthKhhCCvZu5KjPoSfyISvvWas/edit#gid=503873439&range=A72:A79"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites, Categories.BrooksideGeneral
			* Log.Step($"Log in as an agency user, create an insured and a '{insuranceLine.GetDescription()}' RFQ");
			* Log.Step($"Select '{brookside}' market and '{sutter}' submarket on market selector");
			* Log.ExpectedResult("QPD button has expected count of required questions and has expected tooltip message");
			* Log.Step("Open QP dialog");
			* Log.ExpectedResult($"Only '{QpdTabs.Coverage.GetDescription()}' tab is opened");
			* Log.ExpectedResult($"There is expected value of required questions on '{QpdTabs.Coverage.GetDescription()}' tab");
			* Log.ExpectedResult($"'{insuranceProgramLabel}' field is required and has '{FormContentType.Dropdown.GetDescription()}' type");
			* Log.Step("Select insurance program");
			* Log.ExpectedResult($"There are expected values of required questions on '{QpdTabs.Coverage.GetDescription()}' and '{QpdTabs.LimitsAndDeductibles.GetDescription()}' tabs");
			* Log.ExpectedResult($"Questions are required on '{QpdTabs.Coverage.GetDescription()}' tab and have '{FormContentType.RadioButtons.GetDescription()}' type");
			* Log.Step($"Fill questions on '{QpdTabs.Coverage.GetDescription()}' tab");
			* Log.ExpectedResult($"Questions are required on '{QpdTabs.LimitsAndDeductibles.GetDescription()}' tab and have '{FormContentType.Dropdown.GetDescription()}' type");
			* Log.ExpectedResult($"Questions have expected values of answers on '{QpdTabs.LimitsAndDeductibles.GetDescription()}' tab");
			* Log.Step($"Fill '{Coverages.NonTrucking.GetDescription()}' question on '{QpdTabs.Coverage.GetDescription()}' tab");
			* Log.ExpectedResult($"'{Coverages.MotorTruckCargo.GetDescription()}' question is disabled and doesn't have asterisk");
			* Log.Step($"Fill questions on '{QpdTabs.Coverage.GetDescription()}' tab");
			* Log.ExpectedResult($"'{Coverages.NonTrucking.GetDescription()}' question is disabled");
			* Log.ExpectedResult($"Questions are required on '{QpdTabs.Coverage.GetDescription()}' tab");
			* Log.ExpectedResult($"Questions have expected types of answers on '{QpdTabs.Coverage.GetDescription()}' tab");
			* Log.ExpectedResult($"'{Coverages.MotorTruckCoverageType.GetDescription()}' question has expected values of answers on '{QpdTabs.Coverage.GetDescription()}' tab");
			* Log.Step($"Fill questions on '{QpdTabs.Coverage.GetDescription()}' tab");
			* Log.ExpectedResult($"There are NO required questions on '{QpdTabs.Coverage.GetDescription()}' tab");
			* Log.ExpectedResult($"There are required questions on '{QpdTabs.LimitsAndDeductibles.GetDescription()}' tab");
			* Log.ExpectedResult($"Questions have expected types of answers on '{QpdTabs.LimitsAndDeductibles.GetDescription()}' tab");
			* Log.ExpectedResult($"'{Deductibles.MotorTruckCargoDeductible.GetDescription()}' questions has expected values of answers on '{QpdTabs.LimitsAndDeductibles.GetDescription()}' tab");
			* Log.Step("Select limit and deductible values");
			* Log.Step("Close QP dialog");
			* Log.ExpectedResult("There are expected limit and deductible values on market selector");
	* Method: CheckQuoteParametersDialogForSutterAndLloydsAutob
		* TestCaseLink: "Bro-QPD2 - https://docs.google.com/spreadsheets/d/1jBGIks6RAdLiDkkpQuthKhhCCvZu5KjPoSfyISvvWas/edit#gid=503873439&range=A8:A20"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites, Categories.BrooksideGeneral
			* Log.Step("Create an Rfq by agent and add markets");
			* Log.Step("Open and check Coverage tab");
			* Log.Step("Check coverage tab after coverage selection");
			* Log.Step("Set Limits and Deductibles and check it");
			* Log.Step("Open and check Coverage tab");
			* Log.Step("Check coverage tab after coverage selection");
			* Log.Step("Set Limits and Deductibles and check it");
	* Method: CheckSubmitWithBreakupByRegionsSettingEnabled
		* TestCaseLink: "SBBR-1: https://docs.google.com/spreadsheets/d/13gG5BnLI33otFFLgJhhfPQRtOTA46GqXqKCXQ5Tg2fs/edit#gid=0&range=A2:A8"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an agency user, create an insured and a WC RFQ");
			* Log.Step($"Select {_.CarrierN(1).Name} market and perform submit to it");
			* Log.ExpectedResult($"'Submission notification' email has been sent to the email that was specified for a region: {regionInfo.NotificationEmail}");
	* Method: EmailSubmitOnNotSubmittableWeblinkMarket
		* TestCaseLink: "SW_4 - https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=83694423&range=A32"
		* Categories: [UNDEFINED]
			* Log.Step("Create RfQ and Select weblink market");
			* Log.ExpectedResult("Check that market not submittable by weblink");
			* Log.ExpectedResult("Check available submission actions");
			* Log.Step("Submit by email to weblink market");
	* Method: EmailSubmitOnSubmittableWeblinkMarket
		* TestCaseLink: "SW_4 - https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=83694423&range=A32"
		* Categories: [UNDEFINED]
			* Log.Step("Create RfQ and Select weblink market");
			* Log.ExpectedResult("Check that market submittable by weblink");
			* Log.ExpectedResult("Check available submission actions");
			* Log.Step("Submit by email to weblink market");
	* Method: EmployersVoltaWcWorkflowTest
		* TestCaseLink: "EmplWC-QG-02: https://docs.google.com/spreadsheets/d/1HVgn0_neywJu6he_KTe6v6xbpYkKARle26XwTZXMU-k/edit#gid=0&range=A14:A22"
		* Categories: Categories.Clients.External.EmployersWc, Categories.ExcludingCategoryOnlyTestingSites
			* Log.Step("Create RFQ WC-line on Agency side");
			* Log.Step($"Select Mga '{_.Mga}' and his carrier'{_.CarrierN(1)}' on Markets Selector");
			* Log.Step("Fill in questionnaire to A-indicator");
			* Log.Step($"Select limit values for '{_.CarrierN(1)}' market");
			* Log.ExpectedResult("Check related row elements: indicator");
			* Log.Step($"Perform Submit to {_.Mga}");
			* Log.ExpectedResult("Check related row elements: indicator, status");
			* Log.Step($"Go to {_.Mga} side to current RFQ");
			* Log.ExpectedResult("Check related row elements: indicator, buttons");
			* Log.Step($"Perform Submit from {_.Mga} to {_.CarrierN(1)}");
			* Log.ExpectedResult("Check related row elements: market status, premium, indicator");
			* Log.ExpectedResult("Check that Quote document exists in Docs Tab");
			* Log.Step("Fill new required question to reach A-green indicator");
			* Log.Step($"Select 'Payment plan' for '{_.CarrierN(1)}' market");
			* Log.ExpectedResult("Check related row elements: indicator, buttons");
			* Log.ExpectedResult("Generate new quote document");
			* Log.ExpectedResult("Check quote document on correct content after generation");
			* Log.Step("Bind quote document");
			* Log.ExpectedResult("Check Policy status");
			* Log.ExpectedResult("Check that policy number was added");
			* Log.ExpectedResult($"Check correct log in Activity Log on {_.Mga} side");
	* Method: EmployersWcCarrierWorkflowTest1
		* TestCaseLink: "EmplWC-QG-01: https://docs.google.com/spreadsheets/d/1HVgn0_neywJu6he_KTe6v6xbpYkKARle26XwTZXMU-k/edit#gid=0&range=A2:A8"
		* Categories: Categories.Clients.External.EmployersWc, Categories.ExcludingCategoryOnlyTestingSites
			* Log.Step("Create RFQ WC-line on Agency side");
			* Log.Step($"Select '{_.CarrierN(1)}' market on Markets Selector");
			* Log.Step("Open QPD dialog by clicking on QPD icon");
			* Log.ExpectedResult("Check active tab and ui warning message on QP dialog and close it");
			* Log.Step($"Fill in questionnaire to get {AdmissionIndicator.OrangeA}");
			* Log.ExpectedResult("Check related to market row elements: indicator, buttons, required qpd questions counter");
			* Log.Step("Open QP dialog");
			* Log.ExpectedResult("Check QP dialog related elements: active tab, required questions counter, limits values etc.");
			* Log.Step("Select a value for Limits");
			* Log.ExpectedResult("Check QP dialog related elements: active tab, required questions counter, limits values etc.");
			* Log.ExpectedResult("Check related to market row elements: indicator, buttons, required qpd questions counter");
			* Log.Step("Perform Submit -> Request quote from external service");
			* Log.ExpectedResult("Check related row elements: indicator, premium, status, buttons");
			* Log.ExpectedResult("Check logged events in Activity log");
			* Log.Step("Return to QA page and open QP dialog");
			* Log.ExpectedResult("Check QP dialog related elements: active tab and required questions counter");
			* Log.ExpectedResult("Open Payment Plan tab and check QP dialog related elements: active tab, required questions counter, available values etc.");
			* Log.Step("Select Payment Plan and close dialog");
			* Log.ExpectedResult("Open QP dialog and check its related elements: selected value and required questions counter");
			* Log.Step("Close QP dialog and fill additional questionnaire");
			* Log.ExpectedResult("Check related to market row elements: indicator, buttons");
			* Log.Step("Download quote document by clicking on it and check contents");
	* Method: HiscoxQuoteGenerationWorkflow
		* TestCaseLink: "HiscQG-01 - https://docs.google.com/spreadsheets/d/1uHYIjnQY96OfRFmObfotQ5FokQ_lM3WSUYTAgorVHRM/edit#gid=0&range=A2:A4"
		* Categories: Categories.Clients.External.HiscoxGl, Categories.ExcludingCategoryOnlyTestingSites
			* Log.Step("Create RFQ GL, choose FirstChoice Insurance Intermediaries MGA Testing and fill questionnaire to A-green");
			* Log.Step("Submit to FirstChoice Insurance Intermediaries MGA Testing - generate quote");
			* Log.ExpectedResult("Premium is positive and all Statuses are correct");
			* Log.Step("Request quote");
			* Log.ExpectedResult("Only one quote is displayed");
			* Log.Step("Perform Rtb - opened external page on Hiscox portal");
			* Log.ExpectedResult("Url on external Rtb page contain Markets data");
			* Log.ExpectedResult("Check statuses and existing buttons");
			* Log.ExpectedResult("Check link on page which opened to click External Link button");
	* Method: IpfsWithIpfsMarketIntegration
		* TestCaseLink: "Ipfs-HW-01 : https://docs.google.com/spreadsheets/d/1rsHoHgjbap1GmuBsWCmlhMyXj3bZYKXKdn7ZvRZ4pBs/edit#gid=0"
		* Categories: Categories.Clients.External.Ipfs
			* Log.Step("Create RFQ BOP-line on Agency side");
			* Log.Step("Select Market on Markets Selector");
			* Log.Step("Fill in questionnaire to A-indicator");
			* Log.ExpectedResult("Check related row elements: indicator A-green");
			* Log.Step($"Perform Submit to {_.CarrierN(1).Name}");
			* Log.ExpectedResult("Check quote document on IPFS content");
	* Method: IpfsWithWestchesterIntegration
		* TestCaseLink: "Ipfs-HW-01 : https://docs.google.com/spreadsheets/d/1rsHoHgjbap1GmuBsWCmlhMyXj3bZYKXKdn7ZvRZ4pBs/edit#gid=0"
		* Categories: Categories.Clients.External.Ipfs
			* Log.Step("Create RFQ BOP-line on Agency side");
			* Log.Step("Select Mga and his carrier on Markets Selector");
			* Log.Step("Fill in questionnaire to A-indicator");
			* Log.Step("Fill producer in Option tab for RFQ");
			* Log.ExpectedResult("Check related row elements: indicator A-green");
			* Log.Step($"Perform Submit to {_.Mga.Name}");
			* Log.ExpectedResult("Check quote document on IPFS content");
	* Method: JohnsonAndJohnsonRtbAndBind
		* TestCaseLink: "JJBind-01 - https://docs.google.com/spreadsheets/d/1eXCA9EdBGQEhWMuZLWFw67XtvUpewAUx1pHOPzW5xf8/edit#gid=0"
		* Categories: Categories.Clients.External.JohnsonAndJohnsonFlood, Categories.ExcludingCategoryOnlyTestingSites
			* Log.Step("Create Rfq Personal Flood line and choose J&J market");
			* Log.Step("Fill questionnaire to green A indicator");
			* Log.Step("Submit to J&J market - call generation 3 quote document");
			* Log.Step("Click on Rtb button - perform switch to external portal page with custom Uri");
			* Log.ExpectedResult("Uri parameters (quoteExtId, agencyCode, appulateAgencyId) are correct after Rtb action");
			* Log.ExpectedResult("Check statuses and existing buttons");
			* Log.ExpectedResult("Uri parameters (quoteExtId, agencyCode, appulateAgencyId) are correct after External link click");
			* Log.Step("Performe external bind use api method");
			* Log.ExpectedResult("Check Quote bound in appulate use api method");
	* Method: LibertyMutualCarrierApiBopWorkflow
		* TestCaseLink: "LibertyM-BOP-QG-01 : https://docs.google.com/spreadsheets/d/1QDyo_LLN6KJ0Viqehd36LsBhGkNl4BTcPvRLJbkyrGY/edit#gid=0&range=A2:A4"
		* Categories: Categories.Clients.External.LibertyMutual, Categories.ExcludingCategoryOnlyTestingSites
			* Log.Step("Create RFQ BOP-line on Agency side");
			* Log.Step("Select Market on Markets Selector");
			* Log.Step("Fill in questionnaire to A-indicator");
			* Log.ExpectedResult("Check related row elements: indicator A-green");
			* Log.Step($"Perform Submit to {_.CarrierN(1).Name}");
			* Log.ExpectedResult("Check quotes count on agency side: 1");
			* Log.ExpectedResult("Check related row elements: indicator, premium");
			* Log.ExpectedResult("Check related row elements on Agency side: indicator A-green");
			* Log.ExpectedResult($"Check correct quote name on {_.CarrierN(1).Name}");
			* Log.ExpectedResult($"Check related row elements on {_.CarrierN(1).Name} side: indicator A-green");
	* Method: LibertyMutualWithMgaApiBopWorkflow
		* TestCaseLink: "LibertyM-BOP-QG-02: https://docs.google.com/spreadsheets/d/1QDyo_LLN6KJ0Viqehd36LsBhGkNl4BTcPvRLJbkyrGY/edit#gid=0&range=A5:A10"
		* Categories: Categories.Clients.External.LibertyMutual, Categories.ExcludingCategoryOnlyTestingSites
			* Log.Step("Create RFQ BOP-line on Agency side");
			* Log.Step("Select Market and submarket on Markets Selector");
			* Log.Step("Fill in questionnaire to A-indicator");
			* Log.ExpectedResult("Check related row elements: indicator A-green");
			* Log.Step($"Perform Submit to {_.Mga.Name} => perform request quote from external service");
			* Log.ExpectedResult($"Correct indicator (A-green) displayed for '{_.CarrierN(1)}' on MS");
			* Log.ExpectedResult("Rtb button displayed for quote");
			* Log.ExpectedResult("Check quotes count on agency side and quote premium displayed on MS");
			* Log.ExpectedResult($"Quotes count on {_.Mga.Name} side: 1");
			* Log.ExpectedResult($"Quote document displayed with 'Released' status on {_.Mga.Name} side");
			* Log.ExpectedResult($"'Mark as Bound' button displayed on {_.Mga.Name} side for quote");
			* Log.ExpectedResult($"Related row elements on {_.Mga.Name} side: indicator A-green");
			* Log.Step($"Perform Submit from {_.Mga.Name} to {_.CarrierN(1)} => perform request quote from external service");
			* Log.ExpectedResult($"Check quotes count on {_.Mga.Name} side: 2");
			* Log.ExpectedResult("Check quotes document: positive premium, GenerateQuote button is available");
			* Log.ExpectedResult($"Check correct log in Activity Log on {_.Mga.Name} side");
	* Method: MackinawUnderwritersLiquorLiability
		* TestCaseLink: "MULLR-01 : https://docs.google.com/spreadsheets/d/1mz9biHlVl3OMkSw1gM999reCRe8AaJkoLvVgd9H1fFk/edit#gid=0"
		* Categories: Categories.Clients.External.MackinawUnderwritersLiquorLiability, Categories.ExcludingCategoryOnlyTestingSites
			* Log.Step("Create  LL rfq on agency side, check MackinawUnderwriters market");
			* Log.Step("Fill questions for not calculated premium");
			* Log.Step("Add question to made premium calculable");
			* Log.ExpectedResult("Premium must be calculated");
			* Log.Step("Change limits. Check that premium was recalculated in different way");
			* Log.ExpectedResult("Premium have to changed compare to before");
			* Log.Step("Add location. Check that premium was recalculated in different way");
			* Log.ExpectedResult("Premium have to changed after adding location");
			* Log.Step("Submiting to Mackinaw (eSubmission)");
	* Method: MarkAsSubmittedForEmailMarket
		* TestCaseLink: "SW_5 - https://docs.google.com/spreadsheets/d/1Ry3oV4Uy12Zam26xfVf4Jfp7JANGwzLr5UOD1o3Cqp0/edit#gid=83694423&range=A42:A47"
		* Categories: [UNDEFINED]
	* Method: MessageWithSuggestionToAgentToTryOtherCoveragesInQpdDisplayed
		* TestCaseLink: "Bro-QPD7: https://docs.google.com/spreadsheets/d/1jBGIks6RAdLiDkkpQuthKhhCCvZu5KjPoSfyISvvWas/edit#gid=503873439&range=80:81"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites, Categories.BrooksideGeneral
			* Log.Step($"Log in as an agency user, create an insured and a '{insuranceLine.GetDescription()}' RFQ");
			* Log.Step($"Select '{brookside}' market and '{sutter}' submarket on market selector");
			* Log.Step("Open QP dialog");
			* Log.Step("Select insurance program");
			* Log.Step("Close QP dialog");
			* Log.Step("Provoke red D indicator by answering 'Number of years with prior insurance in own name' question");
			* Log.Step("Hover to Admission indicator");
			* Log.ExpectedResult($"'{expectedMessage}' is displayed under '{tooltipHeader}' header in Admission indicator tooltip");
	* Method: MtcLineQuoteParametersDialogForLloydsMarketVerification
		* TestCaseLink: "Bro-QPD5: https://docs.google.com/spreadsheets/d/1jBGIks6RAdLiDkkpQuthKhhCCvZu5KjPoSfyISvvWas/edit#gid=503873439&range=A62:A71"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites, Categories.BrooksideGeneral
			* Log.Step("Log in as an agency user, create an insured and a MTC RFQ and select MGA + Carrier");
			* Log.ExpectedResult("Check QPD required questions count, tooltip message, admission tooltip message and limits and deds values");
			* Log.Step("Open QPD and check Limits & Deductibles tab");
			* Log.Step("Select limit value");
			* Log.ExpectedResult("Check QPD required questions count and available deductible values");
			* Log.Step("Select deductible value");
			* Log.ExpectedResult("Check QPD required questions count");
			* Log.Step("Answer the required question");
			* Log.ExpectedResult("Check that there are no required questions on the QPD");
			* Log.Step("Close QP dialog");
			* Log.ExpectedResult("QPD icon doesn't have required questions count, limits and deductibles are filled with chosen values");
	* Method: QuotePresenceOnlyUnderEmployers
		* TestCaseLink: "EmplWC-QG-03: https://docs.google.com/spreadsheets/d/1HVgn0_neywJu6he_KTe6v6xbpYkKARle26XwTZXMU-k/edit#gid=0&range=A23:A25"
		* Categories: Categories.ExcludingCategoryOnlyTestingSites, Categories.Clients.External.EmployersWc
			* Log.Step("Create RFQ on Agency side. Choose Employers Testing and Volta + Employers Testing from MS.");
			* Log.ExpectedResult("Admission indicator orange A for Employers Testing root, orange U for Volta Insurance Testing");
			* Log.Step("Fill in questionnaire and limits");
			* Log.ExpectedResult("Admission indicator green A for Employers Testing root, green U for Volta Insurance Testing");
			* Log.Step("Submit RFQ to Employers Testing");
			* Log.ExpectedResult("Quote is returned only for Employers Testing root market. Admission indicators are correct");
	* Method: RliVoltaBopWorkflowTest
		* TestCaseLink: "VolRliBop-QG-01 : https://docs.google.com/spreadsheets/d/1E1J2CSzUmO1r6n83Q40M7ieOoM2FbT1ypjLyLopcghw/edit#gid=0"
		* Categories: Categories.Clients.External.RliInsuranceCompanyBop, Categories.ExcludingCategoryOnlyTestingSites
			* Log.Step("Create RFQ BOP-line on Agency side");
			* Log.Step($"Select Mga '{_.Mga.Name}' and his carrier'{_.CarrierN(1).Name}' on Markets Selector");
			* Log.Step("Fill in questionnaire to A-indicator");
			* Log.ExpectedResult("Check related row elements: indicator");
			* Log.Step($"Perform Submit to {_.Mga.Name}");
			* Log.ExpectedResult("Check related Quote name");
			* Log.ExpectedResult("Check related row elements: premium, indicator, buttons, statuses");
			* Log.Step("Perform request quote");
			* Log.ExpectedResult("Check related row elements: premium, indicator, statuses");
	* Method: StatusesInRfqWithComplicatedSubmissionChains
		* TestCaseLink: "MSS-001: https://docs.google.com/spreadsheets/d/1_t9MLTsQsW8kwo9s3tY9xxvWko95sbfUvsYnFGVJ1dw/edit#gid=1629920994&range=A2:A3"
		* Categories: [UNDEFINED]
			* Log.Step("Log in as an MGA user, create an insured and a GL RFQ");
			* Log.Step($"On Markets Selector select market: '{_.Mga}' with submarket: '{_.CarrierN(1)}'");
			* Log.Step($"Select also submarket: '{_.CarrierN(1)}' as a root on Markets Selector");
			* Log.Step($"Submit to market: '{_.Mga}'");
			* Log.Step($"Upload quote to submarket: '{_.CarrierN(1)}'");
			* Log.ExpectedResult("Statuses for Record, markets, submarket and quote as an expected");
			* Log.Step("Delete uploaded quote on Markets Selector");
			* Log.Step("Submit to submarket as an root market");
			* Log.Step("Upload quote to submarket (under root market)");
			* Log.ExpectedResult("Statuses for Record, markets, submarket and quote as an expected");
	* Method: SubMarketQuotedGenerationAndBind
		* TestCaseLink: "BBV-2  - https://docs.google.com/spreadsheets/d/1UJ15FxjWUXqdn_qvjn-GIabcRO4E5OgBOE6xPkeySZw/edit#gid=0&range=11:17"
		* Categories: [UNDEFINED]
	* Method: SubmitOnMarketWithAutoQuoteSubmarket
		* TestCaseLink: "qd_cc_03 - https://docs.google.com/spreadsheets/d/1XvwVbDvFAog70B0kI6V0lJl2ANZWdSKSz0mHVPR6FYM/edit#gid=0&range=A20:A25"
		* Categories: [UNDEFINED]
			* Log.ExpectedResult("Check generated quotes after submits");
	* Method: TryReleaseWithNotAssignedAgency
		* TestCaseLink: "QRA_01 - https://docs.google.com/spreadsheets/d/1DR6yo2ge_fhZ-PfcuKD6nkKu9lmJ0VrFK279OBf17WY/edit#gid=0&range=A2:A4"
		* Categories: [UNDEFINED]
	* Method: UploadQuoteOnSubmarket
		* TestCaseLink: "BBV-1 .. BBV-3 - https://docs.google.com/spreadsheets/d/1UJ15FxjWUXqdn_qvjn-GIabcRO4E5OgBOE6xPkeySZw/edit#gid=0"
		* Categories: [UNDEFINED]
