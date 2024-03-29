﻿using System.Collections.Generic;

namespace LambdaQuipToS3Exporter
{
    public class AppSettings
    {
        public string QuipApiToken { get; set; }
        public string S3BucketOutput { get; set; }
        public IEnumerable<string> DocumentIds { get; set; }
        public IEnumerable<string> DocumentOutputPaths { get; set; }
        public string PrependText { get; set; }
        public string AppendText { get; set; }
        public bool OutputQuipEditLink { get; set; }
        public string QuipDomainOverride { get; set; }
        public string QuipDomain { get { return QuipDomainOverride ?? "quip.com"; } }
    }
}
