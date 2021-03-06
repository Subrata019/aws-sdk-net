/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the DetachPolicy operation.
    /// Detaches a policy from a target root, organizational unit (OU), or account. If the
    /// policy being detached is a service control policy (SCP), the changes to permissions
    /// for IAM users and roles in affected accounts are immediate.
    /// 
    ///  
    /// <para>
    ///  <b>Note:</b> Every root, OU, and account must have at least one SCP attached. You
    /// can replace the default <code>FullAWSAccess</code> policy with one that limits the
    /// permissions that can be delegated. To do that, you must attach the replacement policy
    /// before you can remove the default one. This is the authorization strategy of using
    /// an <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_about-scps.html#orgs_policies_whitelist">allow
    /// list</a>. You could instead attach a second SCP and leave the <code>FullAWSAccess</code>
    /// SCP still attached. You could then specify <code>"Effect": "Deny"</code> in the second
    /// SCP to override the <code>"Effect": "Allow"</code> in the <code>FullAWSAccess</code>
    /// policy (or any other attached SCP). If you take these steps, you're using the authorization
    /// strategy of a <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_about-scps.html#orgs_policies_blacklist">deny
    /// list</a>. 
    /// </para>
    ///  
    /// <para>
    /// This operation can be called only from the organization's master account.
    /// </para>
    /// </summary>
    public partial class DetachPolicyRequest : AmazonOrganizationsRequest
    {
        private string _policyId;
        private string _targetId;

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The unique identifier (ID) of the policy you want to detach. You can get the ID from
        /// the <a>ListPolicies</a> or <a>ListPoliciesForTarget</a> operations.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for a policy ID string
        /// requires "p-" followed by from 8 to 128 lowercase or uppercase letters, digits, or
        /// the underscore character (_).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PolicyId
        {
            get { return this._policyId; }
            set { this._policyId = value; }
        }

        // Check to see if PolicyId property is set
        internal bool IsSetPolicyId()
        {
            return this._policyId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetId. 
        /// <para>
        /// The unique identifier (ID) of the root, OU, or account that you want to detach the
        /// policy from. You can get the ID from the <a>ListRoots</a>, <a>ListOrganizationalUnitsForParent</a>,
        /// or <a>ListAccounts</a> operations.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for a target ID string
        /// requires one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Root</b> - A string that begins with "r-" followed by from 4 to 32 lowercase letters
        /// or digits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Account</b> - A string that consists of exactly 12 digits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Organizational unit (OU)</b> - A string that begins with "ou-" followed by from
        /// 4 to 32 lowercase letters or digits (the ID of the root that the OU is in). This string
        /// is followed by a second "-" dash and from 8 to 32 additional lowercase letters or
        /// digits.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetId
        {
            get { return this._targetId; }
            set { this._targetId = value; }
        }

        // Check to see if TargetId property is set
        internal bool IsSetTargetId()
        {
            return this._targetId != null;
        }

    }
}