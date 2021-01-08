# kvk-api-dotnet

### What's the repo about?
The purpose of this repository is to demonstrate how to consume the Kamer van Koophandel (KVK) API with C#/dotnet-core/.NET5, incl. using the custom TLS/SSL implementation of the root certificate used by Dutch governmental agencies.

#### Warning - do the right thing
There is a shortcut available if you're either too lazy to read through this, or if you simply can't be bothered, by skipping all certificate validation together. 
Like so:

    // don't... do this
    handler.ServerCertificateCustomValidationCallback = (message, cert, chain, _) => true;

The warning is simple: just don't do it. [It was mentioned once but I think we got away with it...](https://hanssens.com/uncategorized/error-the-underlying-connection-was-closed-could-not-establish-trust-relationship-for-the-ssltls-secure-channel/) With this example it should be no excuse to do it properly.

### Why?
The Kamer van Koophandel (KVK) is the national, governmental Chamber of Commerce in the Netherlands and provides an API to consult the register with all companies. 

As of fall 2020, the api has been secured with a custom, self-signed root certificate. Signed by a governmental. 

As the docs on https://developers.kvk.nl/guides formally mention:

> The new “Staat der Nederlanden Private Root CA – G1” certificate chain, that is used by the new api.kvk.nl certificate, is by default not trusted by your application. Therefore, you need to add the new chain to your trust-list. Depending on your application platform or operation system the location of your trust-list may vary. If the new trust chain is not added before September 28th, 2020 20:00 you will no longer be able to connect to api.kvk.nl and KVK API Search & Profile.

The written instructions provide sysop/devops instructions for server operators on how to install their custom root/intermediate certificates on a system, but not so much for developers. Especially not for C#/.NET. Therefor, in this example we'll target the following two issues with a solution:

Issue 1. Certificates are provided only in .crt format, whilst some environments require it to be .cer
Issue 2. No instructions for C#/dotnet, only for server operators

## Solutions

### Solution for issue 1: .cer vs .crt

> N.B. I'm sure cryptography purists will dislike the way the comparison between cer/crt below is oversimplified. Feel free to suggest an edit ;)

CER and CRT are pretty much the same, or at least serve the same purpose. As a rule of thumb you can say that Windows mostly has .CER, xNIX uses .CRT.
Windows handles it differently as well: open up a .crt will import it directly into Windows Root Certificate store, whilst a .CER file will popup in a dial just to display details and not install anything. 

One thing to keep in mind is that the extension .crt (and also .cer) can contain both PEM and DER encoded formats. Thus looking at the extension, you cannot say whether it is a PEM or DER key/cert. 

This makes converting it trickier, or at least not so straight forward. 

Luckily, there is a better 

Instead of downloading the files from the KVK TLS Certificate Guide at:

```
https://developers.kvk.nl/guides
```

you're better off downloading all offical certificates, or at least the root certificate, from the origin at PKIoverheid (Logius). Here all Dutch governmental certificates are conveniently available in .CER format:

```
https://www.pkioverheid.nl/
```

The certificate(s) in the `./Cert` folder of this GitHub repo originate from pkioverheid, but I strongly encourage you to be sure to download them from the origin at pkioverheid.nl yourself!

### Solution for issue 2: instructions for dotnet/c#

The instructions assume you have **full root access to the server**, or even that it runs on a server with a linux/windows OS. Instructions are not provided for cloud services, like Azure/AWS etc. And certainly not for .NET. 

This repo is an example on how to appply http calls with a custom certificate validator that reads + handles the custom root certificate properly. It's a simple way to test the SSL validity of the https://ssltest.kvk.nl endpoint, by executing a simple http call (with the custom validator).

To verify it on your system, simply **run the tests**:

	$ dotnet test

	Starting test execution, please wait...
	A total of 1 test files matched the specified pattern.

	Passed!  - Failed:     0, Passed:     3, Skipped:     0, Total:     3, Duration: 249 ms -

For this, be sure you're capable of running .NET 5 (5.0.100 or higher):

	$ dotnet --version
	5.0.100





