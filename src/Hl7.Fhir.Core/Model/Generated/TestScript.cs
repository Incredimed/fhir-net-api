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
    /// Describes a set of tests
    /// </summary>
    [FhirType("TestScript", IsResource=true)]
    [DataContract]
    public partial class TestScript : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.TestScript; } }
        [NotMapped]
        public override string TypeName { get { return "TestScript"; } }
        
        /// <summary>
        /// The content or mime type.
        /// (url: http://hl7.org/fhir/ValueSet/content-type)
        /// </summary>
        [FhirEnumeration("ContentType")]
        public enum ContentType
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/content-type)
            /// </summary>
            [EnumLiteral("xml"), Description("xml")]
            Xml,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/content-type)
            /// </summary>
            [EnumLiteral("json"), Description("json")]
            Json,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/content-type)
            /// </summary>
            [EnumLiteral("ttl"), Description("ttl")]
            Ttl,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/content-type)
            /// </summary>
            [EnumLiteral("none"), Description("none")]
            None,
        }

        /// <summary>
        /// The type of direction to use for assertion.
        /// (url: http://hl7.org/fhir/ValueSet/assert-direction-codes)
        /// </summary>
        [FhirEnumeration("AssertionDirectionType")]
        public enum AssertionDirectionType
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-direction-codes)
            /// </summary>
            [EnumLiteral("response"), Description("response")]
            Response,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-direction-codes)
            /// </summary>
            [EnumLiteral("request"), Description("request")]
            Request,
        }

        /// <summary>
        /// The type of operator to use for assertion.
        /// (url: http://hl7.org/fhir/ValueSet/assert-operator-codes)
        /// </summary>
        [FhirEnumeration("AssertionOperatorType")]
        public enum AssertionOperatorType
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("equals"), Description("equals")]
            Equals,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("notEquals"), Description("notEquals")]
            NotEquals,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("in"), Description("in")]
            In,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("notIn"), Description("notIn")]
            NotIn,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("greaterThan"), Description("greaterThan")]
            GreaterThan,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("lessThan"), Description("lessThan")]
            LessThan,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("empty"), Description("empty")]
            Empty,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("notEmpty"), Description("notEmpty")]
            NotEmpty,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("contains"), Description("contains")]
            Contains,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("notContains"), Description("notContains")]
            NotContains,
        }

        /// <summary>
        /// The type of response code to use for assertion.
        /// (url: http://hl7.org/fhir/ValueSet/assert-response-code-types)
        /// </summary>
        [FhirEnumeration("AssertionResponseTypes")]
        public enum AssertionResponseTypes
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("okay"), Description("okay")]
            Okay,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("created"), Description("created")]
            Created,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("noContent"), Description("noContent")]
            NoContent,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("notModified"), Description("notModified")]
            NotModified,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("bad"), Description("bad")]
            Bad,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("forbidden"), Description("forbidden")]
            Forbidden,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("notFound"), Description("notFound")]
            NotFound,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("methodNotAllowed"), Description("methodNotAllowed")]
            MethodNotAllowed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("conflict"), Description("conflict")]
            Conflict,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("gone"), Description("gone")]
            Gone,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("preconditionFailed"), Description("preconditionFailed")]
            PreconditionFailed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("unprocessable"), Description("unprocessable")]
            Unprocessable,
        }

        [FhirType("ContactComponent")]
        [DataContract]
        public partial class ContactComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ContactComponent"; } }
            
            /// <summary>
            /// Name of an individual to contact
            /// </summary>
            [FhirElement("name", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString NameElement
            {
                get { return _NameElement; }
                set { _NameElement = value; OnPropertyChanged("NameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _NameElement;
            
            /// <summary>
            /// Name of an individual to contact
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Name
            {
                get { return NameElement != null ? NameElement.Value : null; }
                set
                {
                    if(value == null)
                      NameElement = null; 
                    else
                      NameElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Name");
                }
            }
            
            /// <summary>
            /// Contact details for individual or publisher
            /// </summary>
            [FhirElement("telecom", InSummary=true, Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.ContactPoint> Telecom
            {
                get { if(_Telecom==null) _Telecom = new List<Hl7.Fhir.Model.ContactPoint>(); return _Telecom; }
                set { _Telecom = value; OnPropertyChanged("Telecom"); }
            }
            
            private List<Hl7.Fhir.Model.ContactPoint> _Telecom;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContactComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                    if(Telecom != null) dest.Telecom = new List<Hl7.Fhir.Model.ContactPoint>(Telecom.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ContactComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ContactComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.Matches(Telecom, otherT.Telecom)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContactComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.IsExactly(Telecom, otherT.Telecom)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("OriginComponent")]
        [DataContract]
        public partial class OriginComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "OriginComponent"; } }
            
            /// <summary>
            /// The index of the abstract origin server starting at 1
            /// </summary>
            [FhirElement("index", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Integer IndexElement
            {
                get { return _IndexElement; }
                set { _IndexElement = value; OnPropertyChanged("IndexElement"); }
            }
            
            private Hl7.Fhir.Model.Integer _IndexElement;
            
            /// <summary>
            /// The index of the abstract origin server starting at 1
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public int? Index
            {
                get { return IndexElement != null ? IndexElement.Value : null; }
                set
                {
                    if(value == null)
                      IndexElement = null; 
                    else
                      IndexElement = new Hl7.Fhir.Model.Integer(value);
                    OnPropertyChanged("Index");
                }
            }
            
            /// <summary>
            /// FHIR-Client | FHIR-SDC-FormFiller
            /// </summary>
            [FhirElement("profile", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Coding Profile
            {
                get { return _Profile; }
                set { _Profile = value; OnPropertyChanged("Profile"); }
            }
            
            private Hl7.Fhir.Model.Coding _Profile;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as OriginComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(IndexElement != null) dest.IndexElement = (Hl7.Fhir.Model.Integer)IndexElement.DeepCopy();
                    if(Profile != null) dest.Profile = (Hl7.Fhir.Model.Coding)Profile.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new OriginComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as OriginComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(IndexElement, otherT.IndexElement)) return false;
                if( !DeepComparable.Matches(Profile, otherT.Profile)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as OriginComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(IndexElement, otherT.IndexElement)) return false;
                if( !DeepComparable.IsExactly(Profile, otherT.Profile)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("DestinationComponent")]
        [DataContract]
        public partial class DestinationComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "DestinationComponent"; } }
            
            /// <summary>
            /// The index of the abstract destination server starting at 1
            /// </summary>
            [FhirElement("index", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Integer IndexElement
            {
                get { return _IndexElement; }
                set { _IndexElement = value; OnPropertyChanged("IndexElement"); }
            }
            
            private Hl7.Fhir.Model.Integer _IndexElement;
            
            /// <summary>
            /// The index of the abstract destination server starting at 1
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public int? Index
            {
                get { return IndexElement != null ? IndexElement.Value : null; }
                set
                {
                    if(value == null)
                      IndexElement = null; 
                    else
                      IndexElement = new Hl7.Fhir.Model.Integer(value);
                    OnPropertyChanged("Index");
                }
            }
            
            /// <summary>
            /// FHIR-Server | FHIR-SDC-FormManager | FHIR-SDC-FormReceiver | FHIR-SDC-FormProcessor
            /// </summary>
            [FhirElement("profile", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Coding Profile
            {
                get { return _Profile; }
                set { _Profile = value; OnPropertyChanged("Profile"); }
            }
            
            private Hl7.Fhir.Model.Coding _Profile;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DestinationComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(IndexElement != null) dest.IndexElement = (Hl7.Fhir.Model.Integer)IndexElement.DeepCopy();
                    if(Profile != null) dest.Profile = (Hl7.Fhir.Model.Coding)Profile.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new DestinationComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DestinationComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(IndexElement, otherT.IndexElement)) return false;
                if( !DeepComparable.Matches(Profile, otherT.Profile)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DestinationComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(IndexElement, otherT.IndexElement)) return false;
                if( !DeepComparable.IsExactly(Profile, otherT.Profile)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("MetadataComponent")]
        [DataContract]
        public partial class MetadataComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "MetadataComponent"; } }
            
            /// <summary>
            /// Links to the FHIR specification
            /// </summary>
            [FhirElement("link", Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.TestScript.LinkComponent> Link
            {
                get { if(_Link==null) _Link = new List<Hl7.Fhir.Model.TestScript.LinkComponent>(); return _Link; }
                set { _Link = value; OnPropertyChanged("Link"); }
            }
            
            private List<Hl7.Fhir.Model.TestScript.LinkComponent> _Link;
            
            /// <summary>
            /// Capabilities  that are assumed to function correctly on the FHIR server being tested
            /// </summary>
            [FhirElement("capability", Order=50)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.TestScript.CapabilityComponent> Capability
            {
                get { if(_Capability==null) _Capability = new List<Hl7.Fhir.Model.TestScript.CapabilityComponent>(); return _Capability; }
                set { _Capability = value; OnPropertyChanged("Capability"); }
            }
            
            private List<Hl7.Fhir.Model.TestScript.CapabilityComponent> _Capability;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MetadataComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Link != null) dest.Link = new List<Hl7.Fhir.Model.TestScript.LinkComponent>(Link.DeepCopy());
                    if(Capability != null) dest.Capability = new List<Hl7.Fhir.Model.TestScript.CapabilityComponent>(Capability.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new MetadataComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MetadataComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Link, otherT.Link)) return false;
                if( !DeepComparable.Matches(Capability, otherT.Capability)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MetadataComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Link, otherT.Link)) return false;
                if( !DeepComparable.IsExactly(Capability, otherT.Capability)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("LinkComponent")]
        [DataContract]
        public partial class LinkComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "LinkComponent"; } }
            
            /// <summary>
            /// URL to the specification
            /// </summary>
            [FhirElement("url", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirUri UrlElement
            {
                get { return _UrlElement; }
                set { _UrlElement = value; OnPropertyChanged("UrlElement"); }
            }
            
            private Hl7.Fhir.Model.FhirUri _UrlElement;
            
            /// <summary>
            /// URL to the specification
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
            /// Short description
            /// </summary>
            [FhirElement("description", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString DescriptionElement
            {
                get { return _DescriptionElement; }
                set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _DescriptionElement;
            
            /// <summary>
            /// Short description
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Description
            {
                get { return DescriptionElement != null ? DescriptionElement.Value : null; }
                set
                {
                    if(value == null)
                      DescriptionElement = null; 
                    else
                      DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Description");
                }
            }
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as LinkComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(UrlElement != null) dest.UrlElement = (Hl7.Fhir.Model.FhirUri)UrlElement.DeepCopy();
                    if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
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
                if( !DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
                if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as LinkComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
                if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("CapabilityComponent")]
        [DataContract]
        public partial class CapabilityComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "CapabilityComponent"; } }
            
            /// <summary>
            /// Are the capabilities required?
            /// </summary>
            [FhirElement("required", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean RequiredElement
            {
                get { return _RequiredElement; }
                set { _RequiredElement = value; OnPropertyChanged("RequiredElement"); }
            }
            
            private Hl7.Fhir.Model.FhirBoolean _RequiredElement;
            
            /// <summary>
            /// Are the capabilities required?
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? Required
            {
                get { return RequiredElement != null ? RequiredElement.Value : null; }
                set
                {
                    if(value == null)
                      RequiredElement = null; 
                    else
                      RequiredElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("Required");
                }
            }
            
            /// <summary>
            /// Are the capabilities validated?
            /// </summary>
            [FhirElement("validated", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean ValidatedElement
            {
                get { return _ValidatedElement; }
                set { _ValidatedElement = value; OnPropertyChanged("ValidatedElement"); }
            }
            
            private Hl7.Fhir.Model.FhirBoolean _ValidatedElement;
            
            /// <summary>
            /// Are the capabilities validated?
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? Validated
            {
                get { return ValidatedElement != null ? ValidatedElement.Value : null; }
                set
                {
                    if(value == null)
                      ValidatedElement = null; 
                    else
                      ValidatedElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("Validated");
                }
            }
            
            /// <summary>
            /// The expected capabilities of the server
            /// </summary>
            [FhirElement("description", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString DescriptionElement
            {
                get { return _DescriptionElement; }
                set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _DescriptionElement;
            
            /// <summary>
            /// The expected capabilities of the server
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Description
            {
                get { return DescriptionElement != null ? DescriptionElement.Value : null; }
                set
                {
                    if(value == null)
                      DescriptionElement = null; 
                    else
                      DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Description");
                }
            }
            
            /// <summary>
            /// Which origin server these requirements apply to
            /// </summary>
            [FhirElement("origin", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.Integer> OriginElement
            {
                get { if(_OriginElement==null) _OriginElement = new List<Hl7.Fhir.Model.Integer>(); return _OriginElement; }
                set { _OriginElement = value; OnPropertyChanged("OriginElement"); }
            }
            
            private List<Hl7.Fhir.Model.Integer> _OriginElement;
            
            /// <summary>
            /// Which origin server these requirements apply to
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<int?> Origin
            {
                get { return OriginElement != null ? OriginElement.Select(elem => elem.Value) : null; }
                set
                {
                    if(value == null)
                      OriginElement = null; 
                    else
                      OriginElement = new List<Hl7.Fhir.Model.Integer>(value.Select(elem=>new Hl7.Fhir.Model.Integer(elem)));
                    OnPropertyChanged("Origin");
                }
            }
            
            /// <summary>
            /// Which server these requirements apply to
            /// </summary>
            [FhirElement("destination", Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.Integer DestinationElement
            {
                get { return _DestinationElement; }
                set { _DestinationElement = value; OnPropertyChanged("DestinationElement"); }
            }
            
            private Hl7.Fhir.Model.Integer _DestinationElement;
            
            /// <summary>
            /// Which server these requirements apply to
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public int? Destination
            {
                get { return DestinationElement != null ? DestinationElement.Value : null; }
                set
                {
                    if(value == null)
                      DestinationElement = null; 
                    else
                      DestinationElement = new Hl7.Fhir.Model.Integer(value);
                    OnPropertyChanged("Destination");
                }
            }
            
            /// <summary>
            /// Links to the FHIR specification
            /// </summary>
            [FhirElement("link", Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.FhirUri> LinkElement
            {
                get { if(_LinkElement==null) _LinkElement = new List<Hl7.Fhir.Model.FhirUri>(); return _LinkElement; }
                set { _LinkElement = value; OnPropertyChanged("LinkElement"); }
            }
            
            private List<Hl7.Fhir.Model.FhirUri> _LinkElement;
            
            /// <summary>
            /// Links to the FHIR specification
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<string> Link
            {
                get { return LinkElement != null ? LinkElement.Select(elem => elem.Value) : null; }
                set
                {
                    if(value == null)
                      LinkElement = null; 
                    else
                      LinkElement = new List<Hl7.Fhir.Model.FhirUri>(value.Select(elem=>new Hl7.Fhir.Model.FhirUri(elem)));
                    OnPropertyChanged("Link");
                }
            }
            
            /// <summary>
            /// Required Conformance
            /// </summary>
            [FhirElement("conformance", Order=100)]
            [References("Conformance")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Conformance
            {
                get { return _Conformance; }
                set { _Conformance = value; OnPropertyChanged("Conformance"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _Conformance;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CapabilityComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(RequiredElement != null) dest.RequiredElement = (Hl7.Fhir.Model.FhirBoolean)RequiredElement.DeepCopy();
                    if(ValidatedElement != null) dest.ValidatedElement = (Hl7.Fhir.Model.FhirBoolean)ValidatedElement.DeepCopy();
                    if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
                    if(OriginElement != null) dest.OriginElement = new List<Hl7.Fhir.Model.Integer>(OriginElement.DeepCopy());
                    if(DestinationElement != null) dest.DestinationElement = (Hl7.Fhir.Model.Integer)DestinationElement.DeepCopy();
                    if(LinkElement != null) dest.LinkElement = new List<Hl7.Fhir.Model.FhirUri>(LinkElement.DeepCopy());
                    if(Conformance != null) dest.Conformance = (Hl7.Fhir.Model.ResourceReference)Conformance.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new CapabilityComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CapabilityComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(RequiredElement, otherT.RequiredElement)) return false;
                if( !DeepComparable.Matches(ValidatedElement, otherT.ValidatedElement)) return false;
                if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.Matches(OriginElement, otherT.OriginElement)) return false;
                if( !DeepComparable.Matches(DestinationElement, otherT.DestinationElement)) return false;
                if( !DeepComparable.Matches(LinkElement, otherT.LinkElement)) return false;
                if( !DeepComparable.Matches(Conformance, otherT.Conformance)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CapabilityComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(RequiredElement, otherT.RequiredElement)) return false;
                if( !DeepComparable.IsExactly(ValidatedElement, otherT.ValidatedElement)) return false;
                if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.IsExactly(OriginElement, otherT.OriginElement)) return false;
                if( !DeepComparable.IsExactly(DestinationElement, otherT.DestinationElement)) return false;
                if( !DeepComparable.IsExactly(LinkElement, otherT.LinkElement)) return false;
                if( !DeepComparable.IsExactly(Conformance, otherT.Conformance)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("FixtureComponent")]
        [DataContract]
        public partial class FixtureComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "FixtureComponent"; } }
            
            /// <summary>
            /// Whether or not to implicitly create the fixture during setup
            /// </summary>
            [FhirElement("autocreate", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean AutocreateElement
            {
                get { return _AutocreateElement; }
                set { _AutocreateElement = value; OnPropertyChanged("AutocreateElement"); }
            }
            
            private Hl7.Fhir.Model.FhirBoolean _AutocreateElement;
            
            /// <summary>
            /// Whether or not to implicitly create the fixture during setup
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? Autocreate
            {
                get { return AutocreateElement != null ? AutocreateElement.Value : null; }
                set
                {
                    if(value == null)
                      AutocreateElement = null; 
                    else
                      AutocreateElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("Autocreate");
                }
            }
            
            /// <summary>
            /// Whether or not to implicitly delete the fixture during teardown
            /// </summary>
            [FhirElement("autodelete", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean AutodeleteElement
            {
                get { return _AutodeleteElement; }
                set { _AutodeleteElement = value; OnPropertyChanged("AutodeleteElement"); }
            }
            
            private Hl7.Fhir.Model.FhirBoolean _AutodeleteElement;
            
            /// <summary>
            /// Whether or not to implicitly delete the fixture during teardown
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? Autodelete
            {
                get { return AutodeleteElement != null ? AutodeleteElement.Value : null; }
                set
                {
                    if(value == null)
                      AutodeleteElement = null; 
                    else
                      AutodeleteElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("Autodelete");
                }
            }
            
            /// <summary>
            /// Reference of the resource
            /// </summary>
            [FhirElement("resource", Order=60)]
            [References()]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Resource
            {
                get { return _Resource; }
                set { _Resource = value; OnPropertyChanged("Resource"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _Resource;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as FixtureComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(AutocreateElement != null) dest.AutocreateElement = (Hl7.Fhir.Model.FhirBoolean)AutocreateElement.DeepCopy();
                    if(AutodeleteElement != null) dest.AutodeleteElement = (Hl7.Fhir.Model.FhirBoolean)AutodeleteElement.DeepCopy();
                    if(Resource != null) dest.Resource = (Hl7.Fhir.Model.ResourceReference)Resource.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new FixtureComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as FixtureComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(AutocreateElement, otherT.AutocreateElement)) return false;
                if( !DeepComparable.Matches(AutodeleteElement, otherT.AutodeleteElement)) return false;
                if( !DeepComparable.Matches(Resource, otherT.Resource)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as FixtureComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(AutocreateElement, otherT.AutocreateElement)) return false;
                if( !DeepComparable.IsExactly(AutodeleteElement, otherT.AutodeleteElement)) return false;
                if( !DeepComparable.IsExactly(Resource, otherT.Resource)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("VariableComponent")]
        [DataContract]
        public partial class VariableComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "VariableComponent"; } }
            
            /// <summary>
            /// Descriptive name for this variable
            /// </summary>
            [FhirElement("name", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString NameElement
            {
                get { return _NameElement; }
                set { _NameElement = value; OnPropertyChanged("NameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _NameElement;
            
            /// <summary>
            /// Descriptive name for this variable
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Name
            {
                get { return NameElement != null ? NameElement.Value : null; }
                set
                {
                    if(value == null)
                      NameElement = null; 
                    else
                      NameElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Name");
                }
            }
            
            /// <summary>
            /// Default, hard-coded, or user-defined value for this variable
            /// </summary>
            [FhirElement("defaultValue", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString DefaultValueElement
            {
                get { return _DefaultValueElement; }
                set { _DefaultValueElement = value; OnPropertyChanged("DefaultValueElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _DefaultValueElement;
            
            /// <summary>
            /// Default, hard-coded, or user-defined value for this variable
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string DefaultValue
            {
                get { return DefaultValueElement != null ? DefaultValueElement.Value : null; }
                set
                {
                    if(value == null)
                      DefaultValueElement = null; 
                    else
                      DefaultValueElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("DefaultValue");
                }
            }
            
            /// <summary>
            /// HTTP header field name for source
            /// </summary>
            [FhirElement("headerField", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString HeaderFieldElement
            {
                get { return _HeaderFieldElement; }
                set { _HeaderFieldElement = value; OnPropertyChanged("HeaderFieldElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _HeaderFieldElement;
            
            /// <summary>
            /// HTTP header field name for source
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string HeaderField
            {
                get { return HeaderFieldElement != null ? HeaderFieldElement.Value : null; }
                set
                {
                    if(value == null)
                      HeaderFieldElement = null; 
                    else
                      HeaderFieldElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("HeaderField");
                }
            }
            
            /// <summary>
            /// XPath or JSONPath against the fixture body
            /// </summary>
            [FhirElement("path", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString PathElement
            {
                get { return _PathElement; }
                set { _PathElement = value; OnPropertyChanged("PathElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _PathElement;
            
            /// <summary>
            /// XPath or JSONPath against the fixture body
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Path
            {
                get { return PathElement != null ? PathElement.Value : null; }
                set
                {
                    if(value == null)
                      PathElement = null; 
                    else
                      PathElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Path");
                }
            }
            
            /// <summary>
            /// Fixture Id of source expression or headerField within this variable
            /// </summary>
            [FhirElement("sourceId", Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.Id SourceIdElement
            {
                get { return _SourceIdElement; }
                set { _SourceIdElement = value; OnPropertyChanged("SourceIdElement"); }
            }
            
            private Hl7.Fhir.Model.Id _SourceIdElement;
            
            /// <summary>
            /// Fixture Id of source expression or headerField within this variable
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string SourceId
            {
                get { return SourceIdElement != null ? SourceIdElement.Value : null; }
                set
                {
                    if(value == null)
                      SourceIdElement = null; 
                    else
                      SourceIdElement = new Hl7.Fhir.Model.Id(value);
                    OnPropertyChanged("SourceId");
                }
            }
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as VariableComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                    if(DefaultValueElement != null) dest.DefaultValueElement = (Hl7.Fhir.Model.FhirString)DefaultValueElement.DeepCopy();
                    if(HeaderFieldElement != null) dest.HeaderFieldElement = (Hl7.Fhir.Model.FhirString)HeaderFieldElement.DeepCopy();
                    if(PathElement != null) dest.PathElement = (Hl7.Fhir.Model.FhirString)PathElement.DeepCopy();
                    if(SourceIdElement != null) dest.SourceIdElement = (Hl7.Fhir.Model.Id)SourceIdElement.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new VariableComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as VariableComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.Matches(DefaultValueElement, otherT.DefaultValueElement)) return false;
                if( !DeepComparable.Matches(HeaderFieldElement, otherT.HeaderFieldElement)) return false;
                if( !DeepComparable.Matches(PathElement, otherT.PathElement)) return false;
                if( !DeepComparable.Matches(SourceIdElement, otherT.SourceIdElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as VariableComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.IsExactly(DefaultValueElement, otherT.DefaultValueElement)) return false;
                if( !DeepComparable.IsExactly(HeaderFieldElement, otherT.HeaderFieldElement)) return false;
                if( !DeepComparable.IsExactly(PathElement, otherT.PathElement)) return false;
                if( !DeepComparable.IsExactly(SourceIdElement, otherT.SourceIdElement)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("RuleComponent")]
        [DataContract]
        public partial class RuleComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "RuleComponent"; } }
            
            /// <summary>
            /// Assert rule resource reference
            /// </summary>
            [FhirElement("resource", Order=40)]
            [References()]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Resource
            {
                get { return _Resource; }
                set { _Resource = value; OnPropertyChanged("Resource"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _Resource;
            
            /// <summary>
            /// Rule parameter template
            /// </summary>
            [FhirElement("param", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.TestScript.RuleParamComponent> Param
            {
                get { if(_Param==null) _Param = new List<Hl7.Fhir.Model.TestScript.RuleParamComponent>(); return _Param; }
                set { _Param = value; OnPropertyChanged("Param"); }
            }
            
            private List<Hl7.Fhir.Model.TestScript.RuleParamComponent> _Param;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RuleComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Resource != null) dest.Resource = (Hl7.Fhir.Model.ResourceReference)Resource.DeepCopy();
                    if(Param != null) dest.Param = new List<Hl7.Fhir.Model.TestScript.RuleParamComponent>(Param.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new RuleComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RuleComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Resource, otherT.Resource)) return false;
                if( !DeepComparable.Matches(Param, otherT.Param)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RuleComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Resource, otherT.Resource)) return false;
                if( !DeepComparable.IsExactly(Param, otherT.Param)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("RuleParamComponent")]
        [DataContract]
        public partial class RuleParamComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "RuleParamComponent"; } }
            
            /// <summary>
            /// Parameter name matching external assert rule parameter
            /// </summary>
            [FhirElement("name", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString NameElement
            {
                get { return _NameElement; }
                set { _NameElement = value; OnPropertyChanged("NameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _NameElement;
            
            /// <summary>
            /// Parameter name matching external assert rule parameter
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Name
            {
                get { return NameElement != null ? NameElement.Value : null; }
                set
                {
                    if(value == null)
                      NameElement = null; 
                    else
                      NameElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Name");
                }
            }
            
            /// <summary>
            /// Parameter value defined either explicitly or dynamically
            /// </summary>
            [FhirElement("value", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString ValueElement
            {
                get { return _ValueElement; }
                set { _ValueElement = value; OnPropertyChanged("ValueElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _ValueElement;
            
            /// <summary>
            /// Parameter value defined either explicitly or dynamically
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if(value == null)
                      ValueElement = null; 
                    else
                      ValueElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Value");
                }
            }
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RuleParamComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                    if(ValueElement != null) dest.ValueElement = (Hl7.Fhir.Model.FhirString)ValueElement.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new RuleParamComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RuleParamComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RuleParamComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("RulesetComponent")]
        [DataContract]
        public partial class RulesetComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "RulesetComponent"; } }
            
            /// <summary>
            /// Assert ruleset resource reference
            /// </summary>
            [FhirElement("resource", Order=40)]
            [References()]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Resource
            {
                get { return _Resource; }
                set { _Resource = value; OnPropertyChanged("Resource"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _Resource;
            
            /// <summary>
            /// The referenced rule within the ruleset
            /// </summary>
            [FhirElement("rule", Order=50)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.TestScript.RulesetRuleComponent> Rule
            {
                get { if(_Rule==null) _Rule = new List<Hl7.Fhir.Model.TestScript.RulesetRuleComponent>(); return _Rule; }
                set { _Rule = value; OnPropertyChanged("Rule"); }
            }
            
            private List<Hl7.Fhir.Model.TestScript.RulesetRuleComponent> _Rule;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RulesetComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Resource != null) dest.Resource = (Hl7.Fhir.Model.ResourceReference)Resource.DeepCopy();
                    if(Rule != null) dest.Rule = new List<Hl7.Fhir.Model.TestScript.RulesetRuleComponent>(Rule.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new RulesetComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RulesetComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Resource, otherT.Resource)) return false;
                if( !DeepComparable.Matches(Rule, otherT.Rule)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RulesetComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Resource, otherT.Resource)) return false;
                if( !DeepComparable.IsExactly(Rule, otherT.Rule)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("RulesetRuleComponent")]
        [DataContract]
        public partial class RulesetRuleComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "RulesetRuleComponent"; } }
            
            /// <summary>
            /// Id of referenced rule within the ruleset
            /// </summary>
            [FhirElement("ruleId", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Id RuleIdElement
            {
                get { return _RuleIdElement; }
                set { _RuleIdElement = value; OnPropertyChanged("RuleIdElement"); }
            }
            
            private Hl7.Fhir.Model.Id _RuleIdElement;
            
            /// <summary>
            /// Id of referenced rule within the ruleset
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string RuleId
            {
                get { return RuleIdElement != null ? RuleIdElement.Value : null; }
                set
                {
                    if(value == null)
                      RuleIdElement = null; 
                    else
                      RuleIdElement = new Hl7.Fhir.Model.Id(value);
                    OnPropertyChanged("RuleId");
                }
            }
            
            /// <summary>
            /// Ruleset rule parameter template
            /// </summary>
            [FhirElement("param", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.TestScript.RulesetRuleParamComponent> Param
            {
                get { if(_Param==null) _Param = new List<Hl7.Fhir.Model.TestScript.RulesetRuleParamComponent>(); return _Param; }
                set { _Param = value; OnPropertyChanged("Param"); }
            }
            
            private List<Hl7.Fhir.Model.TestScript.RulesetRuleParamComponent> _Param;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RulesetRuleComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(RuleIdElement != null) dest.RuleIdElement = (Hl7.Fhir.Model.Id)RuleIdElement.DeepCopy();
                    if(Param != null) dest.Param = new List<Hl7.Fhir.Model.TestScript.RulesetRuleParamComponent>(Param.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new RulesetRuleComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RulesetRuleComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(RuleIdElement, otherT.RuleIdElement)) return false;
                if( !DeepComparable.Matches(Param, otherT.Param)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RulesetRuleComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(RuleIdElement, otherT.RuleIdElement)) return false;
                if( !DeepComparable.IsExactly(Param, otherT.Param)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("RulesetRuleParamComponent")]
        [DataContract]
        public partial class RulesetRuleParamComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "RulesetRuleParamComponent"; } }
            
            /// <summary>
            /// Parameter name matching external assert ruleset rule parameter
            /// </summary>
            [FhirElement("name", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString NameElement
            {
                get { return _NameElement; }
                set { _NameElement = value; OnPropertyChanged("NameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _NameElement;
            
            /// <summary>
            /// Parameter name matching external assert ruleset rule parameter
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Name
            {
                get { return NameElement != null ? NameElement.Value : null; }
                set
                {
                    if(value == null)
                      NameElement = null; 
                    else
                      NameElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Name");
                }
            }
            
            /// <summary>
            /// Parameter value defined either explicitly or dynamically
            /// </summary>
            [FhirElement("value", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString ValueElement
            {
                get { return _ValueElement; }
                set { _ValueElement = value; OnPropertyChanged("ValueElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _ValueElement;
            
            /// <summary>
            /// Parameter value defined either explicitly or dynamically
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if(value == null)
                      ValueElement = null; 
                    else
                      ValueElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Value");
                }
            }
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RulesetRuleParamComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                    if(ValueElement != null) dest.ValueElement = (Hl7.Fhir.Model.FhirString)ValueElement.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new RulesetRuleParamComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RulesetRuleParamComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RulesetRuleParamComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("SetupComponent")]
        [DataContract]
        public partial class SetupComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "SetupComponent"; } }
            
            /// <summary>
            /// Capabilities  that are assumed to function correctly on the FHIR server being tested
            /// </summary>
            [FhirElement("metadata", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.TestScript.MetadataComponent Metadata
            {
                get { return _Metadata; }
                set { _Metadata = value; OnPropertyChanged("Metadata"); }
            }
            
            private Hl7.Fhir.Model.TestScript.MetadataComponent _Metadata;
            
            /// <summary>
            /// A setup operation or assert to perform
            /// </summary>
            [FhirElement("action", Order=50)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.TestScript.SetupActionComponent> Action
            {
                get { if(_Action==null) _Action = new List<Hl7.Fhir.Model.TestScript.SetupActionComponent>(); return _Action; }
                set { _Action = value; OnPropertyChanged("Action"); }
            }
            
            private List<Hl7.Fhir.Model.TestScript.SetupActionComponent> _Action;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SetupComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Metadata != null) dest.Metadata = (Hl7.Fhir.Model.TestScript.MetadataComponent)Metadata.DeepCopy();
                    if(Action != null) dest.Action = new List<Hl7.Fhir.Model.TestScript.SetupActionComponent>(Action.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new SetupComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SetupComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Metadata, otherT.Metadata)) return false;
                if( !DeepComparable.Matches(Action, otherT.Action)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SetupComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Metadata, otherT.Metadata)) return false;
                if( !DeepComparable.IsExactly(Action, otherT.Action)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("SetupActionComponent")]
        [DataContract]
        public partial class SetupActionComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "SetupActionComponent"; } }
            
            /// <summary>
            /// The setup operation to perform
            /// </summary>
            [FhirElement("operation", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.TestScript.OperationComponent Operation
            {
                get { return _Operation; }
                set { _Operation = value; OnPropertyChanged("Operation"); }
            }
            
            private Hl7.Fhir.Model.TestScript.OperationComponent _Operation;
            
            /// <summary>
            /// The assertion to perform
            /// </summary>
            [FhirElement("assert", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.TestScript.AssertComponent Assert
            {
                get { return _Assert; }
                set { _Assert = value; OnPropertyChanged("Assert"); }
            }
            
            private Hl7.Fhir.Model.TestScript.AssertComponent _Assert;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SetupActionComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Operation != null) dest.Operation = (Hl7.Fhir.Model.TestScript.OperationComponent)Operation.DeepCopy();
                    if(Assert != null) dest.Assert = (Hl7.Fhir.Model.TestScript.AssertComponent)Assert.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new SetupActionComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SetupActionComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Operation, otherT.Operation)) return false;
                if( !DeepComparable.Matches(Assert, otherT.Assert)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SetupActionComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Operation, otherT.Operation)) return false;
                if( !DeepComparable.IsExactly(Assert, otherT.Assert)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("OperationComponent")]
        [DataContract]
        public partial class OperationComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "OperationComponent"; } }
            
            /// <summary>
            /// The operation code type that will be executed
            /// </summary>
            [FhirElement("type", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.Coding Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.Coding _Type;
            
            /// <summary>
            /// Resource type
            /// </summary>
            [FhirElement("resource", Order=50)]
            [DataMember]
            public Code<Hl7.Fhir.Model.FHIRDefinedType> ResourceElement
            {
                get { return _ResourceElement; }
                set { _ResourceElement = value; OnPropertyChanged("ResourceElement"); }
            }
            
            private Code<Hl7.Fhir.Model.FHIRDefinedType> _ResourceElement;
            
            /// <summary>
            /// Resource type
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public Hl7.Fhir.Model.FHIRDefinedType? Resource
            {
                get { return ResourceElement != null ? ResourceElement.Value : null; }
                set
                {
                    if(value == null)
                      ResourceElement = null; 
                    else
                      ResourceElement = new Code<Hl7.Fhir.Model.FHIRDefinedType>(value);
                    OnPropertyChanged("Resource");
                }
            }
            
            /// <summary>
            /// Tracking/logging operation label
            /// </summary>
            [FhirElement("label", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString LabelElement
            {
                get { return _LabelElement; }
                set { _LabelElement = value; OnPropertyChanged("LabelElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _LabelElement;
            
            /// <summary>
            /// Tracking/logging operation label
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Label
            {
                get { return LabelElement != null ? LabelElement.Value : null; }
                set
                {
                    if(value == null)
                      LabelElement = null; 
                    else
                      LabelElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Label");
                }
            }
            
            /// <summary>
            /// Tracking/reporting operation description
            /// </summary>
            [FhirElement("description", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString DescriptionElement
            {
                get { return _DescriptionElement; }
                set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _DescriptionElement;
            
            /// <summary>
            /// Tracking/reporting operation description
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Description
            {
                get { return DescriptionElement != null ? DescriptionElement.Value : null; }
                set
                {
                    if(value == null)
                      DescriptionElement = null; 
                    else
                      DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Description");
                }
            }
            
            /// <summary>
            /// xml | json | ttl | none
            /// </summary>
            [FhirElement("accept", Order=80)]
            [DataMember]
            public Code<Hl7.Fhir.Model.TestScript.ContentType> AcceptElement
            {
                get { return _AcceptElement; }
                set { _AcceptElement = value; OnPropertyChanged("AcceptElement"); }
            }
            
            private Code<Hl7.Fhir.Model.TestScript.ContentType> _AcceptElement;
            
            /// <summary>
            /// xml | json | ttl | none
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public Hl7.Fhir.Model.TestScript.ContentType? Accept
            {
                get { return AcceptElement != null ? AcceptElement.Value : null; }
                set
                {
                    if(value == null)
                      AcceptElement = null; 
                    else
                      AcceptElement = new Code<Hl7.Fhir.Model.TestScript.ContentType>(value);
                    OnPropertyChanged("Accept");
                }
            }
            
            /// <summary>
            /// xml | json | ttl | none
            /// </summary>
            [FhirElement("contentType", Order=90)]
            [DataMember]
            public Code<Hl7.Fhir.Model.TestScript.ContentType> ContentType_Element
            {
                get { return _ContentType_Element; }
                set { _ContentType_Element = value; OnPropertyChanged("ContentType_Element"); }
            }
            
            private Code<Hl7.Fhir.Model.TestScript.ContentType> _ContentType_Element;
            
            /// <summary>
            /// xml | json | ttl | none
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public Hl7.Fhir.Model.TestScript.ContentType? ContentType_
            {
                get { return ContentType_Element != null ? ContentType_Element.Value : null; }
                set
                {
                    if(value == null)
                      ContentType_Element = null; 
                    else
                      ContentType_Element = new Code<Hl7.Fhir.Model.TestScript.ContentType>(value);
                    OnPropertyChanged("ContentType_");
                }
            }
            
            /// <summary>
            /// Server responding to the request
            /// </summary>
            [FhirElement("destination", Order=100)]
            [DataMember]
            public Hl7.Fhir.Model.Integer DestinationElement
            {
                get { return _DestinationElement; }
                set { _DestinationElement = value; OnPropertyChanged("DestinationElement"); }
            }
            
            private Hl7.Fhir.Model.Integer _DestinationElement;
            
            /// <summary>
            /// Server responding to the request
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public int? Destination
            {
                get { return DestinationElement != null ? DestinationElement.Value : null; }
                set
                {
                    if(value == null)
                      DestinationElement = null; 
                    else
                      DestinationElement = new Hl7.Fhir.Model.Integer(value);
                    OnPropertyChanged("Destination");
                }
            }
            
            /// <summary>
            /// Whether or not to send the request url in encoded format
            /// </summary>
            [FhirElement("encodeRequestUrl", Order=110)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean EncodeRequestUrlElement
            {
                get { return _EncodeRequestUrlElement; }
                set { _EncodeRequestUrlElement = value; OnPropertyChanged("EncodeRequestUrlElement"); }
            }
            
            private Hl7.Fhir.Model.FhirBoolean _EncodeRequestUrlElement;
            
            /// <summary>
            /// Whether or not to send the request url in encoded format
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? EncodeRequestUrl
            {
                get { return EncodeRequestUrlElement != null ? EncodeRequestUrlElement.Value : null; }
                set
                {
                    if(value == null)
                      EncodeRequestUrlElement = null; 
                    else
                      EncodeRequestUrlElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("EncodeRequestUrl");
                }
            }
            
            /// <summary>
            /// Server initiating the request
            /// </summary>
            [FhirElement("origin", Order=120)]
            [DataMember]
            public Hl7.Fhir.Model.Integer OriginElement
            {
                get { return _OriginElement; }
                set { _OriginElement = value; OnPropertyChanged("OriginElement"); }
            }
            
            private Hl7.Fhir.Model.Integer _OriginElement;
            
            /// <summary>
            /// Server initiating the request
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public int? Origin
            {
                get { return OriginElement != null ? OriginElement.Value : null; }
                set
                {
                    if(value == null)
                      OriginElement = null; 
                    else
                      OriginElement = new Hl7.Fhir.Model.Integer(value);
                    OnPropertyChanged("Origin");
                }
            }
            
            /// <summary>
            /// Explicitly defined path parameters
            /// </summary>
            [FhirElement("params", Order=130)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString ParamsElement
            {
                get { return _ParamsElement; }
                set { _ParamsElement = value; OnPropertyChanged("ParamsElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _ParamsElement;
            
            /// <summary>
            /// Explicitly defined path parameters
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Params
            {
                get { return ParamsElement != null ? ParamsElement.Value : null; }
                set
                {
                    if(value == null)
                      ParamsElement = null; 
                    else
                      ParamsElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Params");
                }
            }
            
            /// <summary>
            /// Each operation can have one ore more header elements
            /// </summary>
            [FhirElement("requestHeader", Order=140)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.TestScript.RequestHeaderComponent> RequestHeader
            {
                get { if(_RequestHeader==null) _RequestHeader = new List<Hl7.Fhir.Model.TestScript.RequestHeaderComponent>(); return _RequestHeader; }
                set { _RequestHeader = value; OnPropertyChanged("RequestHeader"); }
            }
            
            private List<Hl7.Fhir.Model.TestScript.RequestHeaderComponent> _RequestHeader;
            
            /// <summary>
            /// Fixture Id of mapped response
            /// </summary>
            [FhirElement("responseId", Order=150)]
            [DataMember]
            public Hl7.Fhir.Model.Id ResponseIdElement
            {
                get { return _ResponseIdElement; }
                set { _ResponseIdElement = value; OnPropertyChanged("ResponseIdElement"); }
            }
            
            private Hl7.Fhir.Model.Id _ResponseIdElement;
            
            /// <summary>
            /// Fixture Id of mapped response
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string ResponseId
            {
                get { return ResponseIdElement != null ? ResponseIdElement.Value : null; }
                set
                {
                    if(value == null)
                      ResponseIdElement = null; 
                    else
                      ResponseIdElement = new Hl7.Fhir.Model.Id(value);
                    OnPropertyChanged("ResponseId");
                }
            }
            
            /// <summary>
            /// Fixture Id of body for PUT and POST requests
            /// </summary>
            [FhirElement("sourceId", Order=160)]
            [DataMember]
            public Hl7.Fhir.Model.Id SourceIdElement
            {
                get { return _SourceIdElement; }
                set { _SourceIdElement = value; OnPropertyChanged("SourceIdElement"); }
            }
            
            private Hl7.Fhir.Model.Id _SourceIdElement;
            
            /// <summary>
            /// Fixture Id of body for PUT and POST requests
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string SourceId
            {
                get { return SourceIdElement != null ? SourceIdElement.Value : null; }
                set
                {
                    if(value == null)
                      SourceIdElement = null; 
                    else
                      SourceIdElement = new Hl7.Fhir.Model.Id(value);
                    OnPropertyChanged("SourceId");
                }
            }
            
            /// <summary>
            /// Id of fixture used for extracting the [id],  [type], and [vid] for GET requests
            /// </summary>
            [FhirElement("targetId", Order=170)]
            [DataMember]
            public Hl7.Fhir.Model.Id TargetIdElement
            {
                get { return _TargetIdElement; }
                set { _TargetIdElement = value; OnPropertyChanged("TargetIdElement"); }
            }
            
            private Hl7.Fhir.Model.Id _TargetIdElement;
            
            /// <summary>
            /// Id of fixture used for extracting the [id],  [type], and [vid] for GET requests
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string TargetId
            {
                get { return TargetIdElement != null ? TargetIdElement.Value : null; }
                set
                {
                    if(value == null)
                      TargetIdElement = null; 
                    else
                      TargetIdElement = new Hl7.Fhir.Model.Id(value);
                    OnPropertyChanged("TargetId");
                }
            }
            
            /// <summary>
            /// Request URL
            /// </summary>
            [FhirElement("url", Order=180)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString UrlElement
            {
                get { return _UrlElement; }
                set { _UrlElement = value; OnPropertyChanged("UrlElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _UrlElement;
            
            /// <summary>
            /// Request URL
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
                      UrlElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Url");
                }
            }
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as OperationComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.Coding)Type.DeepCopy();
                    if(ResourceElement != null) dest.ResourceElement = (Code<Hl7.Fhir.Model.FHIRDefinedType>)ResourceElement.DeepCopy();
                    if(LabelElement != null) dest.LabelElement = (Hl7.Fhir.Model.FhirString)LabelElement.DeepCopy();
                    if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
                    if(AcceptElement != null) dest.AcceptElement = (Code<Hl7.Fhir.Model.TestScript.ContentType>)AcceptElement.DeepCopy();
                    if(ContentType_Element != null) dest.ContentType_Element = (Code<Hl7.Fhir.Model.TestScript.ContentType>)ContentType_Element.DeepCopy();
                    if(DestinationElement != null) dest.DestinationElement = (Hl7.Fhir.Model.Integer)DestinationElement.DeepCopy();
                    if(EncodeRequestUrlElement != null) dest.EncodeRequestUrlElement = (Hl7.Fhir.Model.FhirBoolean)EncodeRequestUrlElement.DeepCopy();
                    if(OriginElement != null) dest.OriginElement = (Hl7.Fhir.Model.Integer)OriginElement.DeepCopy();
                    if(ParamsElement != null) dest.ParamsElement = (Hl7.Fhir.Model.FhirString)ParamsElement.DeepCopy();
                    if(RequestHeader != null) dest.RequestHeader = new List<Hl7.Fhir.Model.TestScript.RequestHeaderComponent>(RequestHeader.DeepCopy());
                    if(ResponseIdElement != null) dest.ResponseIdElement = (Hl7.Fhir.Model.Id)ResponseIdElement.DeepCopy();
                    if(SourceIdElement != null) dest.SourceIdElement = (Hl7.Fhir.Model.Id)SourceIdElement.DeepCopy();
                    if(TargetIdElement != null) dest.TargetIdElement = (Hl7.Fhir.Model.Id)TargetIdElement.DeepCopy();
                    if(UrlElement != null) dest.UrlElement = (Hl7.Fhir.Model.FhirString)UrlElement.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new OperationComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as OperationComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(ResourceElement, otherT.ResourceElement)) return false;
                if( !DeepComparable.Matches(LabelElement, otherT.LabelElement)) return false;
                if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.Matches(AcceptElement, otherT.AcceptElement)) return false;
                if( !DeepComparable.Matches(ContentType_Element, otherT.ContentType_Element)) return false;
                if( !DeepComparable.Matches(DestinationElement, otherT.DestinationElement)) return false;
                if( !DeepComparable.Matches(EncodeRequestUrlElement, otherT.EncodeRequestUrlElement)) return false;
                if( !DeepComparable.Matches(OriginElement, otherT.OriginElement)) return false;
                if( !DeepComparable.Matches(ParamsElement, otherT.ParamsElement)) return false;
                if( !DeepComparable.Matches(RequestHeader, otherT.RequestHeader)) return false;
                if( !DeepComparable.Matches(ResponseIdElement, otherT.ResponseIdElement)) return false;
                if( !DeepComparable.Matches(SourceIdElement, otherT.SourceIdElement)) return false;
                if( !DeepComparable.Matches(TargetIdElement, otherT.TargetIdElement)) return false;
                if( !DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as OperationComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(ResourceElement, otherT.ResourceElement)) return false;
                if( !DeepComparable.IsExactly(LabelElement, otherT.LabelElement)) return false;
                if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.IsExactly(AcceptElement, otherT.AcceptElement)) return false;
                if( !DeepComparable.IsExactly(ContentType_Element, otherT.ContentType_Element)) return false;
                if( !DeepComparable.IsExactly(DestinationElement, otherT.DestinationElement)) return false;
                if( !DeepComparable.IsExactly(EncodeRequestUrlElement, otherT.EncodeRequestUrlElement)) return false;
                if( !DeepComparable.IsExactly(OriginElement, otherT.OriginElement)) return false;
                if( !DeepComparable.IsExactly(ParamsElement, otherT.ParamsElement)) return false;
                if( !DeepComparable.IsExactly(RequestHeader, otherT.RequestHeader)) return false;
                if( !DeepComparable.IsExactly(ResponseIdElement, otherT.ResponseIdElement)) return false;
                if( !DeepComparable.IsExactly(SourceIdElement, otherT.SourceIdElement)) return false;
                if( !DeepComparable.IsExactly(TargetIdElement, otherT.TargetIdElement)) return false;
                if( !DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("RequestHeaderComponent")]
        [DataContract]
        public partial class RequestHeaderComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "RequestHeaderComponent"; } }
            
            /// <summary>
            /// HTTP header field name
            /// </summary>
            [FhirElement("field", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString FieldElement
            {
                get { return _FieldElement; }
                set { _FieldElement = value; OnPropertyChanged("FieldElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _FieldElement;
            
            /// <summary>
            /// HTTP header field name
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Field
            {
                get { return FieldElement != null ? FieldElement.Value : null; }
                set
                {
                    if(value == null)
                      FieldElement = null; 
                    else
                      FieldElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Field");
                }
            }
            
            /// <summary>
            /// HTTP headerfield value
            /// </summary>
            [FhirElement("value", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString ValueElement
            {
                get { return _ValueElement; }
                set { _ValueElement = value; OnPropertyChanged("ValueElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _ValueElement;
            
            /// <summary>
            /// HTTP headerfield value
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if(value == null)
                      ValueElement = null; 
                    else
                      ValueElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Value");
                }
            }
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RequestHeaderComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(FieldElement != null) dest.FieldElement = (Hl7.Fhir.Model.FhirString)FieldElement.DeepCopy();
                    if(ValueElement != null) dest.ValueElement = (Hl7.Fhir.Model.FhirString)ValueElement.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new RequestHeaderComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RequestHeaderComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(FieldElement, otherT.FieldElement)) return false;
                if( !DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RequestHeaderComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(FieldElement, otherT.FieldElement)) return false;
                if( !DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("AssertComponent")]
        [DataContract]
        public partial class AssertComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "AssertComponent"; } }
            
            /// <summary>
            /// Tracking/logging assertion label
            /// </summary>
            [FhirElement("label", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString LabelElement
            {
                get { return _LabelElement; }
                set { _LabelElement = value; OnPropertyChanged("LabelElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _LabelElement;
            
            /// <summary>
            /// Tracking/logging assertion label
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Label
            {
                get { return LabelElement != null ? LabelElement.Value : null; }
                set
                {
                    if(value == null)
                      LabelElement = null; 
                    else
                      LabelElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Label");
                }
            }
            
            /// <summary>
            /// Tracking/reporting assertion description
            /// </summary>
            [FhirElement("description", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString DescriptionElement
            {
                get { return _DescriptionElement; }
                set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _DescriptionElement;
            
            /// <summary>
            /// Tracking/reporting assertion description
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Description
            {
                get { return DescriptionElement != null ? DescriptionElement.Value : null; }
                set
                {
                    if(value == null)
                      DescriptionElement = null; 
                    else
                      DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Description");
                }
            }
            
            /// <summary>
            /// response | request
            /// </summary>
            [FhirElement("direction", Order=60)]
            [DataMember]
            public Code<Hl7.Fhir.Model.TestScript.AssertionDirectionType> DirectionElement
            {
                get { return _DirectionElement; }
                set { _DirectionElement = value; OnPropertyChanged("DirectionElement"); }
            }
            
            private Code<Hl7.Fhir.Model.TestScript.AssertionDirectionType> _DirectionElement;
            
            /// <summary>
            /// response | request
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public Hl7.Fhir.Model.TestScript.AssertionDirectionType? Direction
            {
                get { return DirectionElement != null ? DirectionElement.Value : null; }
                set
                {
                    if(value == null)
                      DirectionElement = null; 
                    else
                      DirectionElement = new Code<Hl7.Fhir.Model.TestScript.AssertionDirectionType>(value);
                    OnPropertyChanged("Direction");
                }
            }
            
            /// <summary>
            /// Id of fixture used to compare the "sourceId/path" evaluations to
            /// </summary>
            [FhirElement("compareToSourceId", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString CompareToSourceIdElement
            {
                get { return _CompareToSourceIdElement; }
                set { _CompareToSourceIdElement = value; OnPropertyChanged("CompareToSourceIdElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _CompareToSourceIdElement;
            
            /// <summary>
            /// Id of fixture used to compare the "sourceId/path" evaluations to
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string CompareToSourceId
            {
                get { return CompareToSourceIdElement != null ? CompareToSourceIdElement.Value : null; }
                set
                {
                    if(value == null)
                      CompareToSourceIdElement = null; 
                    else
                      CompareToSourceIdElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("CompareToSourceId");
                }
            }
            
            /// <summary>
            /// XPath or JSONPath expression against fixture used to compare the "sourceId/path" evaluations to
            /// </summary>
            [FhirElement("compareToSourcePath", Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString CompareToSourcePathElement
            {
                get { return _CompareToSourcePathElement; }
                set { _CompareToSourcePathElement = value; OnPropertyChanged("CompareToSourcePathElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _CompareToSourcePathElement;
            
            /// <summary>
            /// XPath or JSONPath expression against fixture used to compare the "sourceId/path" evaluations to
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string CompareToSourcePath
            {
                get { return CompareToSourcePathElement != null ? CompareToSourcePathElement.Value : null; }
                set
                {
                    if(value == null)
                      CompareToSourcePathElement = null; 
                    else
                      CompareToSourcePathElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("CompareToSourcePath");
                }
            }
            
            /// <summary>
            /// xml | json | ttl | none
            /// </summary>
            [FhirElement("contentType", Order=90)]
            [DataMember]
            public Code<Hl7.Fhir.Model.TestScript.ContentType> ContentType_Element
            {
                get { return _ContentType_Element; }
                set { _ContentType_Element = value; OnPropertyChanged("ContentType_Element"); }
            }
            
            private Code<Hl7.Fhir.Model.TestScript.ContentType> _ContentType_Element;
            
            /// <summary>
            /// xml | json | ttl | none
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public Hl7.Fhir.Model.TestScript.ContentType? ContentType_
            {
                get { return ContentType_Element != null ? ContentType_Element.Value : null; }
                set
                {
                    if(value == null)
                      ContentType_Element = null; 
                    else
                      ContentType_Element = new Code<Hl7.Fhir.Model.TestScript.ContentType>(value);
                    OnPropertyChanged("ContentType_");
                }
            }
            
            /// <summary>
            /// HTTP header field name
            /// </summary>
            [FhirElement("headerField", Order=100)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString HeaderFieldElement
            {
                get { return _HeaderFieldElement; }
                set { _HeaderFieldElement = value; OnPropertyChanged("HeaderFieldElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _HeaderFieldElement;
            
            /// <summary>
            /// HTTP header field name
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string HeaderField
            {
                get { return HeaderFieldElement != null ? HeaderFieldElement.Value : null; }
                set
                {
                    if(value == null)
                      HeaderFieldElement = null; 
                    else
                      HeaderFieldElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("HeaderField");
                }
            }
            
            /// <summary>
            /// Fixture Id of minimum content resource
            /// </summary>
            [FhirElement("minimumId", Order=110)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString MinimumIdElement
            {
                get { return _MinimumIdElement; }
                set { _MinimumIdElement = value; OnPropertyChanged("MinimumIdElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _MinimumIdElement;
            
            /// <summary>
            /// Fixture Id of minimum content resource
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string MinimumId
            {
                get { return MinimumIdElement != null ? MinimumIdElement.Value : null; }
                set
                {
                    if(value == null)
                      MinimumIdElement = null; 
                    else
                      MinimumIdElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("MinimumId");
                }
            }
            
            /// <summary>
            /// Perform validation on navigation links?
            /// </summary>
            [FhirElement("navigationLinks", Order=120)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean NavigationLinksElement
            {
                get { return _NavigationLinksElement; }
                set { _NavigationLinksElement = value; OnPropertyChanged("NavigationLinksElement"); }
            }
            
            private Hl7.Fhir.Model.FhirBoolean _NavigationLinksElement;
            
            /// <summary>
            /// Perform validation on navigation links?
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? NavigationLinks
            {
                get { return NavigationLinksElement != null ? NavigationLinksElement.Value : null; }
                set
                {
                    if(value == null)
                      NavigationLinksElement = null; 
                    else
                      NavigationLinksElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("NavigationLinks");
                }
            }
            
            /// <summary>
            /// equals | notEquals | in | notIn | greaterThan | lessThan | empty | notEmpty | contains | notContains
            /// </summary>
            [FhirElement("operator", Order=130)]
            [DataMember]
            public Code<Hl7.Fhir.Model.TestScript.AssertionOperatorType> OperatorElement
            {
                get { return _OperatorElement; }
                set { _OperatorElement = value; OnPropertyChanged("OperatorElement"); }
            }
            
            private Code<Hl7.Fhir.Model.TestScript.AssertionOperatorType> _OperatorElement;
            
            /// <summary>
            /// equals | notEquals | in | notIn | greaterThan | lessThan | empty | notEmpty | contains | notContains
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public Hl7.Fhir.Model.TestScript.AssertionOperatorType? Operator
            {
                get { return OperatorElement != null ? OperatorElement.Value : null; }
                set
                {
                    if(value == null)
                      OperatorElement = null; 
                    else
                      OperatorElement = new Code<Hl7.Fhir.Model.TestScript.AssertionOperatorType>(value);
                    OnPropertyChanged("Operator");
                }
            }
            
            /// <summary>
            /// XPath or JSONPath expression
            /// </summary>
            [FhirElement("path", Order=140)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString PathElement
            {
                get { return _PathElement; }
                set { _PathElement = value; OnPropertyChanged("PathElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _PathElement;
            
            /// <summary>
            /// XPath or JSONPath expression
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Path
            {
                get { return PathElement != null ? PathElement.Value : null; }
                set
                {
                    if(value == null)
                      PathElement = null; 
                    else
                      PathElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Path");
                }
            }
            
            /// <summary>
            /// Request URL comparison value
            /// </summary>
            [FhirElement("requestURL", Order=150)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString RequestURLElement
            {
                get { return _RequestURLElement; }
                set { _RequestURLElement = value; OnPropertyChanged("RequestURLElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _RequestURLElement;
            
            /// <summary>
            /// Request URL comparison value
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string RequestURL
            {
                get { return RequestURLElement != null ? RequestURLElement.Value : null; }
                set
                {
                    if(value == null)
                      RequestURLElement = null; 
                    else
                      RequestURLElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("RequestURL");
                }
            }
            
            /// <summary>
            /// Resource type
            /// </summary>
            [FhirElement("resource", Order=160)]
            [DataMember]
            public Code<Hl7.Fhir.Model.FHIRDefinedType> ResourceElement
            {
                get { return _ResourceElement; }
                set { _ResourceElement = value; OnPropertyChanged("ResourceElement"); }
            }
            
            private Code<Hl7.Fhir.Model.FHIRDefinedType> _ResourceElement;
            
            /// <summary>
            /// Resource type
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public Hl7.Fhir.Model.FHIRDefinedType? Resource
            {
                get { return ResourceElement != null ? ResourceElement.Value : null; }
                set
                {
                    if(value == null)
                      ResourceElement = null; 
                    else
                      ResourceElement = new Code<Hl7.Fhir.Model.FHIRDefinedType>(value);
                    OnPropertyChanged("Resource");
                }
            }
            
            /// <summary>
            /// okay | created | noContent | notModified | bad | forbidden | notFound | methodNotAllowed | conflict | gone | preconditionFailed | unprocessable
            /// </summary>
            [FhirElement("response", Order=170)]
            [DataMember]
            public Code<Hl7.Fhir.Model.TestScript.AssertionResponseTypes> ResponseElement
            {
                get { return _ResponseElement; }
                set { _ResponseElement = value; OnPropertyChanged("ResponseElement"); }
            }
            
            private Code<Hl7.Fhir.Model.TestScript.AssertionResponseTypes> _ResponseElement;
            
            /// <summary>
            /// okay | created | noContent | notModified | bad | forbidden | notFound | methodNotAllowed | conflict | gone | preconditionFailed | unprocessable
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public Hl7.Fhir.Model.TestScript.AssertionResponseTypes? Response
            {
                get { return ResponseElement != null ? ResponseElement.Value : null; }
                set
                {
                    if(value == null)
                      ResponseElement = null; 
                    else
                      ResponseElement = new Code<Hl7.Fhir.Model.TestScript.AssertionResponseTypes>(value);
                    OnPropertyChanged("Response");
                }
            }
            
            /// <summary>
            /// HTTP response code to test
            /// </summary>
            [FhirElement("responseCode", Order=180)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString ResponseCodeElement
            {
                get { return _ResponseCodeElement; }
                set { _ResponseCodeElement = value; OnPropertyChanged("ResponseCodeElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _ResponseCodeElement;
            
            /// <summary>
            /// HTTP response code to test
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string ResponseCode
            {
                get { return ResponseCodeElement != null ? ResponseCodeElement.Value : null; }
                set
                {
                    if(value == null)
                      ResponseCodeElement = null; 
                    else
                      ResponseCodeElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("ResponseCode");
                }
            }
            
            /// <summary>
            /// The reference to a TestScript.rule
            /// </summary>
            [FhirElement("rule", Order=190)]
            [DataMember]
            public Hl7.Fhir.Model.TestScript.ActionAssertRuleComponent Rule
            {
                get { return _Rule; }
                set { _Rule = value; OnPropertyChanged("Rule"); }
            }
            
            private Hl7.Fhir.Model.TestScript.ActionAssertRuleComponent _Rule;
            
            /// <summary>
            /// The reference to a TestScript.ruleset
            /// </summary>
            [FhirElement("ruleset", Order=200)]
            [DataMember]
            public Hl7.Fhir.Model.TestScript.ActionAssertRulesetComponent Ruleset
            {
                get { return _Ruleset; }
                set { _Ruleset = value; OnPropertyChanged("Ruleset"); }
            }
            
            private Hl7.Fhir.Model.TestScript.ActionAssertRulesetComponent _Ruleset;
            
            /// <summary>
            /// Fixture Id of source expression or headerField
            /// </summary>
            [FhirElement("sourceId", Order=210)]
            [DataMember]
            public Hl7.Fhir.Model.Id SourceIdElement
            {
                get { return _SourceIdElement; }
                set { _SourceIdElement = value; OnPropertyChanged("SourceIdElement"); }
            }
            
            private Hl7.Fhir.Model.Id _SourceIdElement;
            
            /// <summary>
            /// Fixture Id of source expression or headerField
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string SourceId
            {
                get { return SourceIdElement != null ? SourceIdElement.Value : null; }
                set
                {
                    if(value == null)
                      SourceIdElement = null; 
                    else
                      SourceIdElement = new Hl7.Fhir.Model.Id(value);
                    OnPropertyChanged("SourceId");
                }
            }
            
            /// <summary>
            /// Profile Id of validation profile reference
            /// </summary>
            [FhirElement("validateProfileId", Order=220)]
            [DataMember]
            public Hl7.Fhir.Model.Id ValidateProfileIdElement
            {
                get { return _ValidateProfileIdElement; }
                set { _ValidateProfileIdElement = value; OnPropertyChanged("ValidateProfileIdElement"); }
            }
            
            private Hl7.Fhir.Model.Id _ValidateProfileIdElement;
            
            /// <summary>
            /// Profile Id of validation profile reference
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string ValidateProfileId
            {
                get { return ValidateProfileIdElement != null ? ValidateProfileIdElement.Value : null; }
                set
                {
                    if(value == null)
                      ValidateProfileIdElement = null; 
                    else
                      ValidateProfileIdElement = new Hl7.Fhir.Model.Id(value);
                    OnPropertyChanged("ValidateProfileId");
                }
            }
            
            /// <summary>
            /// The value to compare to
            /// </summary>
            [FhirElement("value", Order=230)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString ValueElement
            {
                get { return _ValueElement; }
                set { _ValueElement = value; OnPropertyChanged("ValueElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _ValueElement;
            
            /// <summary>
            /// The value to compare to
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if(value == null)
                      ValueElement = null; 
                    else
                      ValueElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Value");
                }
            }
            
            /// <summary>
            /// Will this assert produce a warning only on error?
            /// </summary>
            [FhirElement("warningOnly", Order=240)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean WarningOnlyElement
            {
                get { return _WarningOnlyElement; }
                set { _WarningOnlyElement = value; OnPropertyChanged("WarningOnlyElement"); }
            }
            
            private Hl7.Fhir.Model.FhirBoolean _WarningOnlyElement;
            
            /// <summary>
            /// Will this assert produce a warning only on error?
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? WarningOnly
            {
                get { return WarningOnlyElement != null ? WarningOnlyElement.Value : null; }
                set
                {
                    if(value == null)
                      WarningOnlyElement = null; 
                    else
                      WarningOnlyElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("WarningOnly");
                }
            }
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AssertComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(LabelElement != null) dest.LabelElement = (Hl7.Fhir.Model.FhirString)LabelElement.DeepCopy();
                    if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
                    if(DirectionElement != null) dest.DirectionElement = (Code<Hl7.Fhir.Model.TestScript.AssertionDirectionType>)DirectionElement.DeepCopy();
                    if(CompareToSourceIdElement != null) dest.CompareToSourceIdElement = (Hl7.Fhir.Model.FhirString)CompareToSourceIdElement.DeepCopy();
                    if(CompareToSourcePathElement != null) dest.CompareToSourcePathElement = (Hl7.Fhir.Model.FhirString)CompareToSourcePathElement.DeepCopy();
                    if(ContentType_Element != null) dest.ContentType_Element = (Code<Hl7.Fhir.Model.TestScript.ContentType>)ContentType_Element.DeepCopy();
                    if(HeaderFieldElement != null) dest.HeaderFieldElement = (Hl7.Fhir.Model.FhirString)HeaderFieldElement.DeepCopy();
                    if(MinimumIdElement != null) dest.MinimumIdElement = (Hl7.Fhir.Model.FhirString)MinimumIdElement.DeepCopy();
                    if(NavigationLinksElement != null) dest.NavigationLinksElement = (Hl7.Fhir.Model.FhirBoolean)NavigationLinksElement.DeepCopy();
                    if(OperatorElement != null) dest.OperatorElement = (Code<Hl7.Fhir.Model.TestScript.AssertionOperatorType>)OperatorElement.DeepCopy();
                    if(PathElement != null) dest.PathElement = (Hl7.Fhir.Model.FhirString)PathElement.DeepCopy();
                    if(RequestURLElement != null) dest.RequestURLElement = (Hl7.Fhir.Model.FhirString)RequestURLElement.DeepCopy();
                    if(ResourceElement != null) dest.ResourceElement = (Code<Hl7.Fhir.Model.FHIRDefinedType>)ResourceElement.DeepCopy();
                    if(ResponseElement != null) dest.ResponseElement = (Code<Hl7.Fhir.Model.TestScript.AssertionResponseTypes>)ResponseElement.DeepCopy();
                    if(ResponseCodeElement != null) dest.ResponseCodeElement = (Hl7.Fhir.Model.FhirString)ResponseCodeElement.DeepCopy();
                    if(Rule != null) dest.Rule = (Hl7.Fhir.Model.TestScript.ActionAssertRuleComponent)Rule.DeepCopy();
                    if(Ruleset != null) dest.Ruleset = (Hl7.Fhir.Model.TestScript.ActionAssertRulesetComponent)Ruleset.DeepCopy();
                    if(SourceIdElement != null) dest.SourceIdElement = (Hl7.Fhir.Model.Id)SourceIdElement.DeepCopy();
                    if(ValidateProfileIdElement != null) dest.ValidateProfileIdElement = (Hl7.Fhir.Model.Id)ValidateProfileIdElement.DeepCopy();
                    if(ValueElement != null) dest.ValueElement = (Hl7.Fhir.Model.FhirString)ValueElement.DeepCopy();
                    if(WarningOnlyElement != null) dest.WarningOnlyElement = (Hl7.Fhir.Model.FhirBoolean)WarningOnlyElement.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new AssertComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AssertComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(LabelElement, otherT.LabelElement)) return false;
                if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.Matches(DirectionElement, otherT.DirectionElement)) return false;
                if( !DeepComparable.Matches(CompareToSourceIdElement, otherT.CompareToSourceIdElement)) return false;
                if( !DeepComparable.Matches(CompareToSourcePathElement, otherT.CompareToSourcePathElement)) return false;
                if( !DeepComparable.Matches(ContentType_Element, otherT.ContentType_Element)) return false;
                if( !DeepComparable.Matches(HeaderFieldElement, otherT.HeaderFieldElement)) return false;
                if( !DeepComparable.Matches(MinimumIdElement, otherT.MinimumIdElement)) return false;
                if( !DeepComparable.Matches(NavigationLinksElement, otherT.NavigationLinksElement)) return false;
                if( !DeepComparable.Matches(OperatorElement, otherT.OperatorElement)) return false;
                if( !DeepComparable.Matches(PathElement, otherT.PathElement)) return false;
                if( !DeepComparable.Matches(RequestURLElement, otherT.RequestURLElement)) return false;
                if( !DeepComparable.Matches(ResourceElement, otherT.ResourceElement)) return false;
                if( !DeepComparable.Matches(ResponseElement, otherT.ResponseElement)) return false;
                if( !DeepComparable.Matches(ResponseCodeElement, otherT.ResponseCodeElement)) return false;
                if( !DeepComparable.Matches(Rule, otherT.Rule)) return false;
                if( !DeepComparable.Matches(Ruleset, otherT.Ruleset)) return false;
                if( !DeepComparable.Matches(SourceIdElement, otherT.SourceIdElement)) return false;
                if( !DeepComparable.Matches(ValidateProfileIdElement, otherT.ValidateProfileIdElement)) return false;
                if( !DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;
                if( !DeepComparable.Matches(WarningOnlyElement, otherT.WarningOnlyElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AssertComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(LabelElement, otherT.LabelElement)) return false;
                if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.IsExactly(DirectionElement, otherT.DirectionElement)) return false;
                if( !DeepComparable.IsExactly(CompareToSourceIdElement, otherT.CompareToSourceIdElement)) return false;
                if( !DeepComparable.IsExactly(CompareToSourcePathElement, otherT.CompareToSourcePathElement)) return false;
                if( !DeepComparable.IsExactly(ContentType_Element, otherT.ContentType_Element)) return false;
                if( !DeepComparable.IsExactly(HeaderFieldElement, otherT.HeaderFieldElement)) return false;
                if( !DeepComparable.IsExactly(MinimumIdElement, otherT.MinimumIdElement)) return false;
                if( !DeepComparable.IsExactly(NavigationLinksElement, otherT.NavigationLinksElement)) return false;
                if( !DeepComparable.IsExactly(OperatorElement, otherT.OperatorElement)) return false;
                if( !DeepComparable.IsExactly(PathElement, otherT.PathElement)) return false;
                if( !DeepComparable.IsExactly(RequestURLElement, otherT.RequestURLElement)) return false;
                if( !DeepComparable.IsExactly(ResourceElement, otherT.ResourceElement)) return false;
                if( !DeepComparable.IsExactly(ResponseElement, otherT.ResponseElement)) return false;
                if( !DeepComparable.IsExactly(ResponseCodeElement, otherT.ResponseCodeElement)) return false;
                if( !DeepComparable.IsExactly(Rule, otherT.Rule)) return false;
                if( !DeepComparable.IsExactly(Ruleset, otherT.Ruleset)) return false;
                if( !DeepComparable.IsExactly(SourceIdElement, otherT.SourceIdElement)) return false;
                if( !DeepComparable.IsExactly(ValidateProfileIdElement, otherT.ValidateProfileIdElement)) return false;
                if( !DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;
                if( !DeepComparable.IsExactly(WarningOnlyElement, otherT.WarningOnlyElement)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("ActionAssertRuleComponent")]
        [DataContract]
        public partial class ActionAssertRuleComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ActionAssertRuleComponent"; } }
            
            /// <summary>
            /// Id of the TestScript.rule
            /// </summary>
            [FhirElement("ruleId", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Id RuleIdElement
            {
                get { return _RuleIdElement; }
                set { _RuleIdElement = value; OnPropertyChanged("RuleIdElement"); }
            }
            
            private Hl7.Fhir.Model.Id _RuleIdElement;
            
            /// <summary>
            /// Id of the TestScript.rule
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string RuleId
            {
                get { return RuleIdElement != null ? RuleIdElement.Value : null; }
                set
                {
                    if(value == null)
                      RuleIdElement = null; 
                    else
                      RuleIdElement = new Hl7.Fhir.Model.Id(value);
                    OnPropertyChanged("RuleId");
                }
            }
            
            /// <summary>
            /// Rule parameter template
            /// </summary>
            [FhirElement("param", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.TestScript.ActionAssertRuleParamComponent> Param
            {
                get { if(_Param==null) _Param = new List<Hl7.Fhir.Model.TestScript.ActionAssertRuleParamComponent>(); return _Param; }
                set { _Param = value; OnPropertyChanged("Param"); }
            }
            
            private List<Hl7.Fhir.Model.TestScript.ActionAssertRuleParamComponent> _Param;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ActionAssertRuleComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(RuleIdElement != null) dest.RuleIdElement = (Hl7.Fhir.Model.Id)RuleIdElement.DeepCopy();
                    if(Param != null) dest.Param = new List<Hl7.Fhir.Model.TestScript.ActionAssertRuleParamComponent>(Param.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ActionAssertRuleComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ActionAssertRuleComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(RuleIdElement, otherT.RuleIdElement)) return false;
                if( !DeepComparable.Matches(Param, otherT.Param)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ActionAssertRuleComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(RuleIdElement, otherT.RuleIdElement)) return false;
                if( !DeepComparable.IsExactly(Param, otherT.Param)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("ActionAssertRuleParamComponent")]
        [DataContract]
        public partial class ActionAssertRuleParamComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ActionAssertRuleParamComponent"; } }
            
            /// <summary>
            /// Parameter name matching external assert rule parameter
            /// </summary>
            [FhirElement("name", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString NameElement
            {
                get { return _NameElement; }
                set { _NameElement = value; OnPropertyChanged("NameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _NameElement;
            
            /// <summary>
            /// Parameter name matching external assert rule parameter
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Name
            {
                get { return NameElement != null ? NameElement.Value : null; }
                set
                {
                    if(value == null)
                      NameElement = null; 
                    else
                      NameElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Name");
                }
            }
            
            /// <summary>
            /// Parameter value defined either explicitly or dynamically
            /// </summary>
            [FhirElement("value", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString ValueElement
            {
                get { return _ValueElement; }
                set { _ValueElement = value; OnPropertyChanged("ValueElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _ValueElement;
            
            /// <summary>
            /// Parameter value defined either explicitly or dynamically
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if(value == null)
                      ValueElement = null; 
                    else
                      ValueElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Value");
                }
            }
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ActionAssertRuleParamComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                    if(ValueElement != null) dest.ValueElement = (Hl7.Fhir.Model.FhirString)ValueElement.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ActionAssertRuleParamComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ActionAssertRuleParamComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ActionAssertRuleParamComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("ActionAssertRulesetComponent")]
        [DataContract]
        public partial class ActionAssertRulesetComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ActionAssertRulesetComponent"; } }
            
            /// <summary>
            /// Id of the TestScript.ruleset
            /// </summary>
            [FhirElement("rulesetId", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Id RulesetIdElement
            {
                get { return _RulesetIdElement; }
                set { _RulesetIdElement = value; OnPropertyChanged("RulesetIdElement"); }
            }
            
            private Hl7.Fhir.Model.Id _RulesetIdElement;
            
            /// <summary>
            /// Id of the TestScript.ruleset
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string RulesetId
            {
                get { return RulesetIdElement != null ? RulesetIdElement.Value : null; }
                set
                {
                    if(value == null)
                      RulesetIdElement = null; 
                    else
                      RulesetIdElement = new Hl7.Fhir.Model.Id(value);
                    OnPropertyChanged("RulesetId");
                }
            }
            
            /// <summary>
            /// The referenced rule within the ruleset
            /// </summary>
            [FhirElement("rule", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.TestScript.ActionAssertRulesetRuleComponent> Rule
            {
                get { if(_Rule==null) _Rule = new List<Hl7.Fhir.Model.TestScript.ActionAssertRulesetRuleComponent>(); return _Rule; }
                set { _Rule = value; OnPropertyChanged("Rule"); }
            }
            
            private List<Hl7.Fhir.Model.TestScript.ActionAssertRulesetRuleComponent> _Rule;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ActionAssertRulesetComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(RulesetIdElement != null) dest.RulesetIdElement = (Hl7.Fhir.Model.Id)RulesetIdElement.DeepCopy();
                    if(Rule != null) dest.Rule = new List<Hl7.Fhir.Model.TestScript.ActionAssertRulesetRuleComponent>(Rule.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ActionAssertRulesetComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ActionAssertRulesetComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(RulesetIdElement, otherT.RulesetIdElement)) return false;
                if( !DeepComparable.Matches(Rule, otherT.Rule)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ActionAssertRulesetComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(RulesetIdElement, otherT.RulesetIdElement)) return false;
                if( !DeepComparable.IsExactly(Rule, otherT.Rule)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("ActionAssertRulesetRuleComponent")]
        [DataContract]
        public partial class ActionAssertRulesetRuleComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ActionAssertRulesetRuleComponent"; } }
            
            /// <summary>
            /// Id of referenced rule within the ruleset
            /// </summary>
            [FhirElement("ruleId", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Id RuleIdElement
            {
                get { return _RuleIdElement; }
                set { _RuleIdElement = value; OnPropertyChanged("RuleIdElement"); }
            }
            
            private Hl7.Fhir.Model.Id _RuleIdElement;
            
            /// <summary>
            /// Id of referenced rule within the ruleset
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string RuleId
            {
                get { return RuleIdElement != null ? RuleIdElement.Value : null; }
                set
                {
                    if(value == null)
                      RuleIdElement = null; 
                    else
                      RuleIdElement = new Hl7.Fhir.Model.Id(value);
                    OnPropertyChanged("RuleId");
                }
            }
            
            /// <summary>
            /// Rule parameter template
            /// </summary>
            [FhirElement("param", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.TestScript.ParamComponent> Param
            {
                get { if(_Param==null) _Param = new List<Hl7.Fhir.Model.TestScript.ParamComponent>(); return _Param; }
                set { _Param = value; OnPropertyChanged("Param"); }
            }
            
            private List<Hl7.Fhir.Model.TestScript.ParamComponent> _Param;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ActionAssertRulesetRuleComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(RuleIdElement != null) dest.RuleIdElement = (Hl7.Fhir.Model.Id)RuleIdElement.DeepCopy();
                    if(Param != null) dest.Param = new List<Hl7.Fhir.Model.TestScript.ParamComponent>(Param.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ActionAssertRulesetRuleComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ActionAssertRulesetRuleComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(RuleIdElement, otherT.RuleIdElement)) return false;
                if( !DeepComparable.Matches(Param, otherT.Param)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ActionAssertRulesetRuleComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(RuleIdElement, otherT.RuleIdElement)) return false;
                if( !DeepComparable.IsExactly(Param, otherT.Param)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("ParamComponent")]
        [DataContract]
        public partial class ParamComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ParamComponent"; } }
            
            /// <summary>
            /// Parameter name matching external assert ruleset rule parameter
            /// </summary>
            [FhirElement("name", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString NameElement
            {
                get { return _NameElement; }
                set { _NameElement = value; OnPropertyChanged("NameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _NameElement;
            
            /// <summary>
            /// Parameter name matching external assert ruleset rule parameter
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Name
            {
                get { return NameElement != null ? NameElement.Value : null; }
                set
                {
                    if(value == null)
                      NameElement = null; 
                    else
                      NameElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Name");
                }
            }
            
            /// <summary>
            /// Parameter value defined either explicitly or dynamically
            /// </summary>
            [FhirElement("value", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString ValueElement
            {
                get { return _ValueElement; }
                set { _ValueElement = value; OnPropertyChanged("ValueElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _ValueElement;
            
            /// <summary>
            /// Parameter value defined either explicitly or dynamically
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if(value == null)
                      ValueElement = null; 
                    else
                      ValueElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Value");
                }
            }
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ParamComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                    if(ValueElement != null) dest.ValueElement = (Hl7.Fhir.Model.FhirString)ValueElement.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ParamComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ParamComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ParamComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("TestComponent")]
        [DataContract]
        public partial class TestComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "TestComponent"; } }
            
            /// <summary>
            /// Tracking/logging name of this test
            /// </summary>
            [FhirElement("name", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString NameElement
            {
                get { return _NameElement; }
                set { _NameElement = value; OnPropertyChanged("NameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _NameElement;
            
            /// <summary>
            /// Tracking/logging name of this test
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Name
            {
                get { return NameElement != null ? NameElement.Value : null; }
                set
                {
                    if(value == null)
                      NameElement = null; 
                    else
                      NameElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Name");
                }
            }
            
            /// <summary>
            /// Tracking/reporting short description of the test
            /// </summary>
            [FhirElement("description", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString DescriptionElement
            {
                get { return _DescriptionElement; }
                set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _DescriptionElement;
            
            /// <summary>
            /// Tracking/reporting short description of the test
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Description
            {
                get { return DescriptionElement != null ? DescriptionElement.Value : null; }
                set
                {
                    if(value == null)
                      DescriptionElement = null; 
                    else
                      DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Description");
                }
            }
            
            /// <summary>
            /// Capabilities  that are expected to function correctly on the FHIR server being tested
            /// </summary>
            [FhirElement("metadata", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.TestScript.MetadataComponent Metadata
            {
                get { return _Metadata; }
                set { _Metadata = value; OnPropertyChanged("Metadata"); }
            }
            
            private Hl7.Fhir.Model.TestScript.MetadataComponent _Metadata;
            
            /// <summary>
            /// A test operation or assert to perform
            /// </summary>
            [FhirElement("action", Order=70)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.TestScript.TestActionComponent> Action
            {
                get { if(_Action==null) _Action = new List<Hl7.Fhir.Model.TestScript.TestActionComponent>(); return _Action; }
                set { _Action = value; OnPropertyChanged("Action"); }
            }
            
            private List<Hl7.Fhir.Model.TestScript.TestActionComponent> _Action;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TestComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                    if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
                    if(Metadata != null) dest.Metadata = (Hl7.Fhir.Model.TestScript.MetadataComponent)Metadata.DeepCopy();
                    if(Action != null) dest.Action = new List<Hl7.Fhir.Model.TestScript.TestActionComponent>(Action.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new TestComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TestComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.Matches(Metadata, otherT.Metadata)) return false;
                if( !DeepComparable.Matches(Action, otherT.Action)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TestComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.IsExactly(Metadata, otherT.Metadata)) return false;
                if( !DeepComparable.IsExactly(Action, otherT.Action)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("TestActionComponent")]
        [DataContract]
        public partial class TestActionComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "TestActionComponent"; } }
            
            /// <summary>
            /// The setup operation to perform
            /// </summary>
            [FhirElement("operation", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.TestScript.OperationComponent Operation
            {
                get { return _Operation; }
                set { _Operation = value; OnPropertyChanged("Operation"); }
            }
            
            private Hl7.Fhir.Model.TestScript.OperationComponent _Operation;
            
            /// <summary>
            /// The setup assertion to perform
            /// </summary>
            [FhirElement("assert", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.TestScript.AssertComponent Assert
            {
                get { return _Assert; }
                set { _Assert = value; OnPropertyChanged("Assert"); }
            }
            
            private Hl7.Fhir.Model.TestScript.AssertComponent _Assert;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TestActionComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Operation != null) dest.Operation = (Hl7.Fhir.Model.TestScript.OperationComponent)Operation.DeepCopy();
                    if(Assert != null) dest.Assert = (Hl7.Fhir.Model.TestScript.AssertComponent)Assert.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new TestActionComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TestActionComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Operation, otherT.Operation)) return false;
                if( !DeepComparable.Matches(Assert, otherT.Assert)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TestActionComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Operation, otherT.Operation)) return false;
                if( !DeepComparable.IsExactly(Assert, otherT.Assert)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("TeardownComponent")]
        [DataContract]
        public partial class TeardownComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "TeardownComponent"; } }
            
            /// <summary>
            /// One or more teardown operations to perform
            /// </summary>
            [FhirElement("action", Order=40)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.TestScript.TeardownActionComponent> Action
            {
                get { if(_Action==null) _Action = new List<Hl7.Fhir.Model.TestScript.TeardownActionComponent>(); return _Action; }
                set { _Action = value; OnPropertyChanged("Action"); }
            }
            
            private List<Hl7.Fhir.Model.TestScript.TeardownActionComponent> _Action;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TeardownComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Action != null) dest.Action = new List<Hl7.Fhir.Model.TestScript.TeardownActionComponent>(Action.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new TeardownComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TeardownComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Action, otherT.Action)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TeardownComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Action, otherT.Action)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("TeardownActionComponent")]
        [DataContract]
        public partial class TeardownActionComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "TeardownActionComponent"; } }
            
            /// <summary>
            /// The teardown operation to perform
            /// </summary>
            [FhirElement("operation", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.TestScript.OperationComponent Operation
            {
                get { return _Operation; }
                set { _Operation = value; OnPropertyChanged("Operation"); }
            }
            
            private Hl7.Fhir.Model.TestScript.OperationComponent _Operation;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TeardownActionComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Operation != null) dest.Operation = (Hl7.Fhir.Model.TestScript.OperationComponent)Operation.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new TeardownActionComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TeardownActionComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Operation, otherT.Operation)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TeardownActionComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Operation, otherT.Operation)) return false;
                
                return true;
            }
            
        }
        
        
        /// <summary>
        /// Absolute URL used to reference this TestScript
        /// </summary>
        [FhirElement("url", InSummary=true, Order=90)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.FhirUri UrlElement
        {
            get { return _UrlElement; }
            set { _UrlElement = value; OnPropertyChanged("UrlElement"); }
        }
        
        private Hl7.Fhir.Model.FhirUri _UrlElement;
        
        /// <summary>
        /// Absolute URL used to reference this TestScript
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
        /// Logical id for this version of the TestScript
        /// </summary>
        [FhirElement("version", InSummary=true, Order=100)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString VersionElement
        {
            get { return _VersionElement; }
            set { _VersionElement = value; OnPropertyChanged("VersionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _VersionElement;
        
        /// <summary>
        /// Logical id for this version of the TestScript
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Version
        {
            get { return VersionElement != null ? VersionElement.Value : null; }
            set
            {
                if(value == null)
                  VersionElement = null; 
                else
                  VersionElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Version");
            }
        }
        
        /// <summary>
        /// Informal name for this TestScript
        /// </summary>
        [FhirElement("name", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString NameElement
        {
            get { return _NameElement; }
            set { _NameElement = value; OnPropertyChanged("NameElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _NameElement;
        
        /// <summary>
        /// Informal name for this TestScript
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Name
        {
            get { return NameElement != null ? NameElement.Value : null; }
            set
            {
                if(value == null)
                  NameElement = null; 
                else
                  NameElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Name");
            }
        }
        
        /// <summary>
        /// draft | active | retired
        /// </summary>
        [FhirElement("status", InSummary=true, Order=120)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.ConformanceResourceStatus> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.ConformanceResourceStatus> _StatusElement;
        
        /// <summary>
        /// draft | active | retired
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.ConformanceResourceStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.ConformanceResourceStatus>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// External identifier
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=130)]
        [DataMember]
        public Hl7.Fhir.Model.Identifier Identifier
        {
            get { return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private Hl7.Fhir.Model.Identifier _Identifier;
        
        /// <summary>
        /// If for testing purposes, not real usage
        /// </summary>
        [FhirElement("experimental", InSummary=true, Order=140)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean ExperimentalElement
        {
            get { return _ExperimentalElement; }
            set { _ExperimentalElement = value; OnPropertyChanged("ExperimentalElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _ExperimentalElement;
        
        /// <summary>
        /// If for testing purposes, not real usage
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? Experimental
        {
            get { return ExperimentalElement != null ? ExperimentalElement.Value : null; }
            set
            {
                if(value == null)
                  ExperimentalElement = null; 
                else
                  ExperimentalElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("Experimental");
            }
        }
        
        /// <summary>
        /// Name of the publisher (Organization or individual)
        /// </summary>
        [FhirElement("publisher", InSummary=true, Order=150)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString PublisherElement
        {
            get { return _PublisherElement; }
            set { _PublisherElement = value; OnPropertyChanged("PublisherElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _PublisherElement;
        
        /// <summary>
        /// Name of the publisher (Organization or individual)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Publisher
        {
            get { return PublisherElement != null ? PublisherElement.Value : null; }
            set
            {
                if(value == null)
                  PublisherElement = null; 
                else
                  PublisherElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Publisher");
            }
        }
        
        /// <summary>
        /// Contact details of the publisher
        /// </summary>
        [FhirElement("contact", InSummary=true, Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.TestScript.ContactComponent> Contact
        {
            get { if(_Contact==null) _Contact = new List<Hl7.Fhir.Model.TestScript.ContactComponent>(); return _Contact; }
            set { _Contact = value; OnPropertyChanged("Contact"); }
        }
        
        private List<Hl7.Fhir.Model.TestScript.ContactComponent> _Contact;
        
        /// <summary>
        /// Date for this version of the TestScript
        /// </summary>
        [FhirElement("date", InSummary=true, Order=170)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime DateElement
        {
            get { return _DateElement; }
            set { _DateElement = value; OnPropertyChanged("DateElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _DateElement;
        
        /// <summary>
        /// Date for this version of the TestScript
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Date
        {
            get { return DateElement != null ? DateElement.Value : null; }
            set
            {
                if(value == null)
                  DateElement = null; 
                else
                  DateElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("Date");
            }
        }
        
        /// <summary>
        /// Natural language description of the TestScript
        /// </summary>
        [FhirElement("description", InSummary=true, Order=180)]
        [DataMember]
        public Hl7.Fhir.Model.Markdown Description
        {
            get { return _Description; }
            set { _Description = value; OnPropertyChanged("Description"); }
        }
        
        private Hl7.Fhir.Model.Markdown _Description;
        
        /// <summary>
        /// Content intends to support these contexts
        /// </summary>
        [FhirElement("useContext", InSummary=true, Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> UseContext
        {
            get { if(_UseContext==null) _UseContext = new List<Hl7.Fhir.Model.CodeableConcept>(); return _UseContext; }
            set { _UseContext = value; OnPropertyChanged("UseContext"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _UseContext;
        
        /// <summary>
        /// Scope and Usage this Test Script is for
        /// </summary>
        [FhirElement("requirements", Order=200)]
        [DataMember]
        public Hl7.Fhir.Model.Markdown Requirements
        {
            get { return _Requirements; }
            set { _Requirements = value; OnPropertyChanged("Requirements"); }
        }
        
        private Hl7.Fhir.Model.Markdown _Requirements;
        
        /// <summary>
        /// Use and/or publishing restrictions
        /// </summary>
        [FhirElement("copyright", Order=210)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString CopyrightElement
        {
            get { return _CopyrightElement; }
            set { _CopyrightElement = value; OnPropertyChanged("CopyrightElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _CopyrightElement;
        
        /// <summary>
        /// Use and/or publishing restrictions
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Copyright
        {
            get { return CopyrightElement != null ? CopyrightElement.Value : null; }
            set
            {
                if(value == null)
                  CopyrightElement = null; 
                else
                  CopyrightElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Copyright");
            }
        }
        
        /// <summary>
        /// An abstract server representing a client or sender in a message exchange
        /// </summary>
        [FhirElement("origin", Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.TestScript.OriginComponent> Origin
        {
            get { if(_Origin==null) _Origin = new List<Hl7.Fhir.Model.TestScript.OriginComponent>(); return _Origin; }
            set { _Origin = value; OnPropertyChanged("Origin"); }
        }
        
        private List<Hl7.Fhir.Model.TestScript.OriginComponent> _Origin;
        
        /// <summary>
        /// An abstract server representing a destination or receiver in a message exchange
        /// </summary>
        [FhirElement("destination", Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.TestScript.DestinationComponent> Destination
        {
            get { if(_Destination==null) _Destination = new List<Hl7.Fhir.Model.TestScript.DestinationComponent>(); return _Destination; }
            set { _Destination = value; OnPropertyChanged("Destination"); }
        }
        
        private List<Hl7.Fhir.Model.TestScript.DestinationComponent> _Destination;
        
        /// <summary>
        /// Required capability that is assumed to function correctly on the FHIR server being tested
        /// </summary>
        [FhirElement("metadata", Order=240)]
        [DataMember]
        public Hl7.Fhir.Model.TestScript.MetadataComponent Metadata
        {
            get { return _Metadata; }
            set { _Metadata = value; OnPropertyChanged("Metadata"); }
        }
        
        private Hl7.Fhir.Model.TestScript.MetadataComponent _Metadata;
        
        /// <summary>
        /// Fixture in the test script - by reference (uri)
        /// </summary>
        [FhirElement("fixture", Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.TestScript.FixtureComponent> Fixture
        {
            get { if(_Fixture==null) _Fixture = new List<Hl7.Fhir.Model.TestScript.FixtureComponent>(); return _Fixture; }
            set { _Fixture = value; OnPropertyChanged("Fixture"); }
        }
        
        private List<Hl7.Fhir.Model.TestScript.FixtureComponent> _Fixture;
        
        /// <summary>
        /// Reference of the validation profile
        /// </summary>
        [FhirElement("profile", Order=260)]
        [References()]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> Profile
        {
            get { if(_Profile==null) _Profile = new List<Hl7.Fhir.Model.ResourceReference>(); return _Profile; }
            set { _Profile = value; OnPropertyChanged("Profile"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _Profile;
        
        /// <summary>
        /// Placeholder for evaluated elements
        /// </summary>
        [FhirElement("variable", Order=270)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.TestScript.VariableComponent> Variable
        {
            get { if(_Variable==null) _Variable = new List<Hl7.Fhir.Model.TestScript.VariableComponent>(); return _Variable; }
            set { _Variable = value; OnPropertyChanged("Variable"); }
        }
        
        private List<Hl7.Fhir.Model.TestScript.VariableComponent> _Variable;
        
        /// <summary>
        /// Assert rule used within the test script
        /// </summary>
        [FhirElement("rule", Order=280)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.TestScript.RuleComponent> Rule
        {
            get { if(_Rule==null) _Rule = new List<Hl7.Fhir.Model.TestScript.RuleComponent>(); return _Rule; }
            set { _Rule = value; OnPropertyChanged("Rule"); }
        }
        
        private List<Hl7.Fhir.Model.TestScript.RuleComponent> _Rule;
        
        /// <summary>
        /// Assert ruleset used within the test script
        /// </summary>
        [FhirElement("ruleset", Order=290)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.TestScript.RulesetComponent> Ruleset
        {
            get { if(_Ruleset==null) _Ruleset = new List<Hl7.Fhir.Model.TestScript.RulesetComponent>(); return _Ruleset; }
            set { _Ruleset = value; OnPropertyChanged("Ruleset"); }
        }
        
        private List<Hl7.Fhir.Model.TestScript.RulesetComponent> _Ruleset;
        
        /// <summary>
        /// A series of required setup operations before tests are executed
        /// </summary>
        [FhirElement("setup", Order=300)]
        [DataMember]
        public Hl7.Fhir.Model.TestScript.SetupComponent Setup
        {
            get { return _Setup; }
            set { _Setup = value; OnPropertyChanged("Setup"); }
        }
        
        private Hl7.Fhir.Model.TestScript.SetupComponent _Setup;
        
        /// <summary>
        /// A test in this script
        /// </summary>
        [FhirElement("test", Order=310)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.TestScript.TestComponent> Test
        {
            get { if(_Test==null) _Test = new List<Hl7.Fhir.Model.TestScript.TestComponent>(); return _Test; }
            set { _Test = value; OnPropertyChanged("Test"); }
        }
        
        private List<Hl7.Fhir.Model.TestScript.TestComponent> _Test;
        
        /// <summary>
        /// A series of required clean up steps
        /// </summary>
        [FhirElement("teardown", Order=320)]
        [DataMember]
        public Hl7.Fhir.Model.TestScript.TeardownComponent Teardown
        {
            get { return _Teardown; }
            set { _Teardown = value; OnPropertyChanged("Teardown"); }
        }
        
        private Hl7.Fhir.Model.TestScript.TeardownComponent _Teardown;
        
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as TestScript;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(UrlElement != null) dest.UrlElement = (Hl7.Fhir.Model.FhirUri)UrlElement.DeepCopy();
                if(VersionElement != null) dest.VersionElement = (Hl7.Fhir.Model.FhirString)VersionElement.DeepCopy();
                if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.ConformanceResourceStatus>)StatusElement.DeepCopy();
                if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.Identifier)Identifier.DeepCopy();
                if(ExperimentalElement != null) dest.ExperimentalElement = (Hl7.Fhir.Model.FhirBoolean)ExperimentalElement.DeepCopy();
                if(PublisherElement != null) dest.PublisherElement = (Hl7.Fhir.Model.FhirString)PublisherElement.DeepCopy();
                if(Contact != null) dest.Contact = new List<Hl7.Fhir.Model.TestScript.ContactComponent>(Contact.DeepCopy());
                if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.FhirDateTime)DateElement.DeepCopy();
                if(Description != null) dest.Description = (Hl7.Fhir.Model.Markdown)Description.DeepCopy();
                if(UseContext != null) dest.UseContext = new List<Hl7.Fhir.Model.CodeableConcept>(UseContext.DeepCopy());
                if(Requirements != null) dest.Requirements = (Hl7.Fhir.Model.Markdown)Requirements.DeepCopy();
                if(CopyrightElement != null) dest.CopyrightElement = (Hl7.Fhir.Model.FhirString)CopyrightElement.DeepCopy();
                if(Origin != null) dest.Origin = new List<Hl7.Fhir.Model.TestScript.OriginComponent>(Origin.DeepCopy());
                if(Destination != null) dest.Destination = new List<Hl7.Fhir.Model.TestScript.DestinationComponent>(Destination.DeepCopy());
                if(Metadata != null) dest.Metadata = (Hl7.Fhir.Model.TestScript.MetadataComponent)Metadata.DeepCopy();
                if(Fixture != null) dest.Fixture = new List<Hl7.Fhir.Model.TestScript.FixtureComponent>(Fixture.DeepCopy());
                if(Profile != null) dest.Profile = new List<Hl7.Fhir.Model.ResourceReference>(Profile.DeepCopy());
                if(Variable != null) dest.Variable = new List<Hl7.Fhir.Model.TestScript.VariableComponent>(Variable.DeepCopy());
                if(Rule != null) dest.Rule = new List<Hl7.Fhir.Model.TestScript.RuleComponent>(Rule.DeepCopy());
                if(Ruleset != null) dest.Ruleset = new List<Hl7.Fhir.Model.TestScript.RulesetComponent>(Ruleset.DeepCopy());
                if(Setup != null) dest.Setup = (Hl7.Fhir.Model.TestScript.SetupComponent)Setup.DeepCopy();
                if(Test != null) dest.Test = new List<Hl7.Fhir.Model.TestScript.TestComponent>(Test.DeepCopy());
                if(Teardown != null) dest.Teardown = (Hl7.Fhir.Model.TestScript.TeardownComponent)Teardown.DeepCopy();
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new TestScript());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as TestScript;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if( !DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if( !DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
            if( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.Matches(Description, otherT.Description)) return false;
            if( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
            if( !DeepComparable.Matches(Requirements, otherT.Requirements)) return false;
            if( !DeepComparable.Matches(CopyrightElement, otherT.CopyrightElement)) return false;
            if( !DeepComparable.Matches(Origin, otherT.Origin)) return false;
            if( !DeepComparable.Matches(Destination, otherT.Destination)) return false;
            if( !DeepComparable.Matches(Metadata, otherT.Metadata)) return false;
            if( !DeepComparable.Matches(Fixture, otherT.Fixture)) return false;
            if( !DeepComparable.Matches(Profile, otherT.Profile)) return false;
            if( !DeepComparable.Matches(Variable, otherT.Variable)) return false;
            if( !DeepComparable.Matches(Rule, otherT.Rule)) return false;
            if( !DeepComparable.Matches(Ruleset, otherT.Ruleset)) return false;
            if( !DeepComparable.Matches(Setup, otherT.Setup)) return false;
            if( !DeepComparable.Matches(Test, otherT.Test)) return false;
            if( !DeepComparable.Matches(Teardown, otherT.Teardown)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as TestScript;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if( !DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if( !DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
            if( !DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.IsExactly(Description, otherT.Description)) return false;
            if( !DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
            if( !DeepComparable.IsExactly(Requirements, otherT.Requirements)) return false;
            if( !DeepComparable.IsExactly(CopyrightElement, otherT.CopyrightElement)) return false;
            if( !DeepComparable.IsExactly(Origin, otherT.Origin)) return false;
            if( !DeepComparable.IsExactly(Destination, otherT.Destination)) return false;
            if( !DeepComparable.IsExactly(Metadata, otherT.Metadata)) return false;
            if( !DeepComparable.IsExactly(Fixture, otherT.Fixture)) return false;
            if( !DeepComparable.IsExactly(Profile, otherT.Profile)) return false;
            if( !DeepComparable.IsExactly(Variable, otherT.Variable)) return false;
            if( !DeepComparable.IsExactly(Rule, otherT.Rule)) return false;
            if( !DeepComparable.IsExactly(Ruleset, otherT.Ruleset)) return false;
            if( !DeepComparable.IsExactly(Setup, otherT.Setup)) return false;
            if( !DeepComparable.IsExactly(Test, otherT.Test)) return false;
            if( !DeepComparable.IsExactly(Teardown, otherT.Teardown)) return false;
            
            return true;
        }
        
    }
    
}
