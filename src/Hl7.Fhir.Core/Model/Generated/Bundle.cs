﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;
using System.ComponentModel;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/

//
// Generated for FHIR v1.5.0
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// Contains a collection of resources
    /// </summary>
    [FhirType("Bundle", IsResource=true)]
    [DataContract]
    public partial class Bundle : Hl7.Fhir.Model.Resource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Bundle; } }
        [NotMapped]
        public override string TypeName { get { return "Bundle"; } }
        
        /// <summary>
        /// Indicates the purpose of a bundle - how it was intended to be used.
        /// (url: http://hl7.org/fhir/ValueSet/bundle-type)
        /// </summary>
        [FhirEnumeration("BundleType")]
        public enum BundleType
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/bundle-type)
            /// </summary>
            [EnumLiteral("document"), Description("Document")]
            Document,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/bundle-type)
            /// </summary>
            [EnumLiteral("message"), Description("Message")]
            Message,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/bundle-type)
            /// </summary>
            [EnumLiteral("transaction"), Description("Transaction")]
            Transaction,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/bundle-type)
            /// </summary>
            [EnumLiteral("transaction-response"), Description("Transaction Response")]
            TransactionResponse,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/bundle-type)
            /// </summary>
            [EnumLiteral("batch"), Description("Batch")]
            Batch,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/bundle-type)
            /// </summary>
            [EnumLiteral("batch-response"), Description("Batch Response")]
            BatchResponse,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/bundle-type)
            /// </summary>
            [EnumLiteral("history"), Description("History List")]
            History,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/bundle-type)
            /// </summary>
            [EnumLiteral("searchset"), Description("Search Results")]
            Searchset,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/bundle-type)
            /// </summary>
            [EnumLiteral("collection"), Description("Collection")]
            Collection,
        }

        /// <summary>
        /// Why an entry is in the result set - whether it's included as a match or because of an _include requirement.
        /// (url: http://hl7.org/fhir/ValueSet/search-entry-mode)
        /// </summary>
        [FhirEnumeration("SearchEntryMode")]
        public enum SearchEntryMode
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/search-entry-mode)
            /// </summary>
            [EnumLiteral("match"), Description("Match")]
            Match,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/search-entry-mode)
            /// </summary>
            [EnumLiteral("include"), Description("Include")]
            Include,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/search-entry-mode)
            /// </summary>
            [EnumLiteral("outcome"), Description("Outcome")]
            Outcome,
        }

        /// <summary>
        /// HTTP verbs (in the HTTP command line).
        /// (url: http://hl7.org/fhir/ValueSet/http-verb)
        /// </summary>
        [FhirEnumeration("HTTPVerb")]
        public enum HTTPVerb
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/http-verb)
            /// </summary>
            [EnumLiteral("GET"), Description("GET")]
            GET,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/http-verb)
            /// </summary>
            [EnumLiteral("POST"), Description("POST")]
            POST,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/http-verb)
            /// </summary>
            [EnumLiteral("PUT"), Description("PUT")]
            PUT,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/http-verb)
            /// </summary>
            [EnumLiteral("DELETE"), Description("DELETE")]
            DELETE,
        }

        [FhirType("LinkComponent")]
        [DataContract]
        public partial class LinkComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "LinkComponent"; } }
            
            /// <summary>
            /// http://www.iana.org/assignments/link-relations/link-relations.xhtml
            /// </summary>
            [FhirElement("relation", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString RelationElement
            {
                get { return _RelationElement; }
                set { _RelationElement = value; OnPropertyChanged("RelationElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _RelationElement;
            
            /// <summary>
            /// http://www.iana.org/assignments/link-relations/link-relations.xhtml
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Relation
            {
                get { return RelationElement != null ? RelationElement.Value : null; }
                set
                {
                    if(value == null)
                      RelationElement = null; 
                    else
                      RelationElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Relation");
                }
            }
            
            /// <summary>
            /// Reference details for the link
            /// </summary>
            [FhirElement("url", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirUri UrlElement
            {
                get { return _UrlElement; }
                set { _UrlElement = value; OnPropertyChanged("UrlElement"); }
            }
            
            private Hl7.Fhir.Model.FhirUri _UrlElement;
            
            /// <summary>
            /// Reference details for the link
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Url
            {
                get { return UrlElement != null ? UrlElement.Value : null; }
                set
                {
                    if(value == null)
                      UrlElement = null; 
                    else
                      UrlElement = new Hl7.Fhir.Model.FhirUri(value);
                    OnPropertyChanged("Url");
                }
            }
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as LinkComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(RelationElement != null) dest.RelationElement = (Hl7.Fhir.Model.FhirString)RelationElement.DeepCopy();
                    if(UrlElement != null) dest.UrlElement = (Hl7.Fhir.Model.FhirUri)UrlElement.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new LinkComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as LinkComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(RelationElement, otherT.RelationElement)) return false;
                if( !DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as LinkComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(RelationElement, otherT.RelationElement)) return false;
                if( !DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("EntryComponent")]
        [DataContract]
        public partial class EntryComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "EntryComponent"; } }
            
            /// <summary>
            /// Links related to this entry
            /// </summary>
            [FhirElement("link", InSummary=true, Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.Bundle.LinkComponent> Link
            {
                get { if(_Link==null) _Link = new List<Hl7.Fhir.Model.Bundle.LinkComponent>(); return _Link; }
                set { _Link = value; OnPropertyChanged("Link"); }
            }
            
            private List<Hl7.Fhir.Model.Bundle.LinkComponent> _Link;
            
            /// <summary>
            /// Absolute URL for resource (server address, or UUID/OID)
            /// </summary>
            [FhirElement("fullUrl", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirUri FullUrlElement
            {
                get { return _FullUrlElement; }
                set { _FullUrlElement = value; OnPropertyChanged("FullUrlElement"); }
            }
            
            private Hl7.Fhir.Model.FhirUri _FullUrlElement;
            
            /// <summary>
            /// Absolute URL for resource (server address, or UUID/OID)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string FullUrl
            {
                get { return FullUrlElement != null ? FullUrlElement.Value : null; }
                set
                {
                    if(value == null)
                      FullUrlElement = null; 
                    else
                      FullUrlElement = new Hl7.Fhir.Model.FhirUri(value);
                    OnPropertyChanged("FullUrl");
                }
            }
            
            /// <summary>
            /// A resource in the bundle
            /// </summary>
            [FhirElement("resource", InSummary=true, Order=60, Choice=ChoiceType.ResourceChoice)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.Resource))]
            [DataMember]
            public Hl7.Fhir.Model.Resource Resource
            {
                get { return _Resource; }
                set { _Resource = value; OnPropertyChanged("Resource"); }
            }
            
            private Hl7.Fhir.Model.Resource _Resource;
            
            /// <summary>
            /// Search related information
            /// </summary>
            [FhirElement("search", InSummary=true, Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.Bundle.SearchComponent Search
            {
                get { return _Search; }
                set { _Search = value; OnPropertyChanged("Search"); }
            }
            
            private Hl7.Fhir.Model.Bundle.SearchComponent _Search;
            
            /// <summary>
            /// Transaction Related Information
            /// </summary>
            [FhirElement("request", InSummary=true, Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.Bundle.RequestComponent Request
            {
                get { return _Request; }
                set { _Request = value; OnPropertyChanged("Request"); }
            }
            
            private Hl7.Fhir.Model.Bundle.RequestComponent _Request;
            
            /// <summary>
            /// Transaction Related Information
            /// </summary>
            [FhirElement("response", InSummary=true, Order=90)]
            [DataMember]
            public Hl7.Fhir.Model.Bundle.ResponseComponent Response
            {
                get { return _Response; }
                set { _Response = value; OnPropertyChanged("Response"); }
            }
            
            private Hl7.Fhir.Model.Bundle.ResponseComponent _Response;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as EntryComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Link != null) dest.Link = new List<Hl7.Fhir.Model.Bundle.LinkComponent>(Link.DeepCopy());
                    if(FullUrlElement != null) dest.FullUrlElement = (Hl7.Fhir.Model.FhirUri)FullUrlElement.DeepCopy();
                    if(Resource != null) dest.Resource = (Hl7.Fhir.Model.Resource)Resource.DeepCopy();
                    if(Search != null) dest.Search = (Hl7.Fhir.Model.Bundle.SearchComponent)Search.DeepCopy();
                    if(Request != null) dest.Request = (Hl7.Fhir.Model.Bundle.RequestComponent)Request.DeepCopy();
                    if(Response != null) dest.Response = (Hl7.Fhir.Model.Bundle.ResponseComponent)Response.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new EntryComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as EntryComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Link, otherT.Link)) return false;
                if( !DeepComparable.Matches(FullUrlElement, otherT.FullUrlElement)) return false;
                if( !DeepComparable.Matches(Resource, otherT.Resource)) return false;
                if( !DeepComparable.Matches(Search, otherT.Search)) return false;
                if( !DeepComparable.Matches(Request, otherT.Request)) return false;
                if( !DeepComparable.Matches(Response, otherT.Response)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as EntryComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Link, otherT.Link)) return false;
                if( !DeepComparable.IsExactly(FullUrlElement, otherT.FullUrlElement)) return false;
                if( !DeepComparable.IsExactly(Resource, otherT.Resource)) return false;
                if( !DeepComparable.IsExactly(Search, otherT.Search)) return false;
                if( !DeepComparable.IsExactly(Request, otherT.Request)) return false;
                if( !DeepComparable.IsExactly(Response, otherT.Response)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("SearchComponent")]
        [DataContract]
        public partial class SearchComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "SearchComponent"; } }
            
            /// <summary>
            /// match | include | outcome - why this is in the result set
            /// </summary>
            [FhirElement("mode", InSummary=true, Order=40)]
            [DataMember]
            public Code<Hl7.Fhir.Model.Bundle.SearchEntryMode> ModeElement
            {
                get { return _ModeElement; }
                set { _ModeElement = value; OnPropertyChanged("ModeElement"); }
            }
            
            private Code<Hl7.Fhir.Model.Bundle.SearchEntryMode> _ModeElement;
            
            /// <summary>
            /// match | include | outcome - why this is in the result set
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public Hl7.Fhir.Model.Bundle.SearchEntryMode? Mode
            {
                get { return ModeElement != null ? ModeElement.Value : null; }
                set
                {
                    if(value == null)
                      ModeElement = null; 
                    else
                      ModeElement = new Code<Hl7.Fhir.Model.Bundle.SearchEntryMode>(value);
                    OnPropertyChanged("Mode");
                }
            }
            
            /// <summary>
            /// Search ranking (between 0 and 1)
            /// </summary>
            [FhirElement("score", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirDecimal ScoreElement
            {
                get { return _ScoreElement; }
                set { _ScoreElement = value; OnPropertyChanged("ScoreElement"); }
            }
            
            private Hl7.Fhir.Model.FhirDecimal _ScoreElement;
            
            /// <summary>
            /// Search ranking (between 0 and 1)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public decimal? Score
            {
                get { return ScoreElement != null ? ScoreElement.Value : null; }
                set
                {
                    if(value == null)
                      ScoreElement = null; 
                    else
                      ScoreElement = new Hl7.Fhir.Model.FhirDecimal(value);
                    OnPropertyChanged("Score");
                }
            }
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SearchComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(ModeElement != null) dest.ModeElement = (Code<Hl7.Fhir.Model.Bundle.SearchEntryMode>)ModeElement.DeepCopy();
                    if(ScoreElement != null) dest.ScoreElement = (Hl7.Fhir.Model.FhirDecimal)ScoreElement.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new SearchComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SearchComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(ModeElement, otherT.ModeElement)) return false;
                if( !DeepComparable.Matches(ScoreElement, otherT.ScoreElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SearchComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(ModeElement, otherT.ModeElement)) return false;
                if( !DeepComparable.IsExactly(ScoreElement, otherT.ScoreElement)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("RequestComponent")]
        [DataContract]
        public partial class RequestComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "RequestComponent"; } }
            
            /// <summary>
            /// GET | POST | PUT | DELETE
            /// </summary>
            [FhirElement("method", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<Hl7.Fhir.Model.Bundle.HTTPVerb> MethodElement
            {
                get { return _MethodElement; }
                set { _MethodElement = value; OnPropertyChanged("MethodElement"); }
            }
            
            private Code<Hl7.Fhir.Model.Bundle.HTTPVerb> _MethodElement;
            
            /// <summary>
            /// GET | POST | PUT | DELETE
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public Hl7.Fhir.Model.Bundle.HTTPVerb? Method
            {
                get { return MethodElement != null ? MethodElement.Value : null; }
                set
                {
                    if(value == null)
                      MethodElement = null; 
                    else
                      MethodElement = new Code<Hl7.Fhir.Model.Bundle.HTTPVerb>(value);
                    OnPropertyChanged("Method");
                }
            }
            
            /// <summary>
            /// URL for HTTP equivalent of this entry
            /// </summary>
            [FhirElement("url", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirUri UrlElement
            {
                get { return _UrlElement; }
                set { _UrlElement = value; OnPropertyChanged("UrlElement"); }
            }
            
            private Hl7.Fhir.Model.FhirUri _UrlElement;
            
            /// <summary>
            /// URL for HTTP equivalent of this entry
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Url
            {
                get { return UrlElement != null ? UrlElement.Value : null; }
                set
                {
                    if(value == null)
                      UrlElement = null; 
                    else
                      UrlElement = new Hl7.Fhir.Model.FhirUri(value);
                    OnPropertyChanged("Url");
                }
            }
            
            /// <summary>
            /// For managing cache currency
            /// </summary>
            [FhirElement("ifNoneMatch", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString IfNoneMatchElement
            {
                get { return _IfNoneMatchElement; }
                set { _IfNoneMatchElement = value; OnPropertyChanged("IfNoneMatchElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _IfNoneMatchElement;
            
            /// <summary>
            /// For managing cache currency
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string IfNoneMatch
            {
                get { return IfNoneMatchElement != null ? IfNoneMatchElement.Value : null; }
                set
                {
                    if(value == null)
                      IfNoneMatchElement = null; 
                    else
                      IfNoneMatchElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("IfNoneMatch");
                }
            }
            
            /// <summary>
            /// For managing update contention
            /// </summary>
            [FhirElement("ifModifiedSince", InSummary=true, Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.Instant IfModifiedSinceElement
            {
                get { return _IfModifiedSinceElement; }
                set { _IfModifiedSinceElement = value; OnPropertyChanged("IfModifiedSinceElement"); }
            }
            
            private Hl7.Fhir.Model.Instant _IfModifiedSinceElement;
            
            /// <summary>
            /// For managing update contention
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public DateTimeOffset? IfModifiedSince
            {
                get { return IfModifiedSinceElement != null ? IfModifiedSinceElement.Value : null; }
                set
                {
                    if(value == null)
                      IfModifiedSinceElement = null; 
                    else
                      IfModifiedSinceElement = new Hl7.Fhir.Model.Instant(value);
                    OnPropertyChanged("IfModifiedSince");
                }
            }
            
            /// <summary>
            /// For managing update contention
            /// </summary>
            [FhirElement("ifMatch", InSummary=true, Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString IfMatchElement
            {
                get { return _IfMatchElement; }
                set { _IfMatchElement = value; OnPropertyChanged("IfMatchElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _IfMatchElement;
            
            /// <summary>
            /// For managing update contention
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string IfMatch
            {
                get { return IfMatchElement != null ? IfMatchElement.Value : null; }
                set
                {
                    if(value == null)
                      IfMatchElement = null; 
                    else
                      IfMatchElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("IfMatch");
                }
            }
            
            /// <summary>
            /// For conditional creates
            /// </summary>
            [FhirElement("ifNoneExist", InSummary=true, Order=90)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString IfNoneExistElement
            {
                get { return _IfNoneExistElement; }
                set { _IfNoneExistElement = value; OnPropertyChanged("IfNoneExistElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _IfNoneExistElement;
            
            /// <summary>
            /// For conditional creates
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string IfNoneExist
            {
                get { return IfNoneExistElement != null ? IfNoneExistElement.Value : null; }
                set
                {
                    if(value == null)
                      IfNoneExistElement = null; 
                    else
                      IfNoneExistElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("IfNoneExist");
                }
            }
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RequestComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(MethodElement != null) dest.MethodElement = (Code<Hl7.Fhir.Model.Bundle.HTTPVerb>)MethodElement.DeepCopy();
                    if(UrlElement != null) dest.UrlElement = (Hl7.Fhir.Model.FhirUri)UrlElement.DeepCopy();
                    if(IfNoneMatchElement != null) dest.IfNoneMatchElement = (Hl7.Fhir.Model.FhirString)IfNoneMatchElement.DeepCopy();
                    if(IfModifiedSinceElement != null) dest.IfModifiedSinceElement = (Hl7.Fhir.Model.Instant)IfModifiedSinceElement.DeepCopy();
                    if(IfMatchElement != null) dest.IfMatchElement = (Hl7.Fhir.Model.FhirString)IfMatchElement.DeepCopy();
                    if(IfNoneExistElement != null) dest.IfNoneExistElement = (Hl7.Fhir.Model.FhirString)IfNoneExistElement.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new RequestComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RequestComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(MethodElement, otherT.MethodElement)) return false;
                if( !DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
                if( !DeepComparable.Matches(IfNoneMatchElement, otherT.IfNoneMatchElement)) return false;
                if( !DeepComparable.Matches(IfModifiedSinceElement, otherT.IfModifiedSinceElement)) return false;
                if( !DeepComparable.Matches(IfMatchElement, otherT.IfMatchElement)) return false;
                if( !DeepComparable.Matches(IfNoneExistElement, otherT.IfNoneExistElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RequestComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(MethodElement, otherT.MethodElement)) return false;
                if( !DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
                if( !DeepComparable.IsExactly(IfNoneMatchElement, otherT.IfNoneMatchElement)) return false;
                if( !DeepComparable.IsExactly(IfModifiedSinceElement, otherT.IfModifiedSinceElement)) return false;
                if( !DeepComparable.IsExactly(IfMatchElement, otherT.IfMatchElement)) return false;
                if( !DeepComparable.IsExactly(IfNoneExistElement, otherT.IfNoneExistElement)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("ResponseComponent")]
        [DataContract]
        public partial class ResponseComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ResponseComponent"; } }
            
            /// <summary>
            /// Status response code (text optional)
            /// </summary>
            [FhirElement("status", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString StatusElement
            {
                get { return _StatusElement; }
                set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _StatusElement;
            
            /// <summary>
            /// Status response code (text optional)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Status
            {
                get { return StatusElement != null ? StatusElement.Value : null; }
                set
                {
                    if(value == null)
                      StatusElement = null; 
                    else
                      StatusElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Status");
                }
            }
            
            /// <summary>
            /// The location, if the operation returns a location
            /// </summary>
            [FhirElement("location", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirUri LocationElement
            {
                get { return _LocationElement; }
                set { _LocationElement = value; OnPropertyChanged("LocationElement"); }
            }
            
            private Hl7.Fhir.Model.FhirUri _LocationElement;
            
            /// <summary>
            /// The location, if the operation returns a location
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Location
            {
                get { return LocationElement != null ? LocationElement.Value : null; }
                set
                {
                    if(value == null)
                      LocationElement = null; 
                    else
                      LocationElement = new Hl7.Fhir.Model.FhirUri(value);
                    OnPropertyChanged("Location");
                }
            }
            
            /// <summary>
            /// The etag for the resource (if relevant)
            /// </summary>
            [FhirElement("etag", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString EtagElement
            {
                get { return _EtagElement; }
                set { _EtagElement = value; OnPropertyChanged("EtagElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _EtagElement;
            
            /// <summary>
            /// The etag for the resource (if relevant)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Etag
            {
                get { return EtagElement != null ? EtagElement.Value : null; }
                set
                {
                    if(value == null)
                      EtagElement = null; 
                    else
                      EtagElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Etag");
                }
            }
            
            /// <summary>
            /// Server's date time modified
            /// </summary>
            [FhirElement("lastModified", InSummary=true, Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.Instant LastModifiedElement
            {
                get { return _LastModifiedElement; }
                set { _LastModifiedElement = value; OnPropertyChanged("LastModifiedElement"); }
            }
            
            private Hl7.Fhir.Model.Instant _LastModifiedElement;
            
            /// <summary>
            /// Server's date time modified
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public DateTimeOffset? LastModified
            {
                get { return LastModifiedElement != null ? LastModifiedElement.Value : null; }
                set
                {
                    if(value == null)
                      LastModifiedElement = null; 
                    else
                      LastModifiedElement = new Hl7.Fhir.Model.Instant(value);
                    OnPropertyChanged("LastModified");
                }
            }
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ResponseComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(StatusElement != null) dest.StatusElement = (Hl7.Fhir.Model.FhirString)StatusElement.DeepCopy();
                    if(LocationElement != null) dest.LocationElement = (Hl7.Fhir.Model.FhirUri)LocationElement.DeepCopy();
                    if(EtagElement != null) dest.EtagElement = (Hl7.Fhir.Model.FhirString)EtagElement.DeepCopy();
                    if(LastModifiedElement != null) dest.LastModifiedElement = (Hl7.Fhir.Model.Instant)LastModifiedElement.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ResponseComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ResponseComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
                if( !DeepComparable.Matches(LocationElement, otherT.LocationElement)) return false;
                if( !DeepComparable.Matches(EtagElement, otherT.EtagElement)) return false;
                if( !DeepComparable.Matches(LastModifiedElement, otherT.LastModifiedElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ResponseComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
                if( !DeepComparable.IsExactly(LocationElement, otherT.LocationElement)) return false;
                if( !DeepComparable.IsExactly(EtagElement, otherT.EtagElement)) return false;
                if( !DeepComparable.IsExactly(LastModifiedElement, otherT.LastModifiedElement)) return false;
                
                return true;
            }
            
        }
        
        
        /// <summary>
        /// document | message | transaction | transaction-response | batch | batch-response | history | searchset | collection
        /// </summary>
        [FhirElement("type", InSummary=true, Order=50)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.Bundle.BundleType> TypeElement
        {
            get { return _TypeElement; }
            set { _TypeElement = value; OnPropertyChanged("TypeElement"); }
        }
        
        private Code<Hl7.Fhir.Model.Bundle.BundleType> _TypeElement;
        
        /// <summary>
        /// document | message | transaction | transaction-response | batch | batch-response | history | searchset | collection
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.Bundle.BundleType? Type
        {
            get { return TypeElement != null ? TypeElement.Value : null; }
            set
            {
                if(value == null)
                  TypeElement = null; 
                else
                  TypeElement = new Code<Hl7.Fhir.Model.Bundle.BundleType>(value);
                OnPropertyChanged("Type");
            }
        }
        
        /// <summary>
        /// If search, the total number of matches
        /// </summary>
        [FhirElement("total", InSummary=true, Order=60)]
        [DataMember]
        public Hl7.Fhir.Model.UnsignedInt TotalElement
        {
            get { return _TotalElement; }
            set { _TotalElement = value; OnPropertyChanged("TotalElement"); }
        }
        
        private Hl7.Fhir.Model.UnsignedInt _TotalElement;
        
        /// <summary>
        /// If search, the total number of matches
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public int? Total
        {
            get { return TotalElement != null ? TotalElement.Value : null; }
            set
            {
                if(value == null)
                  TotalElement = null; 
                else
                  TotalElement = new Hl7.Fhir.Model.UnsignedInt(value);
                OnPropertyChanged("Total");
            }
        }
        
        /// <summary>
        /// Links related to this Bundle
        /// </summary>
        [FhirElement("link", InSummary=true, Order=70)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Bundle.LinkComponent> Link
        {
            get { if(_Link==null) _Link = new List<Hl7.Fhir.Model.Bundle.LinkComponent>(); return _Link; }
            set { _Link = value; OnPropertyChanged("Link"); }
        }
        
        private List<Hl7.Fhir.Model.Bundle.LinkComponent> _Link;
        
        /// <summary>
        /// Entry in the bundle - will have a resource, or information
        /// </summary>
        [FhirElement("entry", InSummary=true, Order=80)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Bundle.EntryComponent> Entry
        {
            get { if(_Entry==null) _Entry = new List<Hl7.Fhir.Model.Bundle.EntryComponent>(); return _Entry; }
            set { _Entry = value; OnPropertyChanged("Entry"); }
        }
        
        private List<Hl7.Fhir.Model.Bundle.EntryComponent> _Entry;
        
        /// <summary>
        /// Digital Signature
        /// </summary>
        [FhirElement("signature", InSummary=true, Order=90)]
        [DataMember]
        public Hl7.Fhir.Model.Signature Signature
        {
            get { return _Signature; }
            set { _Signature = value; OnPropertyChanged("Signature"); }
        }
        
        private Hl7.Fhir.Model.Signature _Signature;
        
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Bundle;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(TypeElement != null) dest.TypeElement = (Code<Hl7.Fhir.Model.Bundle.BundleType>)TypeElement.DeepCopy();
                if(TotalElement != null) dest.TotalElement = (Hl7.Fhir.Model.UnsignedInt)TotalElement.DeepCopy();
                if(Link != null) dest.Link = new List<Hl7.Fhir.Model.Bundle.LinkComponent>(Link.DeepCopy());
                if(Entry != null) dest.Entry = new List<Hl7.Fhir.Model.Bundle.EntryComponent>(Entry.DeepCopy());
                if(Signature != null) dest.Signature = (Hl7.Fhir.Model.Signature)Signature.DeepCopy();
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new Bundle());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Bundle;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
            if( !DeepComparable.Matches(TotalElement, otherT.TotalElement)) return false;
            if( !DeepComparable.Matches(Link, otherT.Link)) return false;
            if( !DeepComparable.Matches(Entry, otherT.Entry)) return false;
            if( !DeepComparable.Matches(Signature, otherT.Signature)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Bundle;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
            if( !DeepComparable.IsExactly(TotalElement, otherT.TotalElement)) return false;
            if( !DeepComparable.IsExactly(Link, otherT.Link)) return false;
            if( !DeepComparable.IsExactly(Entry, otherT.Entry)) return false;
            if( !DeepComparable.IsExactly(Signature, otherT.Signature)) return false;
            
            return true;
        }
        
    }
    
}
