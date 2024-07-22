/** @format */

import { useState } from "react";

import "./App.css";
import { LandingPage } from "pages/LandingPage";
import React from "react";

function App() {
  const [count, setCount] = useState(0);

  return <LandingPage></LandingPage>;
}

export default App;
