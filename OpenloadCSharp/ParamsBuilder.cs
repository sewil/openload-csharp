using System.Collections.Generic;

namespace OpenloadCSharp
{
    class ParamsBuilder : Dictionary<string, object>
    {
        public override string ToString()
        {
            string parameters = "";
            bool first = true;
            foreach (var parameter in this)
            {
                if (parameter.Value != null)
                {
                    if (first)
                    {
                        first = false;
                    }
                    else
                    {
                        parameters += "&";
                    }

                    parameters += $"{parameter.Key}={parameter.Value}";
                }

            }

            return parameters;
        }
    }
}
