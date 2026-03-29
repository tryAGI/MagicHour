dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://docs.magichour.ai/api-reference/openapi.json
autosdk generate openapi.yaml \
  --namespace MagicHour \
  --clientClassName MagicHourClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
