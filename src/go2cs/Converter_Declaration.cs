﻿//******************************************************************************************************
//  Converter_Declaration.cs - Gbtc
//
//  Copyright © 2018, Grid Protection Alliance.  All Rights Reserved.
//
//  Licensed to the Grid Protection Alliance (GPA) under one or more contributor license agreements. See
//  the NOTICE file distributed with this work for additional information regarding copyright ownership.
//  The GPA licenses this file to you under the MIT License (MIT), the "License"; you may not use this
//  file except in compliance with the License. You may obtain a copy of the License at:
//
//      http://opensource.org/licenses/MIT
//
//  Unless agreed to in writing, the subject software distributed under the License is distributed on an
//  "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
//  License for the specific language governing permissions and limitations.
//
//  Code Modification History:
//  ----------------------------------------------------------------------------------------------------
//  07/12/2018 - J. Ritchie Carroll
//       Generated original version of source code.
//
//******************************************************************************************************

namespace go2cs
{
    public partial class Converter
    {
        public override void EnterDeclaration(GolangParser.DeclarationContext context)
        {
            if (!m_inFunction)
            {
                if (!m_firstTopLevelDeclaration)
                    m_targetFile.AppendLine();

                if (!string.IsNullOrWhiteSpace(m_nextDeclComments))
                    m_targetFile.Append(FixForwardSpacing(m_nextDeclComments));
            }
        }
    }
}