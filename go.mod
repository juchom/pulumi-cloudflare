module github.com/pulumi/pulumi-cloudflare

go 1.13

require (
	github.com/hashicorp/terraform-plugin-sdk v1.4.1
	github.com/pkg/errors v0.8.1
	github.com/pulumi/pulumi v1.6.0
	github.com/pulumi/pulumi-terraform-bridge v1.5.3-0.20200116214742-68c8f56da38a
	github.com/terraform-providers/terraform-provider-cloudflare v1.18.2-0.20191218221712-fc4389e24ebf
)

replace github.com/Azure/go-autorest => github.com/Azure/go-autorest v12.4.3+incompatible
