﻿using FikaAmazonAPI.Parameter.Report;
using FikaAmazonAPI.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static FikaAmazonAPI.Utils.Constants;

namespace FikaAmazonAPI.Sample
{
    public class ReportsSample
    {
        AmazonConnection amazonConnection;
        public ReportsSample(AmazonConnection amazonConnection)
        {
            this.amazonConnection = amazonConnection;
        }


        
        public void GetReports()
        {
            var parameters = new ParameterReportList();
            parameters.pageSize = 100;
            parameters.reportTypes = new List<ReportTypes>();
            parameters.reportTypes.Add(ReportTypes.GET_AFN_INVENTORY_DATA);
            parameters.marketplaceIds = new List<string>();
            parameters.marketplaceIds.Add(MarketPlace.UnitedArabEmirates.ID);
            amazonConnection.Reports.GetReports(parameters);
        }

        
        public void CreateReport()
        {

            var parameters = new ParameterCreateReportSpecification();
            parameters.reportType = ReportTypes.GET_FLAT_FILE_ALL_ORDERS_DATA_BY_LAST_UPDATE_GENERAL;
            parameters.dataStartTime = DateTime.UtcNow.AddDays(-30);
            parameters.dataEndTime = DateTime.UtcNow.AddDays(-10);

            parameters.marketplaceIds = new MarketplaceIds();
            parameters.marketplaceIds.Add(MarketPlace.UnitedArabEmirates.ID);

            parameters.reportOptions = new AmazonSpApiSDK.Models.Reports.ReportOptions();

            var reportId = amazonConnection.Reports.CreateReport(parameters);
        }

        
        public void GetReport()
        {

            amazonConnection.Reports.GetReport("192841018867");
        }

        
        public void CancelReport()
        {

            amazonConnection.Reports.CancelReport("192841018867");
        }

        
        public void GetReportSchedules()
        {

            var parameters = new ParameterReportSchedules();
            parameters.reportTypes.Add(ReportTypes.GET_FLAT_FILE_ALL_ORDERS_DATA_BY_LAST_UPDATE_GENERAL);

            var result = amazonConnection.Reports.GetReportSchedules(parameters);
        }


        public void CreateReportScheduleSpecification()
        {

            var parameters = new ParameterCreateReportScheduleSpecification();
            parameters.reportType = ReportTypes.GET_AFN_INVENTORY_DATA;
            parameters.period = FikaAmazonAPI.AmazonSpApiSDK.Models.Reports.CreateReportScheduleSpecification.PeriodEnum.PT30M;

            parameters.marketplaceIds = new MarketplaceIds();
            parameters.marketplaceIds.Add(MarketPlace.UnitedArabEmirates.ID);

            parameters.reportOptions = new AmazonSpApiSDK.Models.Reports.ReportOptions();

            var result = amazonConnection.Reports.CreateReportSchedule(parameters);


        }


        public void GetReportSchedule()
        {

            var data = amazonConnection.Reports.GetReportSchedule("50039018867");


        }

        public void CancelReportSchedule()
        {

            var data = amazonConnection.Reports.CancelReportSchedule("50039018867");


        }

        public void GetReportDocument()
        {

            var data = amazonConnection.Reports.GetReportDocument("50039018867");

        }

        public string CreateReport_GET_MERCHANT_LISTINGS_ALL_DATA()
        {

            var parameters = new ParameterCreateReportSpecification();
            parameters.reportType = ReportTypes.GET_MERCHANT_LISTINGS_ALL_DATA;

            parameters.marketplaceIds = new MarketplaceIds();
            parameters.marketplaceIds.Add(MarketPlace.UnitedArabEmirates.ID);

            parameters.reportOptions = new FikaAmazonAPI.AmazonSpApiSDK.Models.Reports.ReportOptions();

            var reportId = amazonConnection.Reports.CreateReport(parameters);
            var filePath = string.Empty;
            string ReportDocumentId = string.Empty;

            while (string.IsNullOrEmpty(ReportDocumentId))
            {
                var reportData = amazonConnection.Reports.GetReport(reportId);
                if (!string.IsNullOrEmpty(reportData.ReportDocumentId))
                {
                    filePath = amazonConnection.Reports.GetReportFile(reportData.ReportDocumentId);
                    break;
                }
                else Thread.Sleep(1000 * 60);
            }

            return filePath;
        }


        public void GetReportFile()
        {

            var data = amazonConnection.Reports.GetReport("192841018867");


            var filePath = amazonConnection.Reports.GetReportFile(data.ReportDocumentId);

        }
    }
}
