/** @format */

// import React from "react";
import styles from "assets/styles/Header.module.css";
import { Button } from "./Button";

export function Header() {
  return (
    <header>
      <img className={styles.icareLogo} src="I_care.jpg" alt="Icare logo" />
      <div className={styles.linkContainer}>
        <Button>login</Button>
        <Button>sign up</Button>
      </div>
    </header>
  );
}
