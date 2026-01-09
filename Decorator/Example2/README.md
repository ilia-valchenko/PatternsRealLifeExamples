Decorator pattern lets you dynamically change the behavior of an object at run time by wrapping them in an object of a decorator class. This pattern allows you to add encryption, compression, buffering, etc., to any stream without modifying the core stream classes.

This example mimcs how .NET's `Stream` classes work:
- `FileStream` (concrete component)
- `GZipStream` (component decorator)
- `CryptoStream` (encryption decorator)
- You can chain them: `new GZipStream(new CryptoStream(new FileStream(...)))`

Why this is a good example:
- Clear responsibilities: Each decorator does one thing
- Flexible composition: Can add/remove encryption/compression independently
- Transparent: Calling code doesn't know if data is encrypted/compressed
