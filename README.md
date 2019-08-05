
# react-native-auto-startup

## Getting started

`$ npm install react-native-auto-startup --save`

### Mostly automatic installation

`$ react-native link react-native-auto-startup`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-auto-startup` and add `RNAutoStartup.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNAutoStartup.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNAutoStartupPackage;` to the imports at the top of the file
  - Add `new RNAutoStartupPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-auto-startup'
  	project(':react-native-auto-startup').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-auto-startup/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-auto-startup')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNAutoStartup.sln` in `node_modules/react-native-auto-startup/windows/RNAutoStartup.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Auto.Startup.RNAutoStartup;` to the usings at the top of the file
  - Add `new RNAutoStartupPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNAutoStartup from 'react-native-auto-startup';

// TODO: What to do with the module?
RNAutoStartup;
```
  