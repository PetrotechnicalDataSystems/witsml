//----------------------------------------------------------------------- 
// PDS WITSMLstudio Store, 2017.2
//
// Copyright 2017 PDS Americas LLC
// 
// Licensed under the PDS Open Source WITSML Product License Agreement (the
// "License"); you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   
//     http://www.pds.group/WITSMLstudio/OpenSource/ProductLicenseAgreement
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//-----------------------------------------------------------------------

// ----------------------------------------------------------------------
// <auto-generated>
//     Changes to this file may cause incorrect behavior and will be lost
//     if the code is regenerated.
// </auto-generated>
// ----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using Energistics.DataAccess;
using Energistics.DataAccess.WITSML141;
using Energistics.DataAccess.WITSML141.ComponentSchemas;
using Energistics.DataAccess.WITSML141.ReferenceData;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PDS.WITSMLstudio.Store.Data.ToolErrorModels
{
    [TestClass]
    public partial class ToolErrorModel141ValidatorTests : ToolErrorModel141TestBase
    {

        #region Error -401

        public static readonly string QueryInvalidPluralRoot =
            "<toolErrorModel xmlns=\"http://www.witsml.org/schemas/1series\" version=\"1.4.1.1\">" + Environment.NewLine +
            "  <toolErrorModel>" + Environment.NewLine +
            "    <name>Test Plural Root Element</name>" + Environment.NewLine +
            "  </toolErrorModel>" + Environment.NewLine +
            "</toolErrorModel>";

        [TestMethod]
        public void ToolErrorModel141Validator_GetFromStore_Error_401_No_Plural_Root_Element()
        {
            var response = DevKit.GetFromStore(ObjectTypes.ToolErrorModel, QueryInvalidPluralRoot, null, null);
            Assert.AreEqual((short)ErrorCodes.MissingPluralRootElement, response.Result);
        }

        [TestMethod]
        public void ToolErrorModel141Validator_AddToStore_Error_401_No_Plural_Root_Element()
        {
            var response = DevKit.AddToStore(ObjectTypes.ToolErrorModel, QueryInvalidPluralRoot, null, null);
            Assert.AreEqual((short)ErrorCodes.MissingPluralRootElement, response?.Result);
        }

        [TestMethod]
        public void ToolErrorModel141Validator_UpdateInStore_Error_401_No_Plural_Root_Element()
        {
            var response = DevKit.UpdateInStore(ObjectTypes.ToolErrorModel, QueryInvalidPluralRoot, null, null);
            Assert.AreEqual((short)ErrorCodes.MissingPluralRootElement, response?.Result);
        }

        [TestMethod]
        public void ToolErrorModel141Validator_DeleteFromStore_Error_401_No_Plural_Root_Element()
        {
            var response = DevKit.DeleteFromStore(ObjectTypes.ToolErrorModel, QueryInvalidPluralRoot, null, null);
            Assert.AreEqual((short)ErrorCodes.MissingPluralRootElement, response?.Result);
        }

        #endregion Error -401

        #region Error -402

        #endregion Error -402

        #region Error -403

        [TestMethod]
        public void ToolErrorModel141Validator_GetFromStore_Error_403_RequestObjectSelectionCapability_True_MissingNamespace()
        {
            var response = DevKit.GetFromStore(ObjectTypes.ToolErrorModel, QueryMissingNamespace, null, optionsIn: OptionsIn.RequestObjectSelectionCapability.True);
            Assert.AreEqual((short)ErrorCodes.MissingDefaultWitsmlNamespace, response.Result);
        }

        [TestMethod]
        public void ToolErrorModel141Validator_GetFromStore_Error_403_RequestObjectSelectionCapability_True_BadNamespace()
        {
            var response = DevKit.GetFromStore(ObjectTypes.ToolErrorModel, QueryInvalidNamespace, null, optionsIn: OptionsIn.RequestObjectSelectionCapability.True);
            Assert.AreEqual((short)ErrorCodes.MissingDefaultWitsmlNamespace, response.Result);
        }

        [TestMethod]
        public void ToolErrorModel141Validator_GetFromStore_Error_403_RequestObjectSelectionCapability_None_BadNamespace()
        {
            var response = DevKit.GetFromStore(ObjectTypes.ToolErrorModel, QueryInvalidNamespace, null, optionsIn: OptionsIn.RequestObjectSelectionCapability.None);
            Assert.AreEqual((short)ErrorCodes.MissingDefaultWitsmlNamespace, response.Result);
        }

        #endregion Error -403

        #region Error -405

        [TestMethod]
        public void ToolErrorModel141Validator_AddToStore_Error_405_ToolErrorModel_Already_Exists()
        {
            AddParents();
            DevKit.AddAndAssert<ToolErrorModelList, ToolErrorModel>(ToolErrorModel);
            DevKit.AddAndAssert<ToolErrorModelList, ToolErrorModel>(ToolErrorModel, ErrorCodes.DataObjectUidAlreadyExists);
        }

        #endregion Error -405

        #region Error -407

        [TestMethod]
        public void ToolErrorModel141Validator_UpdateInStore_Error_407_ToolErrorModel_Missing_Witsml_Object_Type()
        {
            AddParents();
            DevKit.AddAndAssert<ToolErrorModelList, ToolErrorModel>(ToolErrorModel);
            var response = DevKit.Update<ToolErrorModelList, ToolErrorModel>(ToolErrorModel, string.Empty);
            Assert.IsNotNull(response);
            Assert.AreEqual((short)ErrorCodes.MissingWmlTypeIn, response.Result);
        }

        #endregion Error -407

        #region Error -408

        [TestMethod]
        public void ToolErrorModel141Validator_UpdateInStore_Error_408_ToolErrorModel_Empty_QueryIn()
        {
            var response = DevKit.UpdateInStore(ObjectTypes.ToolErrorModel, string.Empty, null, null);
            Assert.IsNotNull(response);
            Assert.AreEqual((short)ErrorCodes.MissingInputTemplate, response.Result);
        }

        #endregion Error -408

        #region Error -409

        [TestMethod]
        public void ToolErrorModel141Validator_UpdateInStore_Error_409_ToolErrorModel_QueryIn_Must_Conform_To_Schema()
        {
            AddParents();
            DevKit.AddAndAssert<ToolErrorModelList, ToolErrorModel>(ToolErrorModel);

            var nonConformingXml = string.Format(BasicXMLTemplate, ToolErrorModel.Uid,

                $"<name>{ToolErrorModel.Name}</name><name>{ToolErrorModel.Name}</name>");

            var response = DevKit.UpdateInStore(ObjectTypes.ToolErrorModel, nonConformingXml, null, null);
            Assert.AreEqual((short)ErrorCodes.InputTemplateNonConforming, response.Result);
        }

        #endregion Error -409

        #region Error -415

        [TestMethod]
        public void ToolErrorModel141Validator_UpdateInStore_Error_415_ToolErrorModel_Update_Without_Specifing_UID()
        {
            AddParents();
            DevKit.AddAndAssert<ToolErrorModelList, ToolErrorModel>(ToolErrorModel);
            ToolErrorModel.Uid = string.Empty;
            DevKit.UpdateAndAssert<ToolErrorModelList, ToolErrorModel>(ToolErrorModel, ErrorCodes.DataObjectUidMissing);
        }

        #endregion Error -415

        #region Error -416

        [TestMethod]
        public void ToolErrorModel141Validator_DeleteFromStore_Error_416_ToolErrorModel_Delete_With_Empty_UID()
        {

            var ext1 = DevKit.ExtensionNameValue("Ext-1", "1.0", "m");
            ToolErrorModel.CommonData = new CommonData
            {
                ExtensionNameValue = new List<ExtensionNameValue>
                {
                    ext1
                }
            };

            DevKit.AddAndAssert(ToolErrorModel);

            var deleteXml = string.Format(BasicXMLTemplate,ToolErrorModel.Uid,

                "<commonData><extensionNameValue uid=\"\" /></commonData>");

            var results = DevKit.DeleteFromStore(ObjectTypes.ToolErrorModel, deleteXml, null, null);

            Assert.IsNotNull(results);
            Assert.AreEqual((short)ErrorCodes.EmptyUidSpecified, results.Result);
        }

        #endregion Error -416

        #region Error -418

        [TestMethod]
        public void ToolErrorModel141Validator_DeleteFromStore_Error_418_ToolErrorModel_Delete_With_Missing_Uid()
        {

            var ext1 = DevKit.ExtensionNameValue("Ext-1", "1.0", "m");
            ToolErrorModel.CommonData = new CommonData
            {
                ExtensionNameValue = new List<ExtensionNameValue>
                {
                    ext1
                }
            };

            DevKit.AddAndAssert(ToolErrorModel);

            var deleteXml = string.Format(BasicXMLTemplate,ToolErrorModel.Uid,

                "<commonData><extensionNameValue  uid=\"\" /></commonData>");

            var results = DevKit.DeleteFromStore(ObjectTypes.ToolErrorModel, deleteXml, null, null);

            Assert.IsNotNull(results);
            Assert.AreEqual((short)ErrorCodes.EmptyUidSpecified, results.Result);
        }

        #endregion Error -418

        #region Error -419

        [TestMethod]
        public void ToolErrorModel141Validator_DeleteFromStore_Error_419_ToolErrorModel_Deleting_Empty_NonRecurring_Container_Element()
        {

            var ext1 = DevKit.ExtensionNameValue("Ext-1", "1.0", "m");
            ToolErrorModel.CommonData = new CommonData
            {
                ExtensionNameValue = new List<ExtensionNameValue>
                {
                    ext1
                }
            };

            DevKit.AddAndAssert(ToolErrorModel);

            var deleteXml = string.Format(BasicXMLTemplate,ToolErrorModel.Uid,

                "<commonData />");

            var results = DevKit.DeleteFromStore(ObjectTypes.ToolErrorModel, deleteXml, null, null);

            Assert.IsNotNull(results);
            Assert.AreEqual((short)ErrorCodes.EmptyNonRecurringElementSpecified, results.Result);
        }

        #endregion Error -419

        #region Error -420

        [TestMethod]
        public void ToolErrorModel141Validator_DeleteFromStore_Error_420_ToolErrorModel_Specifying_A_Non_Recuring_Element_That_Is_Required()
        {

            DevKit.AddAndAssert(ToolErrorModel);

            var deleteXml = string.Format(BasicXMLTemplate,ToolErrorModel.Uid,

                "<name />");
            var results = DevKit.DeleteFromStore(ObjectTypes.ToolErrorModel, deleteXml, null, null);

            Assert.IsNotNull(results);
            Assert.AreEqual((short)ErrorCodes.EmptyMandatoryNodeSpecified, results.Result);
        }

        #endregion Error -420

        #region Error -433

        [TestMethod]
        public void ToolErrorModel141Validator_UpdateInStore_Error_433_ToolErrorModel_Does_Not_Exist()
        {
            AddParents();
            DevKit.UpdateAndAssert<ToolErrorModelList, ToolErrorModel>(ToolErrorModel, ErrorCodes.DataObjectNotExist);
        }

        #endregion Error -433

        #region Error -438

        [TestMethod]
        public void ToolErrorModel141Validator_GetFromStore_Error_438_ToolErrorModel_Recurring_Elements_Have_Inconsistent_Selection()
        {

            var ext1 = DevKit.ExtensionNameValue("Ext-1", "1.0", "m");
            var ext2 = DevKit.ExtensionNameValue("Ext-2", "1.0", "m");

            ToolErrorModel.CommonData = new CommonData
            {
                ExtensionNameValue = new List<ExtensionNameValue>
                {
                    ext1, ext2
                }
            };

            DevKit.AddAndAssert(ToolErrorModel);

            var queryXml = string.Format(BasicXMLTemplate,ToolErrorModel.Uid,

                "<commonData>" +
                $"<extensionNameValue uid=\"\"><name>Ext-1</name></extensionNameValue>" +
                "<extensionNameValue uid=\"\"><value uom=\"\">1.0</value></extensionNameValue>" +
                "</commonData>");

            var results = DevKit.GetFromStore(ObjectTypes.ToolErrorModel, queryXml, null, null);

            Assert.IsNotNull(results);
            Assert.AreEqual((short)ErrorCodes.RecurringItemsInconsistentSelection, results.Result);
        }

        #endregion Error -438

        #region Error -439

        [TestMethod]
        public void ToolErrorModel141Validator_GetFromStore_Error_439_ToolErrorModel_Recurring_Elements_Has_Empty_Selection_Value()
        {

            var ext1 = DevKit.ExtensionNameValue("Ext-1", "1.0", "m");
            var ext2 = DevKit.ExtensionNameValue("Ext-2", "1.0", "m");

            ToolErrorModel.CommonData = new CommonData
            {
                ExtensionNameValue = new List<ExtensionNameValue>
                {
                    ext1, ext2
                }
            };

            DevKit.AddAndAssert(ToolErrorModel);

            var queryXml = string.Format(BasicXMLTemplate,ToolErrorModel.Uid,

                "<commonData>" +
                $"<extensionNameValue uid=\"\"><name>Ext-1</name></extensionNameValue>" +
                "<extensionNameValue uid=\"\"><name></name></extensionNameValue>" +
                "</commonData>");

            var results = DevKit.GetFromStore(ObjectTypes.ToolErrorModel, queryXml, null, null);

            Assert.IsNotNull(results);
            Assert.AreEqual((short)ErrorCodes.RecurringItemsEmptySelection, results.Result);
        }

        #endregion Error -439

        #region Error -444

        [TestMethod]
        public void ToolErrorModel141Validator_UpdateInStore_Error_444_ToolErrorModel_Updating_More_Than_One_Data_Object()
        {
            AddParents();
            DevKit.AddAndAssert<ToolErrorModelList, ToolErrorModel>(ToolErrorModel);

            var updateXml = "<toolErrorModels xmlns=\"http://www.witsml.org/schemas/1series\" version=\"1.4.1.1\"><toolErrorModel uid=\"{0}\"></toolErrorModel><toolErrorModel uid=\"{0}\"></toolErrorModel></toolErrorModels>";
            updateXml = string.Format(updateXml, ToolErrorModel.Uid);

            var response = DevKit.UpdateInStore(ObjectTypes.ToolErrorModel, updateXml, null, null);
            Assert.AreEqual((short)ErrorCodes.InputTemplateMultipleDataObjects, response.Result);
        }

        #endregion Error -444

        #region Error -445

        [TestMethod]
        public void ToolErrorModel141Validator_UpdateInStore_Error_445_ToolErrorModel_Empty_New_Element()
        {

            var ext1 = DevKit.ExtensionNameValue("Ext-1", "1.0", "m");

            ToolErrorModel.CommonData = new CommonData
            {
                ExtensionNameValue = new List<ExtensionNameValue>
                {
                    ext1
                }
            };

            DevKit.AddAndAssert(ToolErrorModel);

            ext1 = DevKit.ExtensionNameValue("Ext-1", string.Empty, string.Empty, PrimitiveType.@double, string.Empty);
            ToolErrorModel.CommonData = new CommonData
            {
                ExtensionNameValue = new List<ExtensionNameValue>
                {
                    ext1
                }
            };

            DevKit.UpdateAndAssert(ToolErrorModel, ErrorCodes.EmptyNewElementsOrAttributes);
        }

        #endregion Error -445

        #region Error -448

        [TestMethod]
        public void ToolErrorModel141Validator_UpdateInStore_Error_448_ToolErrorModel_Missing_Uid()
        {

            var ext1 = DevKit.ExtensionNameValue("Ext-1", "1.0", "m");

            ToolErrorModel.CommonData = new CommonData
            {
                ExtensionNameValue = new List<ExtensionNameValue>
                {
                    ext1
                }
            };

            DevKit.AddAndAssert(ToolErrorModel);

            var updateXml = string.Format(BasicXMLTemplate,ToolErrorModel.Uid,

                "<commonData>" +
                $"<extensionNameValue uid=\"\"><value uom=\"ft\" /></extensionNameValue>" +
                "</commonData>");

            var response = DevKit.UpdateInStore(ObjectTypes.ToolErrorModel, updateXml, null, null);
            Assert.AreEqual((short)ErrorCodes.MissingElementUidForUpdate, response.Result);
        }

        #endregion Error -448

        #region Error -464

        [TestMethod]
        public void ToolErrorModel141Validator_AddToStore_Error_464_ToolErrorModel_Uid_Not_Unique()
        {

            var ext1 = DevKit.ExtensionNameValue("Ext-1", "1.0", "m");
            var ext2 = DevKit.ExtensionNameValue("Ext-1", "1.0", "m");

            ToolErrorModel.CommonData = new CommonData
            {
                ExtensionNameValue = new List<ExtensionNameValue>
                {
                    ext1, ext2
                }
            };

            DevKit.AddAndAssert(ToolErrorModel, ErrorCodes.ChildUidNotUnique);
        }

        [TestMethod]
        public void ToolErrorModel141Validator_UpdateInStore_Error_464_ToolErrorModel_Uid_Not_Unique()
        {

            var ext1 = DevKit.ExtensionNameValue("Ext-1", "1.0", "m");

            ToolErrorModel.CommonData = new CommonData
            {
                ExtensionNameValue = new List<ExtensionNameValue>
                {
                    ext1
                }
            };

            DevKit.AddAndAssert(ToolErrorModel);

            var ext2 = DevKit.ExtensionNameValue("Ext-1", "1.0", "m");

            ToolErrorModel.CommonData = new CommonData
            {
                ExtensionNameValue = new List<ExtensionNameValue>
                {
                    ext1, ext2
                }
            };

            DevKit.UpdateAndAssert(ToolErrorModel, ErrorCodes.ChildUidNotUnique);
        }

        #endregion Error -464

        #region Error -468

        [TestMethod]
        public void ToolErrorModel141Validator_UpdateInStore_Error_468_ToolErrorModel_No_Schema_Version_Declared()
        {

            DevKit.AddAndAssert<ToolErrorModelList, ToolErrorModel>(ToolErrorModel);
            var response = DevKit.UpdateInStore(ObjectTypes.ToolErrorModel, QueryMissingVersion, null, null);
            Assert.AreEqual((short)ErrorCodes.MissingDataSchemaVersion, response.Result);
        }

        #endregion Error -468

        #region Error -483

        [TestMethod]
        public void ToolErrorModel141Validator_UpdateInStore_Error_483_ToolErrorModel_Update_With_Non_Conforming_Template()
        {
            AddParents();
            DevKit.AddAndAssert<ToolErrorModelList, ToolErrorModel>(ToolErrorModel);
            var response = DevKit.UpdateInStore(ObjectTypes.ToolErrorModel, QueryEmptyRoot, null, null);
            Assert.AreEqual((short)ErrorCodes.UpdateTemplateNonConforming, response.Result);
        }

        #endregion Error -483

        #region Error -484

        [TestMethod]
        public void ToolErrorModel141Validator_UpdateInStore_Error_484_ToolErrorModel_Update_Will_Delete_Required_Element()
        {

            DevKit.AddAndAssert<ToolErrorModelList, ToolErrorModel>(ToolErrorModel);

            var nonConformingXml = string.Format(BasicXMLTemplate, ToolErrorModel.Uid,

                $"<name></name>");

            var response = DevKit.UpdateInStore(ObjectTypes.ToolErrorModel, nonConformingXml, null, null);
            Assert.AreEqual((short)ErrorCodes.MissingRequiredData, response.Result);
        }

        #endregion Error -484

        #region Error -486

        [TestMethod]
        public void ToolErrorModel141Validator_AddToStore_Error_486_ToolErrorModel_Data_Object_Types_Dont_Match()
        {

            var xmlIn = string.Format(BasicXMLTemplate, ToolErrorModel.Uid,

                string.Empty);

            var response = DevKit.AddToStore(ObjectTypes.Wellbore, xmlIn, null, null);

            Assert.AreEqual((short)ErrorCodes.DataObjectTypesDontMatch, response.Result);
        }

        #endregion Error -486

    }
}